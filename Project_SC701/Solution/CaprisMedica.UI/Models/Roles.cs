using System;
using System.Collections.Generic;

namespace CaprisMedica.UI.Models
{
    public partial class Roles
    {
        public Roles()
        {
            Usuarios = new HashSet<Usuarios>();
        }

        public int RolId { get; set; }
        public string RolNombre { get; set; }
        public string RolDescripcion { get; set; }

        public virtual ICollection<Usuarios> Usuarios { get; set; }
    }
}
