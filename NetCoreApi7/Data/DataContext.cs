using Microsoft.EntityFrameworkCore;
using NetCoreApi7.Models;

namespace NetCoreApi7.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> context): base(context)
        {
        }
        
        public DbSet<Product> Products { get; set; }
    }
}