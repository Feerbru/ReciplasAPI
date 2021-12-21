using System;
using System.Threading.Tasks;
using ReciApis.Domain.IRepository;
using ReciApis.Domain.IServices;
using ReciApis.Domain.Models;

namespace ReciApis.Services
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _loginRepository;

        public LoginService(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }


        public async Task<Usuario> ValidateUser(Usuario usuario)
        {
            return await _loginRepository.ValidateUser(usuario);
        }
    }
}
