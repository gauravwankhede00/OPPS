using Microsoft.EntityFrameworkCore;
using WebAPI.Model;

namespace WebAPI
{
    public class StockDBContext : DbContext
    {
        public StockDBContext(DbContextOptions<StockDBContext> options) : base(options) { }

        public DbSet<WebAPI.Model.Product> Product { get; set; }
        public DbSet<Sale> Sale { get; set; }
        public DbSet<Stock> Stock { get; set; }
        public DbSet<StockPurchase> StockPurchase { get; set; }

    }
}
