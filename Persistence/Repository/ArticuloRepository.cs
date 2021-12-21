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
    public class ArticuloRepository : IArticuloRepository
    {
        private readonly AplicationDbContext _context;

        public ArticuloRepository(AplicationDbContext context)
        {
            _context = context;
        }

        public List<Articulo> Obtener()
        {

            //var resultado = await _context.Articulo.ToListAsync();

            var resultado = _context.Articulo
                            .Include(x => x.Categoria)
                            .Include(x => x.UnidadMedida)
                            .Include(x => x.Sector)
                            .Select(x => new Articulo()
                            {
                                Id = x.Id,
                                Nombre = x.Nombre,
                                Descripcion = x.Descripcion,
                                Stock = x.Stock,
                                StockMinimo = x.StockMinimo,
                                PrecioUnitario = x.PrecioUnitario,
                                PrecioVenta = x.PrecioVenta,
                                Tipo = x.Tipo,
                                CategoriaId = x.CategoriaId,
                                UnidadMedidaId = x.UnidadMedidaId,
                                SectorId= x.SectorId,
                                Categoria = new Categoria()
                                {
                                    Id = x.Categoria.Id,
                                    Nombre = x.Categoria.Nombre,
                                    Descripcion = x.Categoria.Descripcion
                                },
                                UnidadMedida = new UnidadMedida()
                                {
                                    Id = x.UnidadMedida.Id,
                                    Nombre = x.UnidadMedida.Nombre
                                },
                                Sector = new Sector()
                                {
                                    Id= x.Sector.Id,
                                    Nombre = x.Sector.Nombre
                                }
                            }).ToList();

            return resultado;
        }

        public async Task AgregarProducto(Articulo articulo)
        {
            try
            {
                 _context.Add(articulo);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task EditarProducto(Articulo articulo)
        {
            try
            {
                var articuloDb = await _context.Articulo.Where(busqueda => busqueda.Id == articulo.Id).FirstOrDefaultAsync();
                articuloDb.Nombre = articulo.Nombre;
                articuloDb.Descripcion = articulo.Descripcion;
                articuloDb.PrecioUnitario = articulo.PrecioUnitario;
                articuloDb.PrecioVenta = articulo.PrecioVenta;
                articuloDb.Stock = articulo.Stock;
                articuloDb.StockMinimo = articulo.StockMinimo;
                articuloDb.Tipo = articulo.Tipo;

                _context.SaveChanges();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task EliminarProducto(int articuloId)
        {
            try
            {
                var articuloDb = await _context.Articulo.Where(busqueda => busqueda.Id == articuloId).FirstOrDefaultAsync();
                _context.Articulo.Remove(articuloDb);
                _context.SaveChanges();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Categoria> ListaCategoria()
        {
            try
            {
                var categoria = _context.Categoria.ToList();

                return categoria;
            }
            catch (Exception ex)
            {
                return  new List<Categoria>();
            }
        }

        public List<UnidadMedida> ListaUMedida()
        {
            try
            {
                var unidadM = _context.UnidadMedida.ToList();

                return unidadM;
            }
            catch (Exception ex)
            {
                return new List<UnidadMedida>();
            }
        }

    }
}
