using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReciApis.Domain.Models
{
    public class Cliente : Persona
    {
        [Required]
        [Column(TypeName = "varchar(8)")]
        public string DNI { get; set; }

        public ICollection<Pedido> Pedido { get; set; }
    }
}
