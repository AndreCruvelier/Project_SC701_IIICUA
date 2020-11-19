using System;
using System.Collections.Generic;

namespace CaprisMedica.DO.Objects
{
    public class TipoTrabajo
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
