using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ReciApis.Domain.Models;
using ReciApis.DTO;

namespace ReciApis.Domain.IRepository
{
    public interface IUsuarioRepository
    {
        Task SaveUser(Usuario usuario);

        //Task SaveUser(UsuarioDTO usuario);

        //Task<bool> ValidateExistence(UsuarioDTO usuario);

        Task<Usuario> ValidatePassword(int idUsuario, string passwordAnterior);

        Task UpdatePassword(Usuario usuario);

        Task<bool> ValidateExistence(Usuario usuario);

        List<Usuario> ListadoUsuario();
    }
}
