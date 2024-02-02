﻿
using System.ComponentModel.DataAnnotations;

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

        public Company Company { get; set; } // 导航属性
        public List<SoppingList> SoppingLists { get; set; } // 另一端的导航属性


    }

}
