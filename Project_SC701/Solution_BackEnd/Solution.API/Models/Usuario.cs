using System;
using System.Collections.Generic;

#nullable disable

namespace Solution.API.Models
{
    public partial class Usuario
    {
        public long Usuario1 { get; set; }
        public int RolId { get; set; }
        public string UsuarioContraseña { get; set; }

        public virtual Role Rol { get; set; }
        //public virtual Empleado Usuario1Navigation { get; set; }
    }
}
