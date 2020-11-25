using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Solution.DO.Objects
{
    public  class Clientes
    {
        //public Cliente()
        //{
        //    DepartamentoXClientes = new HashSet<DepartamentoXCliente>();
        //    Solicitudes = new HashSet<Solicitude>();
        //}
        [Key]
        public int? ClienteId { get; set; }
        public int ProvinciaId { get; set; }
        public string ClienteNombre { get; set; }
        public string ClienteCorreo { get; set; }
        public string ClienteEstado { get; set; }

        //public virtual Provincia Provincia { get; set; }
        //public virtual ICollection<DepartamentoXCliente> DepartamentoXClientes { get; set; }
        //public virtual ICollection<Solicitude> Solicitudes { get; set; }
    }
}
