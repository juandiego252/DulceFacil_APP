using System;
using System.Collections.Generic;
using DulceFacil.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace DulceFacil.Infraestructure.DataAccess.DataEFCore;

public partial class DulceFacilContext : DbContext
{
    public DulceFacilContext()
    {
    }

    public DulceFacilContext(DbContextOptions<DulceFacilContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CategoriaCliente> CategoriaClientes { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Conductor> Conductors { get; set; }

    public virtual DbSet<DetallePedido> DetallePedidos { get; set; }

    public virtual DbSet<Direccion> Direccions { get; set; }

    public virtual DbSet<Entrega> Entregas { get; set; }

    public virtual DbSet<EstadoEntrega> EstadoEntregas { get; set; }

    public virtual DbSet<Incidencia> Incidencia { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Ruta> Ruta { get; set; }

    public virtual DbSet<Sector> Sectors { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Vehiculo> Vehiculos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-REELKQG\\SQLEXPRESS; Database=DULCEFACIL; User=sa; Password=123456; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CategoriaCliente>(entity =>
        {
            entity.HasKey(e => e.IdCategoria).HasName("PK__CATEGORI__02AA07858B0E2FA4");

            entity.ToTable("CATEGORIA_CLIENTE");

            entity.Property(e => e.IdCategoria).HasColumnName("ID_Categoria");
            entity.Property(e => e.CriteriosClasificacion)
                .HasColumnType("text")
                .HasColumnName("Criterios_Clasificacion");
            entity.Property(e => e.Descripcion).HasColumnType("text");
            entity.Property(e => e.DescuentoAplicable)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("Descuento_Aplicable");
            entity.Property(e => e.NombreCategoria)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Categoria");
            entity.Property(e => e.PrioridadEntrega).HasColumnName("Prioridad_Entrega");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente).HasName("PK__CLIENTE__E005FBFF022003CA");

            entity.ToTable("CLIENTE");

            entity.Property(e => e.IdCliente).HasColumnName("ID_Cliente");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EstadoCliente)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("Activo")
                .HasColumnName("Estado_Cliente");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Registro");
            entity.Property(e => e.IdCategoria).HasColumnName("ID_Categoria");
            entity.Property(e => e.IdDireccion).HasColumnName("ID_Direccion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.TipoNegocio)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Tipo_Negocio");

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.IdCategoria)
                .HasConstraintName("FK__CLIENTE__ID_Cate__571DF1D5");

            entity.HasOne(d => d.IdDireccionNavigation).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.IdDireccion)
                .HasConstraintName("FK__CLIENTE__ID_Dire__5812160E");
        });

        modelBuilder.Entity<Conductor>(entity =>
        {
            entity.HasKey(e => e.IdConductor).HasName("PK__CONDUCTO__24F451ABA6C7F4C2");

            entity.ToTable("CONDUCTOR");

            entity.HasIndex(e => e.Cedula, "UQ__CONDUCTO__B4ADFE38298002BC").IsUnique();

            entity.Property(e => e.IdConductor).HasColumnName("ID_Conductor");
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cedula)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.EstadoConductor)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("Activo")
                .HasColumnName("Estado_Conductor");
            entity.Property(e => e.FechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Ingreso");
            entity.Property(e => e.LicenciaConducir)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Licencia_Conducir");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DetallePedido>(entity =>
        {
            entity.HasKey(e => e.IdDetalle).HasName("PK__DETALLE___B3E0CED316C5153E");

            entity.ToTable("DETALLE_PEDIDO");

            entity.Property(e => e.IdDetalle).HasColumnName("ID_Detalle");
            entity.Property(e => e.IdPedido).HasColumnName("ID_Pedido");
            entity.Property(e => e.IdProducto).HasColumnName("ID_Producto");
            entity.Property(e => e.PrecioUnitario)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("Precio_Unitario");
            entity.Property(e => e.Subtotal)
                .HasComputedColumnSql("([Cantidad]*[Precio_Unitario])", true)
                .HasColumnType("decimal(21, 2)");

            entity.HasOne(d => d.IdPedidoNavigation).WithMany(p => p.DetallePedidos)
                .HasForeignKey(d => d.IdPedido)
                .HasConstraintName("FK__DETALLE_P__ID_Pe__6754599E");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.DetallePedidos)
                .HasForeignKey(d => d.IdProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DETALLE_P__ID_Pr__68487DD7");
        });

