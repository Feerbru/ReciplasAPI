using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ReciApis.Domain.Models;

namespace ReciApis.Domain.IRepository
{
    public interface IArticuloRepository
    {
        Task AgregarProducto(Articulo articulo);

        List<Articulo> Obtener();

        string ObtenerArticuloId(int id);

        Task EditarProducto(Articulo articulo);

        Task EliminarProducto(int articuloId);

        List<Categoria> ListaCategoria();

        List<UnidadMedida> ListaUMedida();
    }
}
