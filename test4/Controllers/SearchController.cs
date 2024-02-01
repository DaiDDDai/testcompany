using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;
using test4.Dto;
using test4.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace test4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly apiDBContext _apiDBContext;

        public SearchController (apiDBContext apiDBContext)
        {
            _apiDBContext = apiDBContext;
        }
        // GET: api/<SearchController>
        [HttpGet("member/{companyName}")]
        public ActionResult<SearchDto> GetMemberInCompany(string companyName)
        {
            var company = _apiDBContext.Company
            .Include(c => c.Member)  // 在查询时包含 Company 实体的 Members 导航属性
            .FirstOrDefault(c => c.CompanyName == companyName);

            if (company == null)
            {
                return NotFound("找不到該公司");
            }

            var SearchDto = new SearchDto
            {
                CompanyName = company.CompanyName,
                MemberNames = company.Member.Select(m => m.Name).ToList()
            };

            return Ok(SearchDto);
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
