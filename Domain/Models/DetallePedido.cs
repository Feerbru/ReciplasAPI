using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReciApis.Domain.Models
{
    public class DetallePedido
    {
        public int ArticuloId { get; set; }

        public int CodigoPedidoId{ get; set; }

        public Articulo Articulo { get; set; }

        public Pedido Pedido { get; set; }

        public int Cantidad { get; set; }

        public double Precio { get; set; }

        [NotMapped]
        public double Subtotal { get; set; }
    }
}
