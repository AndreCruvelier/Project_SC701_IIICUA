using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Solution.DO.Objects
{
    public  class Provincias
    {
        //public Provincia()
        //{
        //    Clientes = new HashSet<Cliente>();
        //    Solicitudes = new HashSet<Solicitude>();
        //}
        [Key]
        public int ProvinciaId { get; set; }
        public string ProvinciaNombre { get; set; }

        //public virtual ICollection<Cliente> Clientes { get; set; }
        //public virtual ICollection<Solicitude> Solicitudes { get; set; }
    }
}
