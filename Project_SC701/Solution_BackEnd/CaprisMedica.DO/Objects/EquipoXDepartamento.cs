using System;
using System.Collections.Generic;

namespace CaprisMedica.DO.Objects
{
    public class EquipoXDepartamento
    {
        public int DepartamentoId { get; set; }
        public int EquipoId { get; set; }
        public int CantEquipos { get; set; }

        public virtual Departamentos Departamento { get; set; }
        public virtual Equipos Equipo { get; set; }
    }
}
