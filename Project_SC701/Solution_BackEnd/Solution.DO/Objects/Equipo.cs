using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Solution.DO.Objects
{
    public  class Equipos
    {
        //public Equipo()
        //{
        //    EquipoXDepartamentos = new HashSet<EquipoXDepartamento>();
        //    Solicitudes = new HashSet<Solicitude>();
        //}
        [Key]
        public int EquipoId { get; set; }
        public string EquipoNombre { get; set; }
        public string EquipoEstado { get; set; }

        //public virtual ICollection<EquipoXDepartamento> EquipoXDepartamentos { get; set; }
        //public virtual ICollection<Solicitude> Solicitudes { get; set; }
    }
}
