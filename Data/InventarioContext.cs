using Microsoft.EntityFrameworkCore;
using InventarioApp.Models;

namespace InventarioApp.Data
{
    public class InventarioContext : DbContext
    {
        public InventarioContext(DbContextOptions<InventarioContext> options) : base(options) { }

        public DbSet<Producto> Productos { get; set; }
    }
}

