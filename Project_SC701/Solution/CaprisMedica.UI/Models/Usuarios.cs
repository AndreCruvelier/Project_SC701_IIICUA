using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CaprisMedica.UI.Models
{
    public partial class Usuarios
    {
        public string Usuario { get; set; }
        public int RolId { get; set; }
        [DataType(DataType.Password)]
        public string UsuarioContraseña { get; set; }

        public virtual Roles Rol { get; set; }
    }
}
