using System;
using System.Collections.Generic;

namespace CaprisMedica.UI.Models
{
    public partial class TipoCedula
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
