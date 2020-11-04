using System;
using System.Collections.Generic;

namespace CaprisMedica.UI.Models
{
    public partial class TipoTrabajo
    {
        public TipoTrabajo()
        {
            Solicitudes = new HashSet<Solicitudes>();
        }

        public int TipoTrabajoId { get; set; }
        public string TipoTrabajoNombre { get; set; }

        public virtual ICollection<Solicitudes> Solicitudes { get; set; }
    }
}
