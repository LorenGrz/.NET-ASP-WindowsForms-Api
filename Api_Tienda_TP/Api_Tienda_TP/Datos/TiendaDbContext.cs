using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProyectoCompartido; // Importa las entidades del dominio

namespace Api_Tienda_TP.Datos
{
    public class TiendaDbContext : DbContext
    {
        public TiendaDbContext(DbContextOptions<TiendaDbContext> options) : base(options)
        {

        }

        // DbSets para las entidades del dominio
        public DbSet<Producto> Productos { get; set; }
        public DbSet<ProductoElectronico> ProductosElectronicos { get; set; }
        public DbSet<ProductoAPilas> ProductosAPilas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Venta> Ventas { get; set; }


        // Configuraciones adicionales si son necesarias
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Producto>().ToTable("productos");
            //modelBuilder.Entity<ProductoElectronico>().ToTable("productoelectronico");
            //modelBuilder.Entity<ProductoAPilas>().ToTable("productoapilas");

            // Configurar la relación uno a muchos entre Proveedor y Producto
            //modelBuilder.Entity<Producto>()
            //    .HasOne(p => p.Proveedor)  // Un producto tiene un proveedor
            //    .WithMany()  // Un proveedor tiene muchos productos, pero no lo definimos explícitamente aquí
            //    .HasForeignKey(p => p.ProveedorID)  // Clave foránea en Producto
            //    .OnDelete(DeleteBehavior.Restrict);  // Evitar eliminación en cascada para proteger datos de proveedores

            //modelBuilder.Entity<Venta>()
            //    .HasOne(v => v.Producto)
            //    .WithMany()  // Si no tienes una colección de Ventas en Producto
            //    .HasForeignKey(v => v.IdProducto);


            base.OnModelCreating(modelBuilder);
        }
    }
}
