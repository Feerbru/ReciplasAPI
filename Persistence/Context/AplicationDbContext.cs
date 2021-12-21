using System;
using Microsoft.EntityFrameworkCore;
using ReciApis.Domain.Models;

namespace ReciApis.Persistence.Context
{
    public class AplicationDbContext : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<EstadoCuenta> EstadoCuenta { get; set; }
        public DbSet<Persona> Persona { get; set; }
        public DbSet<Proveedor> Proveedor { get; set; }
        public DbSet<Articulo> Articulo { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<DetallePedido> DetallePedido { get; set; }
        public DbSet<Factura> Factura  { get; set; }
        public DbSet<OrdenCompra> OrdenCompra { get; set; }
        public DbSet<OrdenCompraArticulo> OrdenCompraArticulo { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<UnidadMedida> UnidadMedida { get; set; }
        public DbSet<EstadoOc> EstadoOc { get; set; }
        public DbSet<EstadoPedido> EstadoPedido { get; set; }
        public DbSet<Sector> Sector { get; set; }
        

    public AplicationDbContext(DbContextOptions<AplicationDbContext> options ): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<OrdenCompraArticulo>()
                .HasKey(x => new { x.OrdenCompraId, x.ArticuloId });

            modelBuilder.Entity<DetallePedido>()
                .HasKey(x => new { x.CodigoPedidoId, x.ArticuloId });

            new Articulo.Mapeo(modelBuilder.Entity<Articulo>());
            new Persona.Mapeo(modelBuilder.Entity<Persona>());
            new OrdenCompra.Mapeo(modelBuilder.Entity<OrdenCompra>());
            new Usuario.Mapeo(modelBuilder.Entity<Usuario>());
            new Pedido.Mapeo(modelBuilder.Entity<Pedido>());
            new Factura.Mapeo(modelBuilder.Entity<Factura>());

            base.OnModelCreating(modelBuilder);

        }

        
    }

}
