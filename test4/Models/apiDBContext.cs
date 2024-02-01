using System.Data.Entity;

namespace test4.Models
{
    public class apiDBContext : DbContext
    {
        public apiDBContext() : base("test4Database")
        {
        }
        public DbSet<Company> Company { get; set; }
        public DbSet<Member> Member { get; set; }

        public DbSet<SoppingList> SoppingList { get; set; }
    }
}
