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
        [HttpGet("CompanyName")]
        public ActionResult<MemberDto> GetMembersInCompany([FromQuery] string CompanyName)
        {
            var MembersInCompany = from member in _apiDBContext.Member
                                   join company in _apiDBContext.Company
                                   on member.CompanyID equals company.CompanyId
                                   where company.CompanyName == CompanyName
                                   select new MemberDto
                                   {
                                       MemberId = member.MemberId,
                                       Name = member.Name,
                                       PhoneNumber = member.PhoneNumber,
                                       Address = member.Address
                                   };

            var membersList = MembersInCompany.ToList();

            if (membersList == null || membersList.Count == 0)
            {
                return NotFound("找不到該公司或該公司沒有成員");
            }

            return Ok(membersList);
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
