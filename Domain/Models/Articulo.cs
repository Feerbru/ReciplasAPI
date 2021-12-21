using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ReciApis.Domain.Models
{
    public class Articulo
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public int Stock { get; set; }

        public int StockMinimo { get; set; }

        public double PrecioUnitario { get; set; }

        public double PrecioVenta { get; set; }

        public DateTime FechaIngreso { get; set; }

        public string Tipo { get; set; }

        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }

        public int UnidadMedidaId { get; set; }

        public UnidadMedida UnidadMedida { get; set; }

        public int SectorId { get; set; }

        public Sector Sector { get; set; }

        //public ICollection<DetallePedido> DetallePedido { get; set; }

        //public ICollection<OrdenCompraArticulo> OrdenCompraArticulos { get; set; }

        public class Mapeo
        {
            public Mapeo(EntityTypeBuilder<Articulo> mapeoArticulo)
            {
                mapeoArticulo.HasKey(x => x.Id);
                mapeoArticulo.HasOne(x => x.Categoria);
                mapeoArticulo.HasOne(x => x.UnidadMedida);
                mapeoArticulo.HasOne(x => x.Sector);
            }
        }
    }
}
