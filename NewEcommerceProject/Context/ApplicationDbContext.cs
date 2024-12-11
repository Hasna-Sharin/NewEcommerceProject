using Microsoft.EntityFrameworkCore;
using NewEcommerceProject.Models;

namespace NewEcommerceProject.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) 
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
