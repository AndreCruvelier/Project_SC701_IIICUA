using System;
using System.Collections.Generic;

namespace CaprisMedica.UI.Models
{
    public partial class Usuarios
    {
        public long Usuario { get; set; }
        public int RolId { get; set; }
        public string UsuarioContraseA { get; set; }

        public virtual Roles Rol { get; set; }
        public virtual Empleados UsuarioNavigation { get; set; }
    }
}
