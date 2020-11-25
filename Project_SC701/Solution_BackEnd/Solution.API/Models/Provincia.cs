using System;
using System.Collections.Generic;

#nullable disable

namespace Solution.API.Models
{
    public partial class Provincia
    {
        public Provincia()
        {
            Clientes = new HashSet<Cliente>();
            Solicitudes = new HashSet<Solicitude>();
        }

        public int ProvinciaId { get; set; }
        public string ProvinciaNombre { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Solicitude> Solicitudes { get; set; }
    }
}
