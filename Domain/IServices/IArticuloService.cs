using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ReciApis.Domain.Models;

namespace ReciApis.Domain.IServices
{
    public interface IArticuloService
    {
        Task AgregarProducto(Articulo articulo);

        List<Articulo> Obtener();

        Task EditarProducto(Articulo articulo);

        Task EliminarProducto(int articuloId);

        List<Categoria> ListaCategoria();

        List<UnidadMedida> ListaUMedida();
    }
}
