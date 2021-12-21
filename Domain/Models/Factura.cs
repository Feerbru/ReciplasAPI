using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ReciApis.Domain.Models
{
    public class Factura
    {
        
        public int Id { get; set; }

        public string NombreEmpresa { get; set; }

        public DateTime Fecha { get; set; }

        public double Iva { get; set; }

        public double Total { get; set; }

        public bool EsPagada { get; set; }

        public int PedidoId { get; set; }

        public Pedido Pedido { get; set; }

        public class Mapeo
        {
            public Mapeo(EntityTypeBuilder<Factura> mapeoFactura)
            {
                mapeoFactura.HasOne(x => x.Pedido);
            }
        }
    }
}
