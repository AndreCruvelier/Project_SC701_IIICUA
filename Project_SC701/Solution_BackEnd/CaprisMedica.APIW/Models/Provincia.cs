using System;
using System.Collections.Generic;

#nullable disable

namespace CaprisMedica.APIW.Models
{
    public partial class Provincia
    {
        public Provincia()
        {
            Clientes = new HashSet<Cliente>();
        }

        public int ProvinciaId { get; set; }
        public string ProvinciaNombre { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
