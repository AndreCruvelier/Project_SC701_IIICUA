using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Solution.DO.Objects
{
    public class Departamento_X_Cliente
    {

        [Key]
        public int DepartamentoId { get; set; }
        public int ClienteId { get; set; }
        public int? Cant_Departamentos { get; set; }

        //public virtual Cliente Cliente { get; set; }
        //public virtual Departamento Departamento { get; set; }
    }
}
