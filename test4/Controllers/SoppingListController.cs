using Microsoft.AspNetCore.Mvc;
using test4.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace test4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SoppingListController : ControllerBase
    {
        private readonly apiDBContext _apiDBContext;
        public SoppingListController(apiDBContext apiDBContext)
        {
            _apiDBContext = apiDBContext;
        }
        // GET: api/<SoppingController>
        [HttpGet]
        public IEnumerable<SoppingList> Get()
        {
            return _apiDBContext.SoppingList.ToList();
        }


        //// GET api/<SoppingController>/5
        //[HttpGet("{Items}")]
        //public ActionResult<SoppingList> GetItems(string obj)
        //{
        //    return _apiDBContext.SoppingList.FirstOrDefault(c => c.Items == obj);
        //}

        // POST api/<SoppingController>
        [HttpPost("Add")]
        public IActionResult Post([FromBody] SoppingList req)
        {
            if (req == null)
            {
                return BadRequest("資料為空");
            }
            _apiDBContext.SoppingList.Add(req);
            _apiDBContext.SaveChanges();
            return Ok("新增成功！");
        }
        // POST api/SoppingList/DeleteItem/5
        [HttpPost("DeleteItem")]
        public ActionResult Delete(int id)
        {
            var itemDelete = _apiDBContext.SoppingList.FirstOrDefault(i => i.SoppingListId == id);

            if (itemDelete == null)
            {
                return NotFound(); // 資源不存在
            }

            _apiDBContext.SoppingList.Remove(itemDelete);
            _apiDBContext.SaveChanges();

            return NoContent(); // 成功刪除，回傳 204 No Content
        }

        // PUT api/<SoppingController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SoppingController>/5
       // [HttpDelete("{id}")]
      //  public void Delete(int id)
     //   {
     //   }
    }
}
