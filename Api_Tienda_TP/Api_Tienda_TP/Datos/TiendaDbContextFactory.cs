using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Api_Tienda_TP.Datos
{
    public class TiendaDbContextFactory : IDesignTimeDbContextFactory<TiendaDbContext>
    {
        public TiendaDbContext CreateDbContext(string[] args)
        {
            // Construir la configuración manualmente, leyendo el appsettings.json
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())  // Directorio actual
                .AddJsonFile("appsettings.json")               // Leer appsettings.json
                .Build();

            // Obtener la cadena de conexión desde appsettings.json
            var connectionString = config.GetConnectionString("DefaultConnection");

            // Configurar el DbContext con la cadena de conexión de MySQL
            var optionsBuilder = new DbContextOptionsBuilder<TiendaDbContext>();
            optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 21)));

            return new TiendaDbContext(optionsBuilder.Options);
        }
    }
}