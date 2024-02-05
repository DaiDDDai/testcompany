using System.ComponentModel.DataAnnotations;

namespace test4.Dto
{
    public class UpdateCompany
    {
        /// <summary>
        /// 公司ID
        /// </summary>
        [Key]
        public int CompanyId { get; set; }
        /// <summary>
        /// 公司名稱
        /// </summary>
        public string CompanyName { get; set; }
        /// <summary>
        /// 公司電話
        /// </summary>
        public string CompanyPhone { get; set; }
        /// <summary>
        /// 公司地址
        /// </summary>
        public string CompanyAddress { get; set; }



    }
}
