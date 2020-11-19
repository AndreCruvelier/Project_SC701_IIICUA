using System;
using System.Collections.Generic;

namespace CaprisMedica.DO.Objects
{
    public class Empleados
    {
        public Empleados()
        {
            Departamentos = new HashSet<Departamentos>();
            Solicitudes = new HashSet<Solicitudes>();
        }

        public int? TipoId { get; set; }
        public long EmpleadoCedula { get; set; }
        public string EmpleadoNombre { get; set; }
        public string EmpleadoPrimerA { get; set; }
        public string EmpleadoSegundoA { get; set; }
        public string EmpleadoCorreo { get; set; }

        public virtual TipoCedula Tipo { get; set; }
        public virtual Usuarios Usuarios { get; set; }
        public virtual ICollection<Departamentos> Departamentos { get; set; }
        public virtual ICollection<Solicitudes> Solicitudes { get; set; }
    }
}
