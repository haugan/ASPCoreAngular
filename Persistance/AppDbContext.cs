using Microsoft.EntityFrameworkCore;

namespace ASPCoreAngular.Persistance
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}