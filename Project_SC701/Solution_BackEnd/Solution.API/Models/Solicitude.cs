﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Solution.API.Models
{
    public partial class Solicitude
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
        public int? ProvinciaId { get; set; }
        public byte[] FirmaCliente { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Departamento Departamento { get; set; }
        public virtual Empleado EmpleadoCedulaNavigation { get; set; }
        public virtual Equipo Equipo { get; set; }
        public virtual Provincia Provincia { get; set; }
        public virtual TipoTrabajo TipoTrabajo { get; set; }
    }
}
