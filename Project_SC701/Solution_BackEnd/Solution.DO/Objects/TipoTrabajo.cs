using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Solution.DO.Objects
{
    public  class TipoTrabajo
    {
        //public TipoTrabajo()
        //{
        //    Solicitudes = new HashSet<Solicitude>();
        //}
        [Key]
        public int TipoTrabajoId { get; set; }
        public string TipoTrabajoNombre { get; set; }
        public string TipoTrabajoEstado { get; set; }

      //  public virtual ICollection<Solicitude> Solicitudes { get; set; }
    }
}
