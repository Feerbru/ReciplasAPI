using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ReciApis.Domain.Models
{
    public class Pedido
    {
        
        public int Id { get; set; }

        public string NombreCliente { get; set; }

        public string Descripcion { get; set; }

        public DateTime Fecha { get; set; }

        public DateTime FechaEntrega { get; set; }

        public int UsuarioId { get; set; }

        public Usuario Usuario { get; set; }

        public int EstadoPedidoId { get; set; }

        public EstadoPedido EstadoPedido { get; set; }

        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; }

        public Factura Factura { get; set; }

        public ICollection<DetallePedido> DetalleFactura { get; set; }

        public class Mapeo
        {
            public Mapeo(EntityTypeBuilder<Pedido> mapeoPedido)
            {
                mapeoPedido.HasOne(x => x.Cliente);
                mapeoPedido.HasOne(x => x.Usuario);
                mapeoPedido.HasOne(x => x.EstadoPedido);
                mapeoPedido.HasOne(x => x.Factura);
            }
        }
    }
}
