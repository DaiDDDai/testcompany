using System.ComponentModel.DataAnnotations;

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

    }
}
