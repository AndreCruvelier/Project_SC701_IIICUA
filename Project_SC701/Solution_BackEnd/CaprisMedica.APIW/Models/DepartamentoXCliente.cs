using System;
using System.Collections.Generic;

#nullable disable

namespace CaprisMedica.APIW.Models
{
    public partial class DepartamentoXCliente
    {
        public int ClienteId { get; set; }
        public int DepartamentoId { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Departamento Departamento { get; set; }
    }
}
