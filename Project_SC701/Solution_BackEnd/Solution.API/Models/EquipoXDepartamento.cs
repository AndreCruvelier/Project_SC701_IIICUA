using System;
using System.Collections.Generic;

#nullable disable

namespace Solution.API.Models
{
    public partial class EquipoXDepartamento
    {
        public int DepartamentoId { get; set; }
        public int EquipoId { get; set; }
        public int? CantEquipos { get; set; }

        public virtual Departamento Departamento { get; set; }
        public virtual Equipo Equipo { get; set; }
    }
}
