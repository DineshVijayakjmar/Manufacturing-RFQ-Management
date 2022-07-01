using Microsoft.EntityFrameworkCore;

namespace SupplierMicroservice
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Supplier_Part> Supplier_Parts { get; set; }
    }
}
