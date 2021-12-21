using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReciApis.Domain.Models
{
    public class EstadoCuenta
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

    }
}
