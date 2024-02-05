
using System.ComponentModel.DataAnnotations;
using test4.Dto;

namespace test4.Models
{
    public class Member
    {
        [Key]
        public int MemberId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public int CompanyID { get; set; }

        public void Edit(UpdateMember updatemodel)
        {
            Name = updatemodel.Name;
            PhoneNumber = updatemodel.PhoneNumber;
            Address = updatemodel.Address;
            CompanyID = updatemodel.CompanyID;
        }

    }

}
