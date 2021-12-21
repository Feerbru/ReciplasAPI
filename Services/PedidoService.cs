using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ReciApis.Domain.IRepository;
using ReciApis.Domain.IServices;
using ReciApis.Domain.Models;

namespace ReciApis.Services
{
    public class PedidoService : IPedidoService
    {
        private readonly IPedidoRepository _pedidoRepository;

        public PedidoService(IPedidoRepository pedidoRepository)
        {

            _pedidoRepository = pedidoRepository;
        }

        public async Task AgregarPedido(Pedido pedido)
        {
            await _pedidoRepository.AgregarPedido(pedido);
        }

        public async Task EliminarPedido(int pedidoId)
        {
            await _pedidoRepository.EliminarPedido(pedidoId);
        }

        public List<Cliente> ListaCliente()
        {
            return _pedidoRepository.ListaCliente();
        }

        public List<EstadoPedido> ListaEstadoPedido()
        {
            return _pedidoRepository.ListaEstadoPedido();
        }


        public async Task<List<Pedido>> ObtenerPedido()
        {
            return await _pedidoRepository.ObtenerPedido();
        }
    }
}
