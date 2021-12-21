using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReciApis.Domain.Models
{
    public class OrdenCompraArticulo
    {
        public int OrdenCompraId { get; set; }

        public int ArticuloId { get; set; }

        public OrdenCompra OrdenCompra { get; set; }

        public Articulo Articulo { get; set; }

        public int Cantidad { get; set; }

        public double Precio { get; set; }

        [NotMapped]
        public double Subtotal { get; set; }
    }
}
