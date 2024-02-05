using System.ComponentModel.DataAnnotations;
using test4.Dto;

namespace test4.Models
{
    public class SoppingList
    {
        /// <summary>
        /// 購物清單ID
        /// </summary>
        [Key]
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
        /// <summary>
        /// 清單所屬會員
        /// </summary>
        public int MemberID { get; set; }

        public void Edit(UpdateShoppingList updatemodel)
        {
            Items = updatemodel.Items;
            Amount = updatemodel.Amount;
            Money = updatemodel.Money;
            MemberID = updatemodel.MemberID;
        }
    }
}