        modelBuilder.Entity<Direccion>(entity =>
        {
            entity.HasKey(e => e.IdDireccion).HasName("PK__DIRECCIO__F4CC417232A9A5B2");

            entity.ToTable("DIRECCION");

            entity.Property(e => e.IdDireccion).HasColumnName("ID_Direccion");
            entity.Property(e => e.DireccionCompleta)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Direccion_Completa");
            entity.Property(e => e.IdSector).HasColumnName("ID_Sector");
            entity.Property(e => e.Latitud).HasColumnType("decimal(10, 8)");
            entity.Property(e => e.Longitud).HasColumnType("decimal(11, 8)");
            entity.Property(e => e.Referencia)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.IdSectorNavigation).WithMany(p => p.Direccions)
                .HasForeignKey(d => d.IdSector)
                .HasConstraintName("FK__DIRECCION__ID_Se__5070F446");
        });

        modelBuilder.Entity<Entrega>(entity =>
        {
            entity.HasKey(e => e.IdEntrega).HasName("PK__ENTREGA__FEDACB7FEE81E831");

            entity.ToTable("ENTREGA");

            entity.Property(e => e.IdEntrega).HasColumnName("ID_Entrega");
            entity.Property(e => e.FechaProgramada).HasColumnName("Fecha_Programada");
            entity.Property(e => e.FechaRealEntrega).HasColumnName("Fecha_Real_Entrega");
            entity.Property(e => e.HoraProgramada).HasColumnName("Hora_Programada");
            entity.Property(e => e.HoraRealEntrega).HasColumnName("Hora_Real_Entrega");
            entity.Property(e => e.IdEstadoEntrega).HasColumnName("ID_Estado_Entrega");
            entity.Property(e => e.IdPedido).HasColumnName("ID_Pedido");
            entity.Property(e => e.IdRuta).HasColumnName("ID_Ruta");
            entity.Property(e => e.ObservacionesEntrega)
                .HasColumnType("text")
                .HasColumnName("Observaciones_Entrega");

            entity.HasOne(d => d.IdEstadoEntregaNavigation).WithMany(p => p.Entregas)
                .HasForeignKey(d => d.IdEstadoEntrega)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ENTREGA__ID_Esta__00200768");

            entity.HasOne(d => d.IdPedidoNavigation).WithMany(p => p.Entregas)
                .HasForeignKey(d => d.IdPedido)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ENTREGA__ID_Pedi__7E37BEF6");

            entity.HasOne(d => d.IdRutaNavigation).WithMany(p => p.Entregas)
                .HasForeignKey(d => d.IdRuta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ENTREGA__ID_Ruta__7F2BE32F");
        });

        modelBuilder.Entity<EstadoEntrega>(entity =>
        {
            entity.HasKey(e => e.IdEstado).HasName("PK__ESTADO_E__9CF493953409568B");

            entity.ToTable("ESTADO_ENTREGA");

            entity.Property(e => e.IdEstado).HasColumnName("ID_Estado");
            entity.Property(e => e.DescripcionEstado)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Descripcion_Estado");
            entity.Property(e => e.NombreEstado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Nombre_Estado");
            entity.Property(e => e.NotificaCliente)
                .HasDefaultValue(false)
                .HasColumnName("Notifica_Cliente");
            entity.Property(e => e.OrdenSecuencial).HasColumnName("Orden_Secuencial");
        });

        modelBuilder.Entity<Incidencia>(entity =>
        {
            entity.HasKey(e => e.IdIncidencia).HasName("PK__INCIDENC__3FF3AEAE831DE703");

            entity.ToTable("INCIDENCIA");

            entity.Property(e => e.IdIncidencia).HasColumnName("ID_Incidencia");
            entity.Property(e => e.Descripcion).HasColumnType("text");
            entity.Property(e => e.EstadoIncidencia)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("Abierta")
                .HasColumnName("Estado_Incidencia");
            entity.Property(e => e.FechaIncidencia)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Incidencia");
            entity.Property(e => e.IdEntrega).HasColumnName("ID_Entrega");
            entity.Property(e => e.SolucionAplicada)
                .HasColumnType("text")
                .HasColumnName("Solucion_Aplicada");
            entity.Property(e => e.TipoIncidencia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Tipo_Incidencia");

            entity.HasOne(d => d.IdEntregaNavigation).WithMany(p => p.Incidencia)
                .HasForeignKey(d => d.IdEntrega)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK__INCIDENCI__ID_En__04E4BC85");
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => e.IdPedido).HasName("PK__PEDIDO__FD768070FFF1F266");

            entity.ToTable("PEDIDO");

            entity.Property(e => e.IdPedido).HasColumnName("ID_Pedido");
            entity.Property(e => e.EstadoPedido)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("Pendiente")
                .HasColumnName("Estado_Pedido");
            entity.Property(e => e.FechaPedido)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Pedido");
            entity.Property(e => e.FechaRequerida)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Requerida");
            entity.Property(e => e.IdCliente).HasColumnName("ID_Cliente");
            entity.Property(e => e.Observaciones).HasColumnType("text");
            entity.Property(e => e.TotalPedido)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Total_Pedido");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PEDIDO__ID_Clien__628FA481");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.IdProducto).HasName("PK__PRODUCTO__9B4120E2A84C683A");

            entity.ToTable("PRODUCTO");

            entity.Property(e => e.IdProducto).HasColumnName("ID_Producto");
            entity.Property(e => e.CategoriaProducto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Categoria_Producto");
            entity.Property(e => e.EstadoProducto)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("Activo")
                .HasColumnName("Estado_Producto");
            entity.Property(e => e.NombreProducto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Nombre_Producto");
            entity.Property(e => e.Peso).HasColumnType("decimal(8, 3)");
            entity.Property(e => e.PrecioUnitario)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("Precio_Unitario");
            entity.Property(e => e.Volumen).HasColumnType("decimal(8, 3)");
        });

        modelBuilder.Entity<Ruta>(entity =>
        {
            entity.HasKey(e => e.IdRuta).HasName("PK__RUTA__4851E68BB68F13E3");

            entity.ToTable("RUTA");

            entity.Property(e => e.IdRuta).HasColumnName("ID_Ruta");
            entity.Property(e => e.DistanciaTotalKm)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("Distancia_Total_KM");
            entity.Property(e => e.EstadoRuta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("Planificada")
                .HasColumnName("Estado_Ruta");
            entity.Property(e => e.FechaRuta).HasColumnName("Fecha_Ruta");
            entity.Property(e => e.IdConductor).HasColumnName("ID_Conductor");
            entity.Property(e => e.IdVehiculo).HasColumnName("ID_Vehiculo");
            entity.Property(e => e.TiempoEstimadoMin).HasColumnName("Tiempo_Estimado_Min");
            entity.Property(e => e.TiempoRealMin).HasColumnName("Tiempo_Real_Min");

            entity.HasOne(d => d.IdConductorNavigation).WithMany(p => p.Ruta)
                .HasForeignKey(d => d.IdConductor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RUTA__ID_Conduct__787EE5A0");

            entity.HasOne(d => d.IdVehiculoNavigation).WithMany(p => p.Ruta)
                .HasForeignKey(d => d.IdVehiculo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RUTA__ID_Vehicul__778AC167");
        });

        modelBuilder.Entity<Sector>(entity =>
        {
            entity.HasKey(e => e.IdSector).HasName("PK__SECTOR__96D039B91C283EF5");

            entity.ToTable("SECTOR");

            entity.Property(e => e.IdSector).HasColumnName("ID_Sector");
            entity.Property(e => e.DensidadClientes).HasColumnName("Densidad_Clientes");
            entity.Property(e => e.NombreSector)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Nombre_Sector");
            entity.Property(e => e.TiempoPromedioEntrega).HasColumnName("Tiempo_Promedio_Entrega");
            entity.Property(e => e.ZonaCobertura)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Zona_Cobertura");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__USUARIO__DE4431C573C7BC46");

            entity.ToTable("USUARIO");

            entity.HasIndex(e => e.Username, "UQ__USUARIO__536C85E4FB87D2EF").IsUnique();

            entity.HasIndex(e => e.Email, "UQ__USUARIO__A9D105342B413B3D").IsUnique();

            entity.Property(e => e.IdUsuario).HasColumnName("ID_Usuario");
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EstadoUsuario)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("Activo")
                .HasColumnName("Estado_Usuario");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Creacion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PasswordHash)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Password_Hash");
            entity.Property(e => e.RolUsuario)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Rol_Usuario");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Vehiculo>(entity =>
        {
            entity.HasKey(e => e.IdVehiculo).HasName("PK__VEHICULO__FEFD7E33F9BBBEDF");

            entity.ToTable("VEHICULO");

            entity.HasIndex(e => e.Placa, "UQ__VEHICULO__8310F99D7A5CB5DF").IsUnique();

            entity.Property(e => e.IdVehiculo).HasColumnName("ID_Vehiculo");
            entity.Property(e => e.CapacidadPesoKg)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("Capacidad_Peso_KG");
            entity.Property(e => e.CapacidadVolumenM3)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("Capacidad_Volumen_M3");
            entity.Property(e => e.EstadoVehiculo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("Disponible")
                .HasColumnName("Estado_Vehiculo");
            entity.Property(e => e.GpsActivo)
                .HasDefaultValue(true)
                .HasColumnName("GPS_Activo");
            entity.Property(e => e.Modelo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Placa)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
