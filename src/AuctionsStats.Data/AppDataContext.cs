using Microsoft.EntityFrameworkCore;

namespace AuctionsStats.Data
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options)
            :base(options)
        {

        }
        public DbSet<Coin> Coins { get; set; }
    }
}
