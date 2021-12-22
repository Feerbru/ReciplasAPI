﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReciApis.Persistence.Context;

namespace ReciApis.Migrations
{
    [DbContext(typeof(AplicationDbContext))]
    [Migration("20211218211427_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ReciApis.Domain.Models.Articulo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PrecioUnitario")
                        .HasColumnType("float");

                    b.Property<double>("PrecioVenta")
                        .HasColumnType("float");

                    b.Property<int>("SectorId")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<int>("StockMinimo")
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UnidadMedidaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("SectorId");

                    b.HasIndex("UnidadMedidaId");

                    b.ToTable("Articulo");
                });

            modelBuilder.Entity("ReciApis.Domain.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("ReciApis.Domain.Models.DetallePedido", b =>
                {
                    b.Property<int>("CodigoPedidoId")
                        .HasColumnType("int");

                    b.Property<int>("ArticuloId")
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int?>("PedidoId")
                        .HasColumnType("int");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.HasKey("CodigoPedidoId", "ArticuloId");

                    b.HasIndex("ArticuloId");

                    b.HasIndex("PedidoId");

                    b.ToTable("DetallePedido");
                });

            modelBuilder.Entity("ReciApis.Domain.Models.EstadoCuenta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EstadoCuenta");
                });

            modelBuilder.Entity("ReciApis.Domain.Models.EstadoOc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EstadoOc");
                });

            modelBuilder.Entity("ReciApis.Domain.Models.EstadoPedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EstadoPedido");
                });

            modelBuilder.Entity("ReciApis.Domain.Models.Factura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("EsPagada")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<double>("Iva")
                        .HasColumnType("float");

                    b.Property<string>("NombreEmpresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PedidoId")
                        .HasColumnType("int");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId")
                        .IsUnique();

                    b.ToTable("Factura");
                });

            modelBuilder.Entity("ReciApis.Domain.Models.OrdenCompra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DireccionEntrega")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EstadoOcId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaEntrega")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProveedorId")
                        .HasColumnType("int");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EstadoOcId");

                    b.HasIndex("ProveedorId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("OrdenCompra");
                });

            modelBuilder.Entity("ReciApis.Domain.Models.OrdenCompraArticulo", b =>
                {
                    b.Property<int>("OrdenCompraId")
                        .HasColumnType("int");

                    b.Property<int>("ArticuloId")
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.HasKey("OrdenCompraId", "ArticuloId");

                    b.HasIndex("ArticuloId");

                    b.ToTable("OrdenCompraArticulo");
                });

            modelBuilder.Entity("ReciApis.Domain.Models.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EstadoPedidoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaEntrega")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("EstadoPedidoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("ReciApis.Domain.Models.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<int>("EstadoCuentaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("EstadoCuentaId");

                    b.ToTable("Persona");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("ReciApis.Domain.Models.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Rol");
                });

            modelBuilder.Entity("ReciApis.Domain.Models.Sector", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sector");
                });

            modelBuilder.Entity("ReciApis.Domain.Models.UnidadMedida", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UnidadMedida");
                });

            modelBuilder.Entity("ReciApis.Domain.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AdministraUsuarioId")
                        .HasColumnType("int");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("NombreAdmin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("RolId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AdministraUsuarioId");

                    b.HasIndex("RolId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("ReciApis.Domain.Models.Cliente", b =>
                {
                    b.HasBaseType("ReciApis.Domain.Models.Persona");

                    b.Property<string>("DNI")
                        .IsRequired()
                        .HasColumnType("varchar(8)");

                    b.HasDiscriminator().HasValue("Cliente");
                });

            modelBuilder.Entity("ReciApis.Domain.Models.Proveedor", b =>
                {
                    b.HasBaseType("ReciApis.Domain.Models.Persona");

                    b.Property<string>("CUIT")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("RazonSocial")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasDiscriminator().HasValue("Proveedor");
                });

            modelBuilder.Entity("ReciApis.Domain.Models.Articulo", b =>
                {
                    b.HasOne("ReciApis.Domain.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReciApis.Domain.Models.Sector", "Sector")
                        .WithMany()
                        .HasForeignKey("SectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReciApis.Domain.Models.UnidadMedida", "UnidadMedida")
                        .WithMany()
                        .HasForeignKey("UnidadMedidaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Sector");

                    b.Navigation("UnidadMedida");
                });

            modelBuilder.Entity("ReciApis.Domain.Models.DetallePedido", b =>
                {
                    b.HasOne("ReciApis.Domain.Models.Articulo", "Articulo")
                        .WithMany()
                        .HasForeignKey("ArticuloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReciApis.Domain.Models.Pedido", "Pedido")
                        .WithMany("DetalleFactura")
                        .HasForeignKey("PedidoId");

                    b.Navigation("Articulo");

                    b.Navigation("Pedido");
                });

            modelBuilder.Entity("ReciApis.Domain.Models.Factura", b =>
                {
                    b.HasOne("ReciApis.Domain.Models.Pedido", "Pedido")
                        .WithOne("Factura")
                        .HasForeignKey("ReciApis.Domain.Models.Factura", "PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pedido");
                });

            modelBuilder.Entity("ReciApis.Domain.Models.OrdenCompra", b =>
                {
                    b.HasOne("ReciApis.Domain.Models.EstadoOc", "EstadoOc")
                        .WithMany()
                        .HasForeignKey("EstadoOcId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReciApis.Domain.Models.Proveedor", "Proveedor")
                        .WithMany("OrdenCompra")
                        .HasForeignKey("ProveedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReciApis.Domain.Models.Usuario", "Usuario")
                        .WithMany("Ordenes")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EstadoOc");

                    b.Navigation("Proveedor");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ReciApis.Domain.Models.OrdenCompraArticulo", b =>
                {
                    b.HasOne("ReciApis.Domain.Models.Articulo", "Articulo")
                        .WithMany()
                        .HasForeignKey("ArticuloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReciApis.Domain.Models.OrdenCompra", "OrdenCompra")
                        .WithMany("OrdedeCompraArticulo")
                        .HasForeignKey("OrdenCompraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Articulo");

                    b.Navigation("OrdenCompra");
                });

            modelBuilder.Entity("ReciApis.Domain.Models.Pedido", b =>
                {
                    b.HasOne("ReciApis.Domain.Models.Cliente", "Cliente")
                        .WithMany("Pedido")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReciApis.Domain.Models.EstadoPedido", "EstadoPedido")
                        .WithMany("Pedido")
                        .HasForeignKey("EstadoPedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReciApis.Domain.Models.Usuario", "Usuario")
                        .WithMany("Pedido")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("EstadoPedido");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ReciApis.Domain.Models.Persona", b =>
                {
                    b.HasOne("ReciApis.Domain.Models.EstadoCuenta", "EstadoCuenta")
                        .WithMany()
                        .HasForeignKey("EstadoCuentaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EstadoCuenta");
                });

            modelBuilder.Entity("ReciApis.Domain.Models.Usuario", b =>
                {
                    b.HasOne("ReciApis.Domain.Models.Usuario", "UsuarioAdministra")
                        .WithMany()
                        .HasForeignKey("AdministraUsuarioId");

                    b.HasOne("ReciApis.Domain.Models.Rol", "Rol")
                        .WithMany()
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");

                    b.Navigation("UsuarioAdministra");
                });

            modelBuilder.Entity("ReciApis.Domain.Models.EstadoPedido", b =>
                {
                    b.Navigation("Pedido");
                });

            modelBuilder.Entity("ReciApis.Domain.Models.OrdenCompra", b =>
                {
                    b.Navigation("OrdedeCompraArticulo");
                });

            modelBuilder.Entity("ReciApis.Domain.Models.Pedido", b =>
                {
                    b.Navigation("DetalleFactura");

                    b.Navigation("Factura");
                });

            modelBuilder.Entity("ReciApis.Domain.Models.Usuario", b =>
                {
                    b.Navigation("Ordenes");

                    b.Navigation("Pedido");
                });

            modelBuilder.Entity("ReciApis.Domain.Models.Cliente", b =>
                {
                    b.Navigation("Pedido");
                });

            modelBuilder.Entity("ReciApis.Domain.Models.Proveedor", b =>
                {
                    b.Navigation("OrdenCompra");
                });
#pragma warning restore 612, 618
        }
    }
}