using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ASM21670.Models;

namespace ASM21670.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ASM21670.Models.Book> Book { get; set; }
        public DbSet<ASM21670.Models.Category> Category { get; set; }
        public DbSet<ASM21670.Models.Orders> Orders { get; set; }
    }
}