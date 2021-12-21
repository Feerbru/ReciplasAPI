using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ReciApis.Domain.Models
{
    public class Categoria
    {
        
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        //public ICollection<Articulo> Articulo { get; set; }

    }
}
