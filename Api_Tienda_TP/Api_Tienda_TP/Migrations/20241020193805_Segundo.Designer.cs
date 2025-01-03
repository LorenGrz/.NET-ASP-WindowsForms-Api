﻿// <auto-generated />
using System;
using Api_Tienda_TP.Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Api_Tienda_TP.Migrations
{
    [DbContext(typeof(TiendaDbContext))]
    [Migration("20241020193805_Segundo")]
    partial class Segundo
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Api_Tienda_TP.Modelos.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Api_Tienda_TP.Modelos.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("ProveedorID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProveedorID");

                    b.ToTable("Productos");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("Api_Tienda_TP.Modelos.Proveedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Proveedores");
                });

            modelBuilder.Entity("Api_Tienda_TP.Modelos.Venta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CantidadVendida")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Fecha")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdProducto")
                        .HasColumnType("int");

                    b.Property<decimal>("PrecioVenta")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int?>("ProdId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProdId");

                    b.ToTable("Ventas");
                });

            modelBuilder.Entity("Api_Tienda_TP.Modelos.ProductoAPilas", b =>
                {
                    b.HasBaseType("Api_Tienda_TP.Modelos.Producto");

                    b.Property<int>("CantPilas")
                        .HasColumnType("int");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.ToTable("ProductoAPilas");
                });

            modelBuilder.Entity("Api_Tienda_TP.Modelos.ProductoElectronico", b =>
                {
                    b.HasBaseType("Api_Tienda_TP.Modelos.Producto");

                    b.Property<bool>("Transformador")
                        .HasColumnType("tinyint(1)");

                    b.Property<decimal>("Voltaje")
                        .HasColumnType("decimal(65,30)");

                    b.ToTable("ProductoElectronico");
                });

            modelBuilder.Entity("Api_Tienda_TP.Modelos.Producto", b =>
                {
                    b.HasOne("Api_Tienda_TP.Modelos.Proveedor", "Proveedor")
                        .WithMany("Productos")
                        .HasForeignKey("ProveedorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proveedor");
                });

            modelBuilder.Entity("Api_Tienda_TP.Modelos.Venta", b =>
                {
                    b.HasOne("Api_Tienda_TP.Modelos.Producto", "Prod")
                        .WithMany()
                        .HasForeignKey("ProdId");

                    b.Navigation("Prod");
                });

            modelBuilder.Entity("Api_Tienda_TP.Modelos.ProductoAPilas", b =>
                {
                    b.HasOne("Api_Tienda_TP.Modelos.Producto", null)
                        .WithOne()
                        .HasForeignKey("Api_Tienda_TP.Modelos.ProductoAPilas", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Api_Tienda_TP.Modelos.ProductoElectronico", b =>
                {
                    b.HasOne("Api_Tienda_TP.Modelos.Producto", null)
                        .WithOne()
                        .HasForeignKey("Api_Tienda_TP.Modelos.ProductoElectronico", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Api_Tienda_TP.Modelos.Proveedor", b =>
                {
                    b.Navigation("Productos");
                });
#pragma warning restore 612, 618
        }
    }
}
