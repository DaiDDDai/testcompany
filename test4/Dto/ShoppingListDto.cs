using System.ComponentModel.DataAnnotations;

namespace test4.Dto
{
    public class ShoppingListDto
    {
        /// <summary>
        /// 購物清單ID
        /// </summary>
        public int SoppingListId { get; set; }
        /// <summary>
        /// 商品種類
        /// </summary>
        public string Items { get; set; }
        /// <summary>
        /// 商品數量
        /// </summary>
        public int Amount { get; set; }
        /// <summary>
        /// 商品價錢
        /// </summary>
        public int Money { get; set; }
    }
}
