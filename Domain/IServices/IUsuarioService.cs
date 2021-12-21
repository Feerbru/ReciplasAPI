using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ReciApis.Domain.Models;
using ReciApis.DTO;

namespace ReciApis.Domain.IServices
{
    public interface IUsuarioService
    {
        Task SaveUser(Usuario usuario);

        Task<bool> ValidateExistence(Usuario usuario);

        Task<Usuario> ValidatePassword(int idUsuario, string passwordAnterior);

        Task UpdatePassword(Usuario usuario);

        //Task<bool> ValidateExistence(UsuarioDTO usuario);

        //Task SaveUser(UsuarioDTO usuario);

        List<Usuario> ListadoUsuario();
    }
}
