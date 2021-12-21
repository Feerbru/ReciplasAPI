using System;
using System.Threading.Tasks;
using ReciApis.Domain.Models;
using ReciApis.DTO;

namespace ReciApis.Domain.IRepository
{
    public interface ILoginRepository
    {
        //Task<Usuario> ValidateUser(UsuarioDTO usuario);

        Task<Usuario> ValidateUser(Usuario usuario);
    }
}
