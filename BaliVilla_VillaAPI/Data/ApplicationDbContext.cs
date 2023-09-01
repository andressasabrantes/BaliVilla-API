using BaliVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BaliVilla_VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Villa> Villas { get; set; }
    }
}
