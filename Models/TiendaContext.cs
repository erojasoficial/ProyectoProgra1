using Microsoft.EntityFrameworkCore;

namespace CRUD.Models
{
    public class TiendaContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<SistemaPago> SistemaPagos { get; set; }
        public DbSet<Recibo> Recibos { get; set; }

        public TiendaContext(DbContextOptions<TiendaContext> options) : base(options) { }

    }
}