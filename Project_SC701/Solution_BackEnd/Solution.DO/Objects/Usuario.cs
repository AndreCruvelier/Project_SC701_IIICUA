using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Solution.DO.Objects
{
    public  class Usuarios
    {
        [Key]
        public string Usuario { get; set; }
        public int RolId { get; set; }
        public string UsuarioContraseña { get; set; }

        //public virtual Role Rol { get; set; }
        //public virtual Empleado Usuario1Navigation { get; set; }
    }
}
