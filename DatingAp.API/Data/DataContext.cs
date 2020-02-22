using DatingAp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingAp.API.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Value> Values { get; set; }
        
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
    }
}