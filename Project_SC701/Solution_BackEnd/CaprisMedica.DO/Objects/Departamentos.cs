using System;
using System.Collections.Generic;

namespace CaprisMedica.DO.Objects
{
    public class Departamentos
    {
        public Departamentos()
        {
            DepartamentoXCliente = new HashSet<DepartamentoXCliente>();
            EquipoXDepartamento = new HashSet<EquipoXDepartamento>();
            Solicitudes = new HashSet<Solicitudes>();
        }

        public int DepartamentoId { get; set; }
        public string DeparatamentoNombre { get; set; }
        public long? EmpleadoCedula { get; set; }

        public virtual Empleados EmpleadoCedulaNavigation { get; set; }
        public virtual ICollection<DepartamentoXCliente> DepartamentoXCliente { get; set; }
        public virtual ICollection<EquipoXDepartamento> EquipoXDepartamento { get; set; }
        public virtual ICollection<Solicitudes> Solicitudes { get; set; }
    }
}
