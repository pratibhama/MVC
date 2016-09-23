using System.Data.Entity;

namespace CodeFirstDemo
{
    class DAL : DbContext
    {
        public DAL()
            : base("TestDbContext")
        {

        }

        public DbSet<Customer> Customers { get; set; }
    }
}
