using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;
using test4.Dto;
using test4.Models;
using static test4.Dto.ShoppingListDto;

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
        [HttpGet("MemberName")]
        public ActionResult<ShoppingListDto> GetSoppingListInMember(string MemberName)
        {
            var query = from member in _apiDBContext.Member
                        join shoppingList in _apiDBContext.SoppingList
                        on member.MemberId equals shoppingList.MemberID
                        where member.Name == MemberName
                        select new Itemlist
                        {
                            Items = shoppingList.Items,
                            Amount = shoppingList.Amount,
                            Money = shoppingList.Money,
                            Total = shoppingList.Amount * shoppingList.Money,
                        };

            var totalItems = query.Count();
            var totalAmount = query.Sum(item => item.Amount);
            var totalMoney = query.Sum(item => item.Money * item.Amount);
            var result = query.ToList();
            

            if (result == null)
            {
                return NotFound("找不到該公司或該公司沒有成員");
            }


            return Ok(new ShoppingListDto
            {
                list = result,
                TotalItems = totalItems,
                TotalAmount = totalAmount,
                TotalMoney = totalMoney
            });
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
