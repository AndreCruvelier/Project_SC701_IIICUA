using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Solution.DO.Objects
{
    public  class TipoCedula
    {
        //public TipoCedula()
        //{
        //    Empleados = new HashSet<Empleado>();
        //}
        [Key]
        public int TipoId { get; set; }
        public string TipoDescripcion { get; set; }

        //public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
