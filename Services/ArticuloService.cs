using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ReciApis.Domain.IRepository;
using ReciApis.Domain.IServices;
using ReciApis.Domain.Models;

namespace ReciApis.Services
{
    public class ArticuloService : IArticuloService
    {
        private readonly IArticuloRepository _articuloRepository;

        public ArticuloService(IArticuloRepository articuloRepository)
        {
            _articuloRepository = articuloRepository;
        }

        public List<Articulo> Obtener()
        {
            return _articuloRepository.Obtener();
        }

        public async Task AgregarProducto(Articulo articulo)
        {
             await _articuloRepository.AgregarProducto(articulo);
        }

        public async Task EditarProducto(Articulo articulo)
        {
            await _articuloRepository.EditarProducto(articulo);
        }

        public async Task EliminarProducto(int articuloId)
        {
            await _articuloRepository.EliminarProducto(articuloId);
        }

        public List<Categoria> ListaCategoria()
        {
            return _articuloRepository.ListaCategoria();
        }

        public List<UnidadMedida> ListaUMedida()
        {
            return _articuloRepository.ListaUMedida();
        }
    }
}
