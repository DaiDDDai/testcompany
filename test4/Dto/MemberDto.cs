using test4.Models;

namespace test4.Dto
{
    public class MemberDto
    {
        /// <summary>
        /// 會員ID
        /// </summary>
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

    }
}
