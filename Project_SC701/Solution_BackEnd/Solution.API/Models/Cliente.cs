using System;
using System.Collections.Generic;

#nullable disable

namespace Solution.API.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            DepartamentoXClientes = new HashSet<DepartamentoXCliente>();
            Solicitudes = new HashSet<Solicitude>();
        }

        public int ClienteId { get; set; }
        public int ProvinciaId { get; set; }
        public string ClienteNombre { get; set; }
        public string ClienteCorreo { get; set; }
        public string ClienteEstado { get; set; }

        public virtual Provincia Provincia { get; set; }
        public virtual ICollection<DepartamentoXCliente> DepartamentoXClientes { get; set; }
        public virtual ICollection<Solicitude> Solicitudes { get; set; }
    }
}
