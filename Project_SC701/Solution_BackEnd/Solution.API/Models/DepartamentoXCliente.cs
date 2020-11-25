using System;
using System.Collections.Generic;

#nullable disable

namespace Solution.API.Models
{
    public partial class DepartamentoXCliente
    {
        public int DepartamentoId { get; set; }
        public int ClienteId { get; set; }
        public int? CantDepartamentos { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Departamento Departamento { get; set; }
    }
}
