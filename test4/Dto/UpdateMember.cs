using System.ComponentModel.DataAnnotations;

namespace test4.Dto
{
    public class UpdateMember
    {
        [Key]
        public int MemberId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int CompanyID { get; set; }

    }
}
