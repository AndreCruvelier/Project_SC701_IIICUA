using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Solution.DO.Objects
{
    public  class Roles
    {
        //public Role()
        //{
        //    Usuarios = new HashSet<Usuario>();
        //}
        [Key]
        public int RolId { get; set; }
        public string RolNombre { get; set; }
        public string RolDescripcion { get; set; }

        //public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
