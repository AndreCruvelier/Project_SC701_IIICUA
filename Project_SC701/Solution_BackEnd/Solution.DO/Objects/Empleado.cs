using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Solution.DO.Objects
{
    public  class Empleados
    {
        //public Empleado()
        //{
        //    Solicitudes = new HashSet<Solicitude>();
        //}

        public int? TipoId { get; set; }
        [Key]
        public string EmpleadoCedula { get; set; }
        public string EmpleadoNombre { get; set; }
        public string EmpleadoPrimerA { get; set; }
        public string EmpleadoSegundoA { get; set; }
        public string EmpleadoCorreo { get; set; }
        public string EmpleadoEstado { get; set; }

        //public virtual TipoCedula Tipo { get; set; }
        ////public virtual Usuario Usuario { get; set; }
        //public virtual ICollection<Solicitude> Solicitudes { get; set; }
    }
}
