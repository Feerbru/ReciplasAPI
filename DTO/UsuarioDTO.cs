using System;
namespace ReciApis.DTO
{
    public class UsuarioDTO
    {
        public string NombreUsuario { get; set; }

        public string Password { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Email { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public DateTime FechaRegistro { get; set; }


    }
}
