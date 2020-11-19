using System;
using System.Collections.Generic;

namespace CaprisMedica.DO.Objects
{
    public class Provincias
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
