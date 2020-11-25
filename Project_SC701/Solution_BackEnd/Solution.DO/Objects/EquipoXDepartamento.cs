using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Solution.DO.Objects
{
    public  class Equipo_X_Departamento
    {
        [Key]
        public int DepartamentoId { get; set; }
        public int EquipoId { get; set; }
        public int? Cant_Equipos { get; set; }

        //public virtual Departamento Departamento { get; set; }
        //public virtual Equipo Equipo { get; set; }
    }
}
