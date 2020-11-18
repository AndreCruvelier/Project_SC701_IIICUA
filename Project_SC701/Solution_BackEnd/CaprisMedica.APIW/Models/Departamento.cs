using System;
using System.Collections.Generic;

#nullable disable

namespace CaprisMedica.APIW.Models
{
    public partial class Departamento
    {
        public Departamento()
        {
            DepartamentoXClientes = new HashSet<DepartamentoXCliente>();
            EquipoXDepartamentos = new HashSet<EquipoXDepartamento>();
            Solicitudes = new HashSet<Solicitude>();
        }

        public int DepartamentoId { get; set; }
        public string DeparatamentoNombre { get; set; }
        public long? EmpleadoCedula { get; set; }

        public virtual Empleado EmpleadoCedulaNavigation { get; set; }
        public virtual ICollection<DepartamentoXCliente> DepartamentoXClientes { get; set; }
        public virtual ICollection<EquipoXDepartamento> EquipoXDepartamentos { get; set; }
        public virtual ICollection<Solicitude> Solicitudes { get; set; }
    }
}
