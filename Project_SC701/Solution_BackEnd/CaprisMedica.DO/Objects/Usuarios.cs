using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CaprisMedica.DO.Objects
{
    public class Usuarios
    {
        [ForeignKey("Usuario")]
        public long Usuario { get; set; }
        public int RolId { get; set; }
        public string UsuarioContraseA { get; set; }

        public virtual Roles Rol { get; set; }

        public virtual Empleados UsuarioNavigation { get; set; }
    }
}
