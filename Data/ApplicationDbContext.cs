using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmartWebAPI.Model;

namespace SmartWebAPI.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Incident> Incidents { get; set; }
        public DbSet<IncidentLog> IncidentLogs { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();
            modelBuilder.Entity<Message>().HasIndex(m => m.RecipientId);
            modelBuilder.Entity<Incident>().HasIndex(i => i.ReporterId);
        }
    }

}
