using System;
using System.Collections.Generic;

namespace CaprisMedica.UI.Models
{
    public partial class Provincias
    {
        public Provincias()
        {
            Clientes = new HashSet<Clientes>();
        }

        public int ProvinciaId { get; set; }
        public string ProvinciaNombre { get; set; }

        public virtual ICollection<Clientes> Clientes { get; set; }
    }
}
