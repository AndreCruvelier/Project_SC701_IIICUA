using System;
using System.Collections.Generic;

namespace CaprisMedica.UI.Models
{
    public partial class Clientes
    {
        public Clientes()
        {
            DepartamentoXCliente = new HashSet<DepartamentoXCliente>();
            Solicitudes = new HashSet<Solicitudes>();
        }

        public int ClienteId { get; set; }
        public int ProvinciaId { get; set; }
        public string ClienteNombre { get; set; }
        public string ClienteCorreo { get; set; }
        public string ClienteEstado { get; set; }

        public virtual Provincias Provincia { get; set; }
        public virtual ICollection<DepartamentoXCliente> DepartamentoXCliente { get; set; }
        public virtual ICollection<Solicitudes> Solicitudes { get; set; }
    }
}
