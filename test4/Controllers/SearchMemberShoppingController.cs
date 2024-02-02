using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;
using test4.Dto;
using test4.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace test4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchMemberShoppingController : ControllerBase
    {
        private readonly apiDBContext _apiDBContext;

        public SearchMemberShoppingController(apiDBContext apiDBContext)
        {
            _apiDBContext = apiDBContext;
        }
        // GET: api/<SearchController>
        [HttpGet("shoppinglist")]
        public ActionResult<ShoppingListDto> GetSoppingListInMember(string MemberName)
        {
            var SoppingListInMember = _apiDBContext.SoppingList
              .Where(m => m.member.Name == MemberName)
              .Select(m => new ShoppingListDto
              {
                   SoppingListId = m.SoppingListId,
                   Amount = m.Amount,
                   Items = m.Items,
                   Money = m.Money
        })
        .ToList();

            if (SoppingListInMember == null)
            {
                return NotFound("找不到該公司或該公司沒有成員");
            }

            return Ok(SoppingListInMember);
        }

        // POST api/<SearchController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SearchController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SearchController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
