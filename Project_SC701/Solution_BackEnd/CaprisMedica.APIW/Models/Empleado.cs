using System;
using System.Collections.Generic;

#nullable disable

namespace CaprisMedica.APIW.Models
{
    public partial class Empleado
    {
        public Empleado()
        {
            Departamentos = new HashSet<Departamento>();
            Solicitudes = new HashSet<Solicitude>();
        }

        public int? TipoId { get; set; }
        public long EmpleadoCedula { get; set; }
        public string EmpleadoNombre { get; set; }
        public string EmpleadoPrimerA { get; set; }
        public string EmpleadoSegundoA { get; set; }
        public string EmpleadoCorreo { get; set; }

        public virtual TipoCedula Tipo { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<Departamento> Departamentos { get; set; }
        public virtual ICollection<Solicitude> Solicitudes { get; set; }
    }
}
