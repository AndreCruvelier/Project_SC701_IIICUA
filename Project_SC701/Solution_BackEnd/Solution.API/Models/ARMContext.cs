using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Solution.API.Models
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

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Departamento> Departamentos { get; set; }
        public virtual DbSet<DepartamentoXCliente> DepartamentoXClientes { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<Equipo> Equipos { get; set; }
        public virtual DbSet<EquipoXDepartamento> EquipoXDepartamentos { get; set; }
        public virtual DbSet<Provincia> Provincias { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Solicitude> Solicitudes { get; set; }
        public virtual DbSet<TipoCedula> TipoCedulas { get; set; }
        public virtual DbSet<TipoTrabajo> TipoTrabajos { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=ARM;User Id=sa;Password=123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasIndex(e => e.ClienteNombre, "UQ__Clientes__A5A55F52150CC387")
                    .IsUnique();

                entity.Property(e => e.ClienteId).HasColumnName("clienteId");

                entity.Property(e => e.ClienteCorreo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("clienteCorreo");

                entity.Property(e => e.ClienteEstado)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("clienteEstado")
                    .HasDefaultValueSql("('Activo')");

                entity.Property(e => e.ClienteNombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("clienteNombre");

                entity.Property(e => e.ProvinciaId).HasColumnName("provinciaId");

                entity.HasOne(d => d.Provincia)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.ProvinciaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblClientes_tblProvincias");
            });

            modelBuilder.Entity<Departamento>(entity =>
            {
                entity.HasIndex(e => e.DeparatamentoNombre, "UQ__Departam__48E4C956384F265D")
                    .IsUnique();

                entity.Property(e => e.DepartamentoId).HasColumnName("departamentoId");

                entity.Property(e => e.DeparatamentoNombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("deparatamentoNombre");

                entity.Property(e => e.DepartamentoEstado)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("departamentoEstado")
                    .HasDefaultValueSql("('Activo')");
            });

            modelBuilder.Entity<DepartamentoXCliente>(entity =>
            {
                entity.HasKey(e => new { e.DepartamentoId, e.ClienteId });

                entity.ToTable("Departamento_X_Cliente");

                entity.Property(e => e.DepartamentoId).HasColumnName("departamentoId");

                entity.Property(e => e.ClienteId).HasColumnName("clienteId");

                entity.Property(e => e.CantDepartamentos).HasColumnName("cant_departamentos");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.DepartamentoXClientes)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Departamento_X_Cliente_Clientes");

                entity.HasOne(d => d.Departamento)
                    .WithMany(p => p.DepartamentoXClientes)
                    .HasForeignKey(d => d.DepartamentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Departamento_X_Cliente_Departamentos");
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.EmpleadoCedula)
                    .HasName("PK_Empleado");

                entity.Property(e => e.EmpleadoCedula)
                    .ValueGeneratedNever()
                    .HasColumnName("empleadoCedula");

                entity.Property(e => e.EmpleadoCorreo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("empleadoCorreo");

                entity.Property(e => e.EmpleadoEstado)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("empleadoEstado")
                    .HasDefaultValueSql("('Activo')");

                entity.Property(e => e.EmpleadoNombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("empleadoNombre");

                entity.Property(e => e.EmpleadoPrimerA)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("empleadoPrimerA");

                entity.Property(e => e.EmpleadoSegundoA)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("empleadoSegundoA");

                entity.HasOne(d => d.Tipo)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.TipoId)
                    .HasConstraintName("FK_Empleados_Tipo_Ced");
            });

            modelBuilder.Entity<Equipo>(entity =>
            {
                entity.HasIndex(e => e.EquipoNombre, "UQ__Equipos__7DA3D1D06BF1ACA0")
                    .IsUnique();

                entity.Property(e => e.EquipoId).HasColumnName("equipoId");

                entity.Property(e => e.EquipoEstado)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("equipoEstado");

                entity.Property(e => e.EquipoNombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("equipoNombre");
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
                    .WithMany(p => p.EquipoXDepartamentos)
                    .HasForeignKey(d => d.DepartamentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Equipo_x_Departamento_Departamentos");

                entity.HasOne(d => d.Equipo)
                    .WithMany(p => p.EquipoXDepartamentos)
                    .HasForeignKey(d => d.EquipoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Equipo_x_Departamento_Equipos");
            });

            modelBuilder.Entity<Provincia>(entity =>
            {
                entity.Property(e => e.ProvinciaId)
                    .ValueGeneratedNever()
                    .HasColumnName("provinciaId");

                entity.Property(e => e.ProvinciaNombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("provinciaNombre");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.RolId)
                    .HasName("PK_Rol");

                entity.Property(e => e.RolId).HasColumnName("rolId");

                entity.Property(e => e.RolDescripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("rolDescripcion");

                entity.Property(e => e.RolNombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("rolNombre");
            });

            modelBuilder.Entity<Solicitude>(entity =>
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
                    .HasColumnType("datetime")
                    .HasColumnName("fechaReporte")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.FirmaCliente)
                    .HasColumnType("image")
                    .HasAnnotation("Relational:ColumnType", "image");

                entity.Property(e => e.HoraEntrada)
                    .HasColumnType("datetime")
                    .HasColumnName("horaEntrada")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.HoraSalida)
                    .HasColumnType("datetime")
                    .HasColumnName("horaSalida")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.MotivoDetalle)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("motivoDetalle");

                entity.Property(e => e.ProvinciaId).HasColumnName("provinciaId");

                entity.Property(e => e.SolicitudJefatura).HasColumnName("solicitudJefatura");

                entity.Property(e => e.SolicitudMotivo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("solicitudMotivo");

                entity.Property(e => e.SolicitudRepuestos)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("solicitudRepuestos");

                entity.Property(e => e.TipoHora)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipoHora");

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

                entity.HasOne(d => d.Provincia)
                    .WithMany(p => p.Solicitudes)
                    .HasForeignKey(d => d.ProvinciaId)
                    .HasConstraintName("FK_tblSolicitud_Provincias");

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

                entity.ToTable("TipoCedula");

                entity.Property(e => e.TipoId).ValueGeneratedNever();

                entity.Property(e => e.TipoDescripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoTrabajo>(entity =>
            {
                entity.ToTable("TipoTrabajo");

                entity.HasIndex(e => e.TipoTrabajoNombre, "UQ__TipoTrab__0F7D8C22BD64CFBA")
                    .IsUnique();

                entity.Property(e => e.TipoTrabajoId).HasColumnName("tipoTrabajoId");

                entity.Property(e => e.TipoTrabajoEstado)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("tipoTrabajoEstado")
                    .HasDefaultValueSql("('Activo')");

                entity.Property(e => e.TipoTrabajoNombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipoTrabajoNombre");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.Usuario1)
                    .HasName("PK_Usuario");

                entity.Property(e => e.Usuario1)
                    .ValueGeneratedNever()
                    .HasColumnName("usuario");

                entity.Property(e => e.RolId).HasColumnName("rolId");

                entity.Property(e => e.UsuarioContraseña)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuarioContraseña");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.RolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblUsuarios_tblRoles");

                //entity.HasOne(d => d.Usuario1Navigation)
                //    .WithOne(p => p.Usuario)
                //    .HasForeignKey<Usuario>(d => d.Usuario1)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_Usuarios_Empleados");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
