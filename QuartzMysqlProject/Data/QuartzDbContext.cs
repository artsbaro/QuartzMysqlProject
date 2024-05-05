using Microsoft.EntityFrameworkCore;
using QuartzMysqlProject.Api.Model;

namespace QuartzMysqlProject.Api.Data
{
    public class QuartzDbContext : DbContext
    {
        public QuartzDbContext(DbContextOptions<QuartzDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
