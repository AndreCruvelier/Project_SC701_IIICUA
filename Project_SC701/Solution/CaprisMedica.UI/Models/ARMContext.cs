using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CaprisMedica.UI.Models
{
    public partial class ARMContext : DbContext
    {
        public ARMContext()
        {
        }

        public ARMContext(DbContextOptions<ARMContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<DepartamentoXCliente> DepartamentoXCliente { get; set; }
        public virtual DbSet<Departamentos> Departamentos { get; set; }
        public virtual DbSet<Empleados> Empleados { get; set; }
        public virtual DbSet<EquipoXDepartamento> EquipoXDepartamento { get; set; }
        public virtual DbSet<Equipos> Equipos { get; set; }
        public virtual DbSet<Provincias> Provincias { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Solicitudes> Solicitudes { get; set; }
        public virtual DbSet<TipoCedula> TipoCedula { get; set; }
        public virtual DbSet<TipoTrabajo> TipoTrabajo { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-IBGDNFR\\SQLEXPRESS;Database=ARM;User Id=ANDREDB;Password=prueba;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.HasKey(e => e.ClienteId)
                    .HasName("PK_tblClientes");

                entity.Property(e => e.ClienteId).HasColumnName("clienteId");

                entity.Property(e => e.ClienteNombre)
                    .IsRequired()
                    .HasColumnName("clienteNombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProvinciaId).HasColumnName("provinciaId");

                entity.HasOne(d => d.Provincia)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.ProvinciaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblClientes_tblProvincias");
            });

            modelBuilder.Entity<DepartamentoXCliente>(entity =>
            {
                entity.HasKey(e => new { e.ClienteId, e.DepartamentoId });

                entity.ToTable("Departamento_X_Cliente");

                entity.Property(e => e.ClienteId).HasColumnName("clienteId");

                entity.Property(e => e.DepartamentoId).HasColumnName("departamentoId");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.DepartamentoXCliente)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Departamento_X_Cliente_Clientes");

                entity.HasOne(d => d.Departamento)
                    .WithMany(p => p.DepartamentoXCliente)
                    .HasForeignKey(d => d.DepartamentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Departamento_X_Cliente_Departamentos");
            });

            modelBuilder.Entity<Departamentos>(entity =>
            {
                entity.HasKey(e => e.DepartamentoId)
                    .HasName("PK_tblDepartamentos");

                entity.Property(e => e.DepartamentoId).HasColumnName("departamentoId");

                entity.Property(e => e.DeparatamentoNombre)
                    .IsRequired()
                    .HasColumnName("deparatamentoNombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpleadoCedula)
                    .HasColumnName("empleadoCedula")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.EmpleadoCedulaNavigation)
                    .WithMany(p => p.Departamentos)
                    .HasForeignKey(d => d.EmpleadoCedula)
                    .HasConstraintName("FK_tblDepartamentos_tblEmpleados");
            });

            modelBuilder.Entity<Empleados>(entity =>
            {
                entity.HasKey(e => e.EmpleadoCedula)
                    .HasName("PK_Empleado");

                entity.Property(e => e.EmpleadoCedula)
                    .HasColumnName("empleadoCedula")
                    .ValueGeneratedNever();

                entity.Property(e => e.EmpleadoCorreo)
                    .IsRequired()
                    .HasColumnName("empleadoCorreo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpleadoNombre)
                    .IsRequired()
                    .HasColumnName("empleadoNombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpleadoPrimerA)
                    .IsRequired()
                    .HasColumnName("empleadoPrimerA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpleadoSegundoA)
                    .IsRequired()
                    .HasColumnName("empleadoSegundoA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Tipo)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.TipoId)
                    .HasConstraintName("FK_Empleados_Tipo_Ced");
            });

            modelBuilder.Entity<EquipoXDepartamento>(entity =>
            {
                entity.HasKey(e => new { e.DepartamentoId, e.EquipoId })
                    .HasName("PK_Equipo_x_Departamento");

                entity.ToTable("Equipo_X_Departamento");

                entity.Property(e => e.DepartamentoId).HasColumnName("departamentoId");

                entity.Property(e => e.EquipoId).HasColumnName("equipoId");

                entity.Property(e => e.CantEquipos).HasColumnName("cant_equipos");

                entity.HasOne(d => d.Departamento)
                    .WithMany(p => p.EquipoXDepartamento)
                    .HasForeignKey(d => d.DepartamentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Equipo_x_Departamento_Departamentos");

                entity.HasOne(d => d.Equipo)
                    .WithMany(p => p.EquipoXDepartamento)
                    .HasForeignKey(d => d.EquipoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Equipo_x_Departamento_Equipos");
            });

            modelBuilder.Entity<Equipos>(entity =>
            {
                entity.HasKey(e => e.EquipoId)
                    .HasName("PK_tblEquipos");

                entity.Property(e => e.EquipoId).HasColumnName("equipoId");

                entity.Property(e => e.EquipoNombre)
                    .IsRequired()
                    .HasColumnName("equipoNombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Provincias>(entity =>
            {
                entity.HasKey(e => e.ProvinciaId)
                    .HasName("PK_Provincia");

                entity.Property(e => e.ProvinciaId)
                    .HasColumnName("provinciaId")
                    .ValueGeneratedNever();

                entity.Property(e => e.ProvinciaNombre)
                    .IsRequired()
                    .HasColumnName("provinciaNombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.RolId)
                    .HasName("PK_Rol");

                entity.Property(e => e.RolId).HasColumnName("rolId");

                entity.Property(e => e.RolDescripcion)
                    .IsRequired()
                    .HasColumnName("rolDescripcion")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RolNombre)
                    .IsRequired()
                    .HasColumnName("rolNombre")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Solicitudes>(entity =>
            {
                entity.HasKey(e => e.SolicitudId)
                    .HasName("PK_Solicitud");

                entity.Property(e => e.SolicitudId).HasColumnName("solicitudId");

                entity.Property(e => e.CantidadHoras).HasColumnName("cantidadHoras");

                entity.Property(e => e.ClienteId).HasColumnName("clienteId");

                entity.Property(e => e.DepartamentoId).HasColumnName("departamentoId");

                entity.Property(e => e.EmpleadoCedula).HasColumnName("empleadoCedula");

                entity.Property(e => e.EquipoDetenido).HasColumnName("equipoDetenido");

                entity.Property(e => e.EquipoId).HasColumnName("equipoId");

                entity.Property(e => e.FechaReporte)
                    .HasColumnName("fechaReporte")
                    .HasColumnType("datetime");

                entity.Property(e => e.HoraEntrada)
                    .HasColumnName("horaEntrada")
                    .HasColumnType("datetime");

                entity.Property(e => e.HoraSalida)
                    .HasColumnName("horaSalida")
                    .HasColumnType("datetime");

                entity.Property(e => e.MotivoDetalle)
                    .IsRequired()
                    .HasColumnName("motivoDetalle")
                    .IsUnicode(false);

                entity.Property(e => e.SolicitudJefatura).HasColumnName("solicitudJefatura");

                entity.Property(e => e.SolicitudMotivo)
                    .IsRequired()
                    .HasColumnName("solicitudMotivo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SolicitudRepuestos)
                    .IsRequired()
                    .HasColumnName("solicitudRepuestos")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipoHora)
                    .IsRequired()
                    .HasColumnName("tipoHora")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoTrabajoId).HasColumnName("tipoTrabajoId");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Solicitudes)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblSolicitud_tblClientes");

                entity.HasOne(d => d.Departamento)
                    .WithMany(p => p.Solicitudes)
                    .HasForeignKey(d => d.DepartamentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblSolicitud_tblDepartamentos");

                entity.HasOne(d => d.EmpleadoCedulaNavigation)
                    .WithMany(p => p.Solicitudes)
                    .HasForeignKey(d => d.EmpleadoCedula)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblSolicitud_tblEmpleados");

                entity.HasOne(d => d.Equipo)
                    .WithMany(p => p.Solicitudes)
                    .HasForeignKey(d => d.EquipoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblSolicitud_tblEquipos");

                entity.HasOne(d => d.TipoTrabajo)
                    .WithMany(p => p.Solicitudes)
                    .HasForeignKey(d => d.TipoTrabajoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblSolicitud_tblTipoTrabajo");
            });

            modelBuilder.Entity<TipoCedula>(entity =>
            {
                entity.HasKey(e => e.TipoId)
                    .HasName("PK_Tipo_cedula");

                entity.Property(e => e.TipoId).ValueGeneratedNever();

                entity.Property(e => e.TipoDescripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoTrabajo>(entity =>
            {
                entity.Property(e => e.TipoTrabajoId).HasColumnName("tipoTrabajoId");

                entity.Property(e => e.TipoTrabajoNombre)
                    .IsRequired()
                    .HasColumnName("tipoTrabajoNombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.Usuario)
                    .HasName("PK_Usuario");

                entity.Property(e => e.Usuario)
                    .HasColumnName("usuario")
                    .ValueGeneratedNever();

                entity.Property(e => e.RolId).HasColumnName("rolId");

                entity.Property(e => e.UsuarioContraseA)
                    .IsRequired()
                    .HasColumnName("usuarioContrase�a")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.RolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblUsuarios_tblRoles");

                entity.HasOne(d => d.UsuarioNavigation)
                    .WithOne(p => p.Usuarios)
                    .HasForeignKey<Usuarios>(d => d.Usuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Usuarios_Empleados");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
