using Microsoft.EntityFrameworkCore;
using RFQ_mgmt.Model;


namespace RFQ_mgmt.DBContext
{
    public class Dbcontext : DbContext
    {
        public Dbcontext(DbContextOptions<Dbcontext> options) : base(options)
        {
        }
        public DbSet<Rfq> RFQ { get; set; }
        public DbSet<Supplier> SUPPLIER { get; set; }



    }
}
