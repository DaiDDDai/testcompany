using System.ComponentModel.DataAnnotations;
using test4.Dto;

namespace test4.Models
{
    public class SoppingList
    {
        [Key]
        public int SoppingListId { get; set; }
        public string Items { get; set; }
        public int Amount { get; set; }
        public int Money { get; set; }
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
