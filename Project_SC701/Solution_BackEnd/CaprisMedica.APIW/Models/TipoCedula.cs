using System;
using System.Collections.Generic;

#nullable disable

namespace CaprisMedica.APIW.Models
{
    public partial class TipoCedula
    {
        public TipoCedula()
        {
            Empleados = new HashSet<Empleado>();
        }

        public int TipoId { get; set; }
        public string TipoDescripcion { get; set; }

        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
