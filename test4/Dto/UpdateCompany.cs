using System.ComponentModel.DataAnnotations;

namespace test4.Dto
{
    public class UpdateCompany
    {
        [Key]
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyPhone { get; set; }
        public string CompanyAddress { get; set; }
    }
}
