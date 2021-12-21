using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ReciApis.Domain.IRepository;
using ReciApis.Domain.IServices;
using ReciApis.Domain.Models;
using ReciApis.DTO;

namespace ReciApis.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public List<Usuario> ListadoUsuario()
        {
            return _usuarioRepository.ListadoUsuario();
        }

        public async Task SaveUser(Usuario usuario)
        {
            await _usuarioRepository.SaveUser(usuario);
        }

        /*public Task SaveUser(UsuarioDTO usuario)
        {
            throw new NotImplementedException();
        }*/

        public async Task UpdatePassword(Usuario usuario)
        {
            await _usuarioRepository.UpdatePassword(usuario);
        }

        /*public async Task<bool> ValidateExistence(UsuarioDTO usuario)
        {
            return await _usuarioRepository.ValidateExistence(usuario);
        }*/

        public async Task<bool> ValidateExistence(Usuario usuario)
        {
            return await _usuarioRepository.ValidateExistence(usuario);
        }

        public async Task<Usuario> ValidatePassword(int idUsuario, string passwordAnterior)
        {
            return await _usuarioRepository.ValidatePassword(idUsuario, passwordAnterior);
        }

    }
}
