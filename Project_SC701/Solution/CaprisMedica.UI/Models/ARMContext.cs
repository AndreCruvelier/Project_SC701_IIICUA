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
            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.HasKey(e => e.ClienteId)
                    .HasName("PK__Clientes__C2FF245D9BE277F2");

                entity.Property(e => e.ClienteId).HasColumnName("clienteId");

                entity.Property(e => e.ClienteCorreo)
                    .IsRequired()
                    .HasColumnName("clienteCorreo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteEstado)
                    .IsRequired()
                    .HasColumnName("clienteEstado")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Activo')");

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
                    .HasConstraintName("FK__Clientes__provin__4CA06362");
            });

            modelBuilder.Entity<DepartamentoXCliente>(entity =>
            {
                entity.HasKey(e => e.DepartamentoId)
                    .HasName("PK__Departam__A67AC178DF3AB7A2");

                entity.ToTable("Departamento_X_Cliente");

                entity.Property(e => e.DepartamentoId)
                    .HasColumnName("departamentoId")
                    .ValueGeneratedNever();

                entity.Property(e => e.CantDepartamentos).HasColumnName("cant_departamentos");

                entity.Property(e => e.ClienteId).HasColumnName("clienteId");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.DepartamentoXCliente)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Departame__clien__534D60F1");

                entity.HasOne(d => d.Departamento)
                    .WithOne(p => p.DepartamentoXCliente)
                    .HasForeignKey<DepartamentoXCliente>(d => d.DepartamentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Departame__depar__52593CB8");
            });

            modelBuilder.Entity<Departamentos>(entity =>
            {
                entity.HasKey(e => e.DepartamentoId)
                    .HasName("PK__Departam__A67AC178D03A6C66");

                entity.Property(e => e.DepartamentoId).HasColumnName("departamentoId");

                entity.Property(e => e.DeparatamentoNombre)
                    .IsRequired()
                    .HasColumnName("deparatamentoNombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepartamentoEstado)
                    .IsRequired()
                    .HasColumnName("departamentoEstado")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Activo')");
            });

            modelBuilder.Entity<Empleados>(entity =>
            {
                entity.HasKey(e => e.EmpleadoCedula)
                    .HasName("PK__Empleado__7F411F34A5DBA396");

                entity.Property(e => e.EmpleadoCedula)
                    .HasColumnName("empleadoCedula")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpleadoCorreo)
                    .IsRequired()
                    .HasColumnName("empleadoCorreo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpleadoEstado)
                    .IsRequired()
                    .HasColumnName("empleadoEstado")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Activo')");

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
                    .HasConstraintName("FK__Empleados__TipoI__59063A47");
            });

            modelBuilder.Entity<EquipoXDepartamento>(entity =>
            {
                entity.HasKey(e => new { e.DepartamentoId, e.EquipoId })
                    .HasName("PK__Equipo_X__BDDDE1026192DBE6");

                entity.ToTable("Equipo_X_Departamento");

                entity.Property(e => e.DepartamentoId).HasColumnName("departamentoId");

                entity.Property(e => e.EquipoId).HasColumnName("equipoId");

                entity.Property(e => e.CantEquipos).HasColumnName("cant_equipos");

                entity.HasOne(d => d.Departamento)
                    .WithMany(p => p.EquipoXDepartamento)
                    .HasForeignKey(d => d.DepartamentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Equipo_X___depar__5EBF139D");

              //  entity.HasOne(d => d.Equipo)
                //    .WithMany(p => p.EquipoXDepartamento)
                //    .HasForeignKey(d => d.EquipoId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK__Equipo_X___equip__5DCAEF64");
            });

            modelBuilder.Entity<Equipos>(entity =>
            {
                entity.HasKey(e => e.EquipoId)
                    .HasName("PK__Equipos__BA7207A032784363");

                entity.Property(e => e.EquipoId).HasColumnName("equipoId");

                entity.Property(e => e.EquipoEstado)
                    .IsRequired()
                    .HasColumnName("equipoEstado")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EquipoNombre)
                    .IsRequired()
                    .HasColumnName("equipoNombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Provincias>(entity =>
            {
                entity.HasKey(e => e.ProvinciaId)
                    .HasName("PK__Provinci__671F12A5B487DF08");

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
                    .HasName("PK__Roles__5402363494BF3183");

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
                    .HasName("PK__Solicitu__1B36B2FCC648E6EE");

                entity.Property(e => e.SolicitudId).HasColumnName("solicitudId");

                entity.Property(e => e.CantidadHoras).HasColumnName("cantidadHoras");

                entity.Property(e => e.ClienteId).HasColumnName("clienteId");

                entity.Property(e => e.DepartamentoId).HasColumnName("departamentoId");

                entity.Property(e => e.EmpleadoCedula)
                    .IsRequired()
                    .HasColumnName("empleadoCedula")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EquipoDetenido).HasColumnName("equipoDetenido");

                entity.Property(e => e.EquipoId).HasColumnName("equipoId");

                entity.Property(e => e.FechaReporte)
                    .HasColumnName("fechaReporte")
                    .HasColumnType("datetime");

                entity.Property(e => e.FirmaCliente)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Si')");

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

                entity.Property(e => e.ProvinciaId).HasColumnName("provinciaId");

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
                    .HasConstraintName("FK__Solicitud__clien__6A30C649");

                entity.HasOne(d => d.Departamento)
                    .WithMany(p => p.Solicitudes)
                    .HasForeignKey(d => d.DepartamentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Solicitud__depar__6D0D32F4");

                entity.HasOne(d => d.EmpleadoCedulaNavigation)
                    .WithMany(p => p.Solicitudes)
                    .HasForeignKey(d => d.EmpleadoCedula)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Solicitud__emple__6B24EA82");

                //entity.HasOne(d => d.Equipo)
                  //  .WithMany(p => p.Solicitudes)
                   // .HasForeignKey(d => d.EquipoId)
                   // .OnDelete(DeleteBehavior.ClientSetNull)
                   // .HasConstraintName("FK__Solicitud__equip__6E01572D");

                entity.HasOne(d => d.Provincia)
                    .WithMany(p => p.Solicitudes)
                    .HasForeignKey(d => d.ProvinciaId)
                    .HasConstraintName("FK__Solicitud__provi__6EF57B66");

                entity.HasOne(d => d.TipoTrabajo)
                    .WithMany(p => p.Solicitudes)
                    .HasForeignKey(d => d.TipoTrabajoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Solicitud__tipoT__6C190EBB");
            });

            modelBuilder.Entity<TipoCedula>(entity =>
            {
                entity.HasKey(e => e.TipoId)
                    .HasName("PK__TipoCedu__97099EB7B599C2FE");

                entity.Property(e => e.TipoId).ValueGeneratedNever();

                entity.Property(e => e.TipoDescripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoTrabajo>(entity =>
            {
                entity.Property(e => e.TipoTrabajoId).HasColumnName("tipoTrabajoId");

                entity.Property(e => e.TipoTrabajoEstado)
                    .IsRequired()
                    .HasColumnName("tipoTrabajoEstado")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Activo')");

                entity.Property(e => e.TipoTrabajoNombre)
                    .IsRequired()
                    .HasColumnName("tipoTrabajoNombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.Usuario)
                    .HasName("PK__Usuarios__9AFF8FC7996F6BA7");

                entity.Property(e => e.Usuario)
                    .HasColumnName("usuario")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RolId).HasColumnName("rolId");

                entity.Property(e => e.UsuarioContraseña)
                    .IsRequired()
                    .HasColumnName("usuarioContraseña")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.RolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Usuarios__rolId__66603565");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
