using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReciApis.Domain.IServices;
using ReciApis.Domain.Models;

namespace ReciApis.Controllers
{
    [Route("api/[controller]")]
    public class PedidoController : Controller
    {

        private readonly IPedidoService _pedidoService;

        public PedidoController(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var pedido = await _pedidoService.ObtenerPedido();
                return Ok(pedido);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Pedido pedido)
        {
            try
            {
                await _pedidoService.AgregarPedido(pedido);
                return Ok(new { message = "Pedido agregado con exito!!!" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("ListadoClientes")]
        public List<Cliente> GetClientes()
        {
            return _pedidoService.ListaCliente();
        }

        [HttpGet]
        [Route("ListadoEstado")]
        public List<EstadoPedido> GetEstadoPedidos()
        {
            return _pedidoService.ListaEstadoPedido();
        }

        [HttpDelete]
        [Route("{Id}")]
        public async Task<IActionResult> Delete(int Id)
        {

            try
            {
                await _pedidoService.EliminarPedido(Id);

                return Ok(new { message = "Producto eliminado con exito!!!" });
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
