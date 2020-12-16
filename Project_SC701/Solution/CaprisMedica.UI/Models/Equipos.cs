using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CaprisMedica.UI.Models
{
    public partial class Equipos
    {
        //public Equipos()
        // {
        //    EquipoXDepartamento = new HashSet<EquipoXDepartamento>();
        //    Solicitudes = new HashSet<Solicitudes>();
        // }
        public int EquipoId { get; set; }
        public string EquipoNombre { get; set; }
        public string EquipoEstado { get; set; }

        //public virtual ICollection<EquipoXDepartamento> EquipoXDepartamento { get; set; }
        //public virtual ICollection<Solicitudes> Solicitudes { get; set; }
    }
}
