using System;
using System.Collections.Generic;

namespace CaprisMedica.UI.Models
{
    public partial class Usuarios
    {
        public string Usuario { get; set; }
        public int RolId { get; set; }
        public string UsuarioContraseña { get; set; }

        public virtual Roles Rol { get; set; }
    }
}
