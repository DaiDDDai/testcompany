using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;

namespace test4.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyPhone { get; set; }
        public string CompanyAddress { get; set; }

    }

}
