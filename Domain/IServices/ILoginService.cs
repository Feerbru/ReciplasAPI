using System;
using System.Threading.Tasks;
using ReciApis.Domain.Models;

namespace ReciApis.Domain.IServices
{
    public interface ILoginService
    {
        Task<Usuario> ValidateUser(Usuario usuario);
    }
}
