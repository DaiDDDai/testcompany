using Microsoft.AspNetCore.Mvc;
using System.Linq;
using test4.Dto;
using test4.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace test4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly apiDBContext _apiDBContext;
        public CompanyController(apiDBContext apiDBContext)
        {
            _apiDBContext = apiDBContext;
        }
        // // GET: api/company
        [HttpGet]
        public IEnumerable<Company> Get()
        {
            return _apiDBContext.Company.ToList();
        }

        //// GET: api/company/5
        //[HttpGet("GetCompanyname")]
        //public ActionResult<Company> GetCompanyByName([FromQuery]string companyName)
        //{
        //    return _apiDBContext.Company.FirstOrDefault(c => c.CompanyName == companyName);
        //}

        // POST api/company
        [HttpPost("CompanyAdd")]
        public IActionResult Post([FromBody] Company obj)
        {
            if (obj == null)
            {
                return BadRequest("資料為空");
            }
            _apiDBContext.Company.Add(obj);
            _apiDBContext.SaveChanges();
            return Ok("新增成功！");

        }

        // POST api/company/DeleteItem/5
        [HttpPost("CompanyDelete")]
        public ActionResult Delete(int id)
        {
            var itemDelete = _apiDBContext.Company.FirstOrDefault(i => i.CompanyId == id);

            if (itemDelete == null)
            {
                return NotFound(); // 資源不存在
            }

            _apiDBContext.Company.Remove(itemDelete);
            _apiDBContext.SaveChanges();

            return NoContent(); // 成功刪除，回傳 204 No Content
        }

        [HttpPost("CompanyUpdate")]
        public ActionResult Update([FromBody] UpdateCompany updatemodel)
        {
            var listupdate = _apiDBContext.Company.FirstOrDefault(i => i.CompanyId == updatemodel.CompanyId);

            if (listupdate == null)
            {
                return NotFound(); // 資源不存在
            }
            
            listupdate.CompanyPhone = updatemodel.CompanyPhone;
            listupdate.CompanyName = updatemodel.CompanyName;
            listupdate.CompanyAddress = updatemodel.CompanyAddress;


            _apiDBContext.SaveChanges();

            return NoContent(); // 成功刪除，回傳 204 No Content
        }



        // PUT api/<testController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<testController>/5
      //  [HttpDelete("{id}")]
        //public void Delete(int id)
   //   /  {
//}
    }
}
