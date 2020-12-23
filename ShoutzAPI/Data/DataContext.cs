using Microsoft.EntityFrameworkCore;
using ShoutzAPI.Entities;

namespace ShoutzAPI.Data
{
    public class DataContext : DbContext
    {
        //fields
        public DbSet<AppUser> Users { get; set; }
        
        //constructor
        public DataContext(DbContextOptions options) : base(options)
        {
        }
    }
}