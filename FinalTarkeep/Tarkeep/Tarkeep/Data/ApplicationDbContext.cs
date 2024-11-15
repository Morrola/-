using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Tarkeep.Models;

namespace Tarkeep.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Service> Services { get; set; } 
        public DbSet<Testimonials> Testimonials { get; set; } 
        public DbSet<User> user { get; set; }
    }
}
