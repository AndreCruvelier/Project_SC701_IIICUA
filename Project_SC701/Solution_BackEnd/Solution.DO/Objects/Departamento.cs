using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Solution.DO.Objects
{
    public  class Departamentos
    {
        //public Departamento()
        //{
        //    DepartamentoXClientes = new HashSet<DepartamentoXCliente>();
        //    EquipoXDepartamentos = new HashSet<EquipoXDepartamento>();
        //    Solicitudes = new HashSet<Solicitude>();
        //}
        [Key]
        public int DepartamentoId { get; set; }
        public string DeparatamentoNombre { get; set; }
        public string DepartamentoEstado { get; set; }

        //public virtual ICollection<DepartamentoXCliente> DepartamentoXClientes { get; set; }
        //public virtual ICollection<EquipoXDepartamento> EquipoXDepartamentos { get; set; }
        //public virtual ICollection<Solicitude> Solicitudes { get; set; }
    }
}
