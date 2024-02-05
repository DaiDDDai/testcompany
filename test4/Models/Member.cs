
using System.ComponentModel.DataAnnotations;
using test4.Dto;

namespace test4.Models
{
    public class Member
    {
        /// <summary>
        /// 會員ID
        /// </summary>
        [Key]
        public int MemberId { get; set; }
        /// <summary>
        /// 會員姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 會員電話
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// 會員地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 會員所屬公司ID
        /// </summary>
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
