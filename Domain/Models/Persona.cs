using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ReciApis.Domain.Models
{
    public abstract class Persona
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Apellido { get; set; }

        [Required]
        public string Direccion { get; set; }

        [Required]
        [Column(TypeName = "varchar(30)")]
        public string Email { get; set; }

        [Required]
        [Column(TypeName = "varchar(10)")]
        public string Celular { get; set; }

        public DateTime FechaRegistro { get; set; }

        public int EstadoCuentaId { get; set; }

        public EstadoCuenta EstadoCuenta { get; set; }

        public class Mapeo
        {
            public Mapeo(EntityTypeBuilder<Persona> mapPersona)
            {
                mapPersona.HasKey(x => x.Id);
                mapPersona.HasOne(x => x.EstadoCuenta);
            }
        }

    }
}