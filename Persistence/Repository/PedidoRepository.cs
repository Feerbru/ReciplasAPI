using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReciApis.Domain.IRepository;
using ReciApis.Domain.Models;
using ReciApis.Persistence.Context;

namespace ReciApis.Persistence.Repository
{
    public class PedidoRepository : IPedidoRepository
    {
        public readonly AplicationDbContext _context; 

        public PedidoRepository(AplicationDbContext aplicationDbContext)
        {
            _context = aplicationDbContext;
        }


        public async Task AgregarPedido(Pedido pedido)
        {
            try
            {
                _context.Add(pedido);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task EliminarPedido(int pedidoId)
        {
            try
            {
                var pedidoDb = await _context.Pedido.Where(busqueda => busqueda.Id == pedidoId).FirstOrDefaultAsync();
                _context.Pedido.Remove(pedidoDb);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Cliente> ListaCliente()
        {
            try
            {
                var clientes = _context.Cliente.ToList();
                return clientes;
            }
            catch (Exception ex)
            {
                return new List<Cliente>();
            }
        }

        public List<EstadoPedido> ListaEstadoPedido()
        {
            try
            {
                var estado = _context.EstadoPedido.ToList();
                return estado;
            }
            catch (Exception ex)
            {
                return new List<EstadoPedido>();
            }
        }


        public async Task<List<Pedido>> ObtenerPedido()
        {
            try
            {

                var pedido = await _context.Pedido
                             .Include(x => x.Usuario)
                             .Include(x => x.EstadoPedido)
                             .Include(x => x.Cliente)
                             .Select(sel => new Pedido()
                             {
                                 Id = sel.Id,
                                 FechaEntrega = sel.FechaEntrega,
                                 Usuario = new Usuario()
                                 {
                                     Id = sel.Usuario.Id,
                                     Nombre = sel.Usuario.Nombre,
                                 },
                                 EstadoPedido = new EstadoPedido()
                                 {
                                     Nombre = sel.EstadoPedido.Nombre,
                                 },
                                 Cliente = new Cliente()
                                 {
                                     Id = sel.Cliente.Id,
                                     Nombre = sel.Cliente.Nombre,
                                 }
                             }).ToListAsync();

                return pedido;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
