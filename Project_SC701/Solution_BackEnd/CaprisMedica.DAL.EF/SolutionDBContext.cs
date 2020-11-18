using CaprisMedica.DO.Objects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaprisMedica.DAL.EF
{
    public class SolutionDBContext : DbContext
    {
        public SolutionDBContext(DbContextOptions<SolutionDBContext> options):base(options)
        {

        }
        public  DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public  DbSet<AspNetRoles> AspNetRoles { get; set; }
        public  DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public  DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public  DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public  DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public  DbSet<AspNetUsers> AspNetUsers { get; set; }
        public  DbSet<Clientes> Clientes { get; set; }
        public  DbSet<DepartamentoXCliente> DepartamentoXCliente { get; set; }
        public  DbSet<Departamentos> Departamentos { get; set; }
        public  DbSet<Empleados> Empleados { get; set; }
        public  DbSet<EquipoXDepartamento> EquipoXDepartamento { get; set; }
        public  DbSet<Equipos> Equipos { get; set; }
        public  DbSet<Provincias> Provincias { get; set; }
        public  DbSet<Roles> Roles { get; set; }
        public  DbSet<Solicitudes> Solicitudes { get; set; }
        public  DbSet<TipoCedula> TipoCedula { get; set; }
        public  DbSet<TipoTrabajo> TipoTrabajo { get; set; }
        public  DbSet<Usuarios> Usuarios { get; set; }
    }
}
