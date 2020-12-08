using System;
using System.Collections.Generic;

namespace CaprisMedica.UI.Models
{
    public partial class Departamentos
    {
        public Departamentos()
        {
            EquipoXDepartamento = new HashSet<EquipoXDepartamento>();
            Solicitudes = new HashSet<Solicitudes>();
        }

        public int DepartamentoId { get; set; }
        public string DeparatamentoNombre { get; set; }
        public string DepartamentoEstado { get; set; }

        public virtual DepartamentoXCliente DepartamentoXCliente { get; set; }
        public virtual ICollection<EquipoXDepartamento> EquipoXDepartamento { get; set; }
        public virtual ICollection<Solicitudes> Solicitudes { get; set; }
    }
}
