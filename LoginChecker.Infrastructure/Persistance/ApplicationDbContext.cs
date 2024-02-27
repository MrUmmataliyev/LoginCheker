using LoginChecker.Domain.Models.EmailCheck;
using LoginChecker.Domain.Models.User;
using Microsoft.EntityFrameworkCore;

namespace LoginChecker.Infrastructure.Persistance
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
             : base(options)
        {
            Database.Migrate();
        }
        public virtual DbSet<EmailCheck> EmailChecks { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
