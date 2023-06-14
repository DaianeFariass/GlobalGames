using GlobalGames.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Net.Http.Headers;

namespace GlobalGames.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        public DbSet<Newsletter> Newsletters { get; set; }

        public DbSet<Budget> Budgets { get; set; }

        public DataContext( DbContextOptions<DataContext> options) : base(options) 
        { 
        
        
        }

    }
}
