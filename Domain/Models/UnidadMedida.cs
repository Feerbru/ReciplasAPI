using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReciApis.Domain.Models
{
    public class UnidadMedida
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        //public ICollection<Articulo> Articulo { get; set; }
    }
}
