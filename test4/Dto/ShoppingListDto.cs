using System.ComponentModel.DataAnnotations;

namespace test4.Dto
{
    public class ShoppingListDto
    {
        /// <summary>
        /// 
        /// </summary>
        public List<Itemlist> list { get; set; }
        /// <summary>
        /// 種類數
        /// </summary>
        public int TotalItems { get; set; }
        /// <summary>
        /// 總金額
        /// </summary>
        public int TotalMoney { get; set; }
        /// <summary>
        /// 總數量
        /// </summary>
        public int TotalAmount { get; set; }

        public class Itemlist
        {
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

            public int Total { get; set; }
        }
    }
}
