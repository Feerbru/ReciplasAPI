using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ReciApis.Domain.Models;

namespace ReciApis.Domain.IRepository
{
    public interface IPedidoRepository
    {
        Task AgregarPedido(Pedido pedido);

        Task<List<Pedido>> ObtenerPedido();

        List<Cliente> ListaCliente();

        List<EstadoPedido> ListaEstadoPedido();

        Task EliminarPedido(int pedidoId);
    }
}
