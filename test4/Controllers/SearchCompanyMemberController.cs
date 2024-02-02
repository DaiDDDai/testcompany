using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;
using test4.Dto;
using test4.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace test4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchCompanyMemberController : ControllerBase
    {
        private readonly apiDBContext _apiDBContext;

        public SearchCompanyMemberController(apiDBContext apiDBContext)
        {
            _apiDBContext = apiDBContext;
        }
        // GET: api/<SearchController>
        [HttpGet("member")]
        public ActionResult<MemberDto> GetMembersInCompany([FromQuery] string CompanyName)
        {
            var MembersInCompany = _apiDBContext.Member
              .Where(m => m.Company.CompanyName == CompanyName)
              .Select(m => new MemberDto
              {
                   MemberId = m.MemberId,
                   Name = m.Name,
                   PhoneNumber = m.PhoneNumber,
                   Address = m.Address
        })
        .ToList();

            if (MembersInCompany == null)
            {
                return NotFound("找不到該公司或該公司沒有成員");
            }

            return Ok(MembersInCompany);
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
