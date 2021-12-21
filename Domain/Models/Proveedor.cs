using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReciApis.Domain.Models
{
    public class Proveedor : Persona
    {
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string CUIT { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string RazonSocial { get; set; }

        public ICollection<OrdenCompra> OrdenCompra { get; set; }
    }
}
