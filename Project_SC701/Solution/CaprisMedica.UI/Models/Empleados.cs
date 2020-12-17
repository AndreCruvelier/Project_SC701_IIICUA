using System;
using System.Collections.Generic;

namespace CaprisMedica.UI.Models
{
    public partial class Empleados
    {
        public Empleados()
        {
            //Solicitudes = new HashSet<Solicitudes>();
        }

        public int? TipoId { get; set; }
        public string EmpleadoCedula { get; set; }
        public string EmpleadoNombre { get; set; }
        public string EmpleadoPrimerA { get; set; }
        public string EmpleadoSegundoA { get; set; }
        public string EmpleadoCorreo { get; set; }
        public string EmpleadoEstado { get; set; }

        //public virtual TipoCedula Tipo { get; set; }
        //public virtual ICollection<Solicitudes> Solicitudes { get; set; }
    }
}
