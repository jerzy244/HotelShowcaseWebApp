using Microsoft.EntityFrameworkCore;
using HotelShowcaseWebApp.Models;

namespace HotelShowcaseWebApp.Data {
    public class ApplicationDbContext : DbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
        
        }

        public DbSet<Hotele> Hotele { get; set; }
    }
}
