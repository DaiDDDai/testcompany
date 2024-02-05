using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;
using test4.Dto;

namespace test4.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyPhone { get; set; }
        public string CompanyAddress { get; set; }

        public void Edit(UpdateCompany updatemodel)
        {
            CompanyName = updatemodel.CompanyName;
            CompanyPhone = updatemodel.CompanyPhone;
            CompanyAddress = updatemodel.CompanyAddress;
        }

    }

}
