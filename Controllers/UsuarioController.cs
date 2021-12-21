using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReciApis.Domain.IServices;
using ReciApis.Domain.Models;
using ReciApis.DTO;
using ReciApis.Utils;
using System.Collections.Generic;

namespace ReciApis.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {

        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
             _usuarioService = usuarioService;
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Usuario usuario)
        {
            try
            {
                var validateExistence = await _usuarioService.ValidateExistence(usuario);

                if (validateExistence)
                {
                    return BadRequest(new { message = "El usuario " + usuario.NombreUsuario + " ya existe." });
                }

                //encryptamos el password
                usuario.Password = Encriptar.EncriptarPassword(usuario.Password);

                await _usuarioService.SaveUser(usuario);

                return Ok(new { message = "Usuario registrado con exito!!!" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("cambiar-password")]
        [HttpPut]
        public async Task<IActionResult> CambiarPassword([FromBody] CambiarPasswordDTO cambiarPassword)
        {
            try
            {
                int idUsuario = 3;
                string passwordEncriptado = Encriptar.EncriptarPassword(cambiarPassword.ContraseñaAnterior);
                var usuario = await _usuarioService.ValidatePassword(idUsuario, passwordEncriptado);

                if (usuario == null)
                {
                    return BadRequest(new { message = "La password incorrecta" });
                }

                usuario.Password = Encriptar.EncriptarPassword(cambiarPassword.NuevaContraseña);
                await _usuarioService.UpdatePassword(usuario);
                return Ok(new { message = "La contraseña fue actualizada con exito" });

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("ListadoUsuario")]
        public List<Usuario> Listado()
        {
            return _usuarioService.ListadoUsuario();
        }

    }
}
