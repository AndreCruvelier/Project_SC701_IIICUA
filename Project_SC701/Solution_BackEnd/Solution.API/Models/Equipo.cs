using System;
using System.Collections.Generic;

#nullable disable

namespace Solution.API.Models
{
    public partial class Equipo
    {
        public Equipo()
        {
            EquipoXDepartamentos = new HashSet<EquipoXDepartamento>();
            Solicitudes = new HashSet<Solicitude>();
        }

        public int EquipoId { get; set; }
        public string EquipoNombre { get; set; }
        public string EquipoEstado { get; set; }

        public virtual ICollection<EquipoXDepartamento> EquipoXDepartamentos { get; set; }
        public virtual ICollection<Solicitude> Solicitudes { get; set; }
    }
}
