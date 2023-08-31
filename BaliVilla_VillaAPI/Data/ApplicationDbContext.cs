using BaliVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BaliVilla_VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Villa> Villas { get; set; }
    }
}
