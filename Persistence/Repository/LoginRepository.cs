using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReciApis.Domain.IRepository;
using ReciApis.Domain.Models;
using ReciApis.DTO;
using ReciApis.Persistence.Context;

namespace ReciApis.Persistence.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private readonly AplicationDbContext _dbContext;

        public LoginRepository(AplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<Usuario> ValidateUser(Usuario usuario)
        {
            var user = await _dbContext.Usuario.Where(x => x.NombreUsuario == usuario.NombreUsuario && x.Password == usuario.Password).FirstOrDefaultAsync();
            return user;
        }
    }
}
