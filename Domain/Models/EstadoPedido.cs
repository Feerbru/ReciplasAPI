using System;
using System.Collections.Generic;

namespace ReciApis.Domain.Models
{
    public class EstadoPedido
    {

        public int Id { get; set; }

        public string Nombre { get; set; }

        public ICollection<Pedido> Pedido { get; set; }
    }
}
