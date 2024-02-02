using Microsoft.AspNetCore.Mvc;
using test4.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace test4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly apiDBContext _apiDBContext;
        public MemberController(apiDBContext apiDBContext)
        {
            _apiDBContext = apiDBContext;
        }
        // GET: api/<MemberController>
        [HttpGet]
        public IEnumerable<Member> Get()
        {
            return _apiDBContext.Member.ToList();
        }

        //// GET api/<MemberController>/5
        //[HttpGet("Name")]
        //public ActionResult<Member>GetName(string Name)
        //{
        //    return _apiDBContext.Member.FirstOrDefault(c => c.Name == Name);
        //}

        // POST api/<MemberController>
        [HttpPost("MemberAdd")]
        public IActionResult Post([FromBody] Member req)
        {
            try
            {
                if (req == null)
                {
                    return BadRequest("資料為空");
                }
                _apiDBContext.Member.Add(req);
                _apiDBContext.SaveChanges();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
            return Ok("新增成功！");
        }

        // POST api/member/DeleteItem/5
        [HttpPost("MemberDelete")]
        public ActionResult Delete(int id)
        {
            var itemDelete = _apiDBContext.Member.FirstOrDefault(i => i.MemberId == id);

            if (itemDelete == null)
            {
                return NotFound(); // 資源不存在
            }

            _apiDBContext.Member.Remove(itemDelete);
            _apiDBContext.SaveChanges();

            return NoContent(); // 成功刪除，回傳 204 No Content
        }

        [HttpPost("MemberUpdate")]
        public ActionResult Update(int id, [FromBody] Member updatemodel)
        {
            var listudate = _apiDBContext.Member.FirstOrDefault(i => i.MemberId == id);

            if (listudate == null)
            {
                return NotFound(); // 資源不存在
            }
            listudate.PhoneNumber = updatemodel.PhoneNumber;
            listudate.Address = updatemodel.Address;
            listudate.Name = updatemodel.Name;
            listudate.CompanyID = updatemodel.CompanyID;

            _apiDBContext.SaveChanges();

            return NoContent(); // 成功刪除，回傳 204 No Content
        }

        // PUT api/<MemberController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MemberController>/5
      //  [HttpDelete("{id}")]
      // public void Delete(int id)
//{
//}
    }
}
