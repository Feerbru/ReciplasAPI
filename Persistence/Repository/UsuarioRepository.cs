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
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly AplicationDbContext _context;

        public UsuarioRepository(AplicationDbContext context)
        {
            _context = context;
        }

        public List<Usuario> ListadoUsuario()
        {
            try
            {
                var usuario = _context.Usuario.Where(x => x.Rol.Nombre == "vendedor").ToList();

                return usuario;
            }
            catch (Exception ex)
            {
                return new List<Usuario>();
            }
        }

        public async Task SaveUser(Usuario usuario)
        {
            try
            {
                _context.Add(usuario);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        /*public async Task SaveUser(UsuarioDTO usuario)
        {
            try
            {
                _context.Add(usuario);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }*/

        public async Task UpdatePassword(Usuario usuario)
        {
            _context.Update(usuario);
            await _context.SaveChangesAsync();
        }

        //validar que no existan 2 nombre de usuario repetidos
        public async Task<bool> ValidateExistence(Usuario usuario)
        {
            var validateExistence = await _context.Usuario.AnyAsync(x => x.NombreUsuario == usuario.NombreUsuario);

            return validateExistence;

        }

        /*public async Task<bool> ValidateExistence(UsuarioDTO usuario)
        {
            var validateExistence = await _context.Usuario.AnyAsync(x => x.NombreUsuario == usuario.NombreUsuario);

            return validateExistence;
        }*/

        public async Task<Usuario> ValidatePassword(int idUsuario, string passwordAnterior)
        {
            var usuario = await _context.Usuario.Where(x => x.Id == idUsuario && x.Password == passwordAnterior).FirstOrDefaultAsync();
            return usuario;
        }
    }
}
