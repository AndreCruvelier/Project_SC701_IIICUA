using System;
using System.Collections.Generic;

namespace CaprisMedica.DO.Objects
{
    public class Solicitudes
    {
        public int SolicitudId { get; set; }
        public int ClienteId { get; set; }
        public long EmpleadoCedula { get; set; }
        public int TipoTrabajoId { get; set; }
        public int DepartamentoId { get; set; }
        public int EquipoId { get; set; }
        public int SolicitudJefatura { get; set; }
        public DateTime FechaReporte { get; set; }
        public DateTime HoraEntrada { get; set; }
        public DateTime HoraSalida { get; set; }
        public string TipoHora { get; set; }
        public long CantidadHoras { get; set; }
        public string SolicitudMotivo { get; set; }
        public string MotivoDetalle { get; set; }
        public string SolicitudRepuestos { get; set; }
        public long EquipoDetenido { get; set; }

        public virtual Clientes Cliente { get; set; }
        public virtual Departamentos Departamento { get; set; }
        public virtual Empleados EmpleadoCedulaNavigation { get; set; }
        public virtual Equipos Equipo { get; set; }
        public virtual TipoTrabajo TipoTrabajo { get; set; }
    }
}
