using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ReciApis.Domain.Models
{
    public class OrdenCompra
    {
        public int Id { get; set; }

        public double Total { get; set; }

        public DateTime Fecha { get; set; }

        public string DireccionEntrega { get; set; }

        public DateTime FechaEntrega { get; set; }

        public int UsuarioId { get; set; }

        public Usuario Usuario { get; set; }

        public int ProveedorId { get; set; }

        public Proveedor Proveedor { get; set; }

        public int EstadoOcId { get; set; }

        public EstadoOc EstadoOc { get; set; }

        public DateTime FechaRegistro { get; set; }

        public ICollection<OrdenCompraArticulo> OrdedeCompraArticulo { get; set; }

        public class Mapeo
        {
            public Mapeo(EntityTypeBuilder<OrdenCompra> mapeoOrdenCompra)
            {
                mapeoOrdenCompra.HasOne(x => x.EstadoOc);
                mapeoOrdenCompra.HasOne(x => x.Proveedor);
                mapeoOrdenCompra.HasOne(x => x.Usuario);
            }
        }

    }
}
    