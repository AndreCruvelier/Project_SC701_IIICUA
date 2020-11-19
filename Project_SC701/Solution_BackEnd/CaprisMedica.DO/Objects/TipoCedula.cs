using System;
using System.Collections.Generic;

namespace CaprisMedica.DO.Objects
{
    public class TipoCedula
    {
        public TipoCedula()
        {
            Empleados = new HashSet<Empleados>();
        }

        public int TipoId { get; set; }
        public string TipoDescripcion { get; set; }

        public virtual ICollection<Empleados> Empleados { get; set; }
    }
}
