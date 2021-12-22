using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReciApis.Domain.IServices;
using ReciApis.Domain.Models;

namespace ReciApis.Controllers
{
    [Route("api/[controller]")]
    public class ArticuloController : Controller
    {
        private readonly IArticuloService _articuloService;

        public ArticuloController(IArticuloService service)
        {
            _articuloService = service;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Articulo articulo)
        {
            try
            {
                await _articuloService.AgregarProducto(articulo);

                return Ok(new { message = "Producto agregado con exito!!" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public List<Articulo> Get()
        {
            var resultado = _articuloService.Obtener();

            return resultado;
        }

        [HttpGet]
        [Route("{id}")]
        public string GetId( int id)
        {
            var articuloId = _articuloService.ObtenerArticuloId(id);
            return articuloId;
        }


        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Articulo articulo)
        {
            try
            {
                await _articuloService.EditarProducto(articulo);

                return Ok(new { message = "Producto actualizado con exito!!" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("{Id}")]
        public async Task<IActionResult> Delete(int Id)
        {

            try
            {
                await _articuloService.EliminarProducto(Id);

                return Ok(new { message = "Producto eliminado con exito!!!" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("ListadoCategoria")]
        public List<Categoria> Listado()
        {
            return _articuloService.ListaCategoria();
        }

        [HttpGet]
        [Route("ListadoUnidadM")]
        public List<UnidadMedida> ListadoUnidad()
        {
            return  _articuloService.ListaUMedida();
        }
    }
}
