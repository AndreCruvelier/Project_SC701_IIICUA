using Microsoft.EntityFrameworkCore;
using Solution.DO.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution.DAL.EF
{
    public class SolutionDBContext:DbContext
    {
        public SolutionDBContext(DbContextOptions<SolutionDBContext> options) 
            : base(options) 
        { 
        
        }

   


        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Departamentos> Departamentos { get; set; }
        public DbSet<Departamento_X_Cliente> Departamento_X_Cliente { get; set; }
        public DbSet<Empleados> Empleados { get; set; }
        public DbSet<Equipos> Equipos { get; set; }
        public DbSet<Equipo_X_Departamento> Equipo_X_Departamento { get; set; }
        public DbSet<Provincias> Provincias { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Solicitudes> Solicitudes { get; set; }
        public DbSet<TipoCedula> TipoCedula { get; set; }
        public DbSet<TipoTrabajo> TipoTrabajo { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }


    }
}
