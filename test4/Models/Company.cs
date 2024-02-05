using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;
using test4.Dto;

namespace test4.Models
{
    public class Company
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

        public void Edit(UpdateCompany updatemodel)
        {
            CompanyName = updatemodel.CompanyName;
            CompanyPhone = updatemodel.CompanyPhone;
            CompanyAddress = updatemodel.CompanyAddress;
        }

    }

}
