using System;
using System.Collections.Generic;

namespace CaprisMedica.DO.Objects
{
    public class DepartamentoXCliente
    {
        public int ClienteId { get; set; }
        public int DepartamentoId { get; set; }

        public virtual Clientes Cliente { get; set; }
        public virtual Departamentos Departamento { get; set; }
    }
}
