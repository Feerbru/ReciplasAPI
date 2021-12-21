using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ReciApis.Domain.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string NombreUsuario { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Password { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Apellido { get; set; }
        
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Email { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public DateTime FechaRegistro { get; set; }

        [ForeignKey("AdministraUsuarioId")]
        public Usuario UsuarioAdministra { get; set; }

        public string NombreAdmin { get; set; }

        public DateTime FechaModificacion { get; set; }

        public ICollection<OrdenCompra> Ordenes { get; set; }

        public ICollection<Pedido> Pedido { get; set; }

        public int RolId { get; set; }

        public Rol Rol { get; set; }

        public class Mapeo
        {
            public Mapeo(EntityTypeBuilder<Usuario> mapeoUsuario)
            {
                mapeoUsuario.HasOne(x => x.Rol);
            }
        }

    }
}
