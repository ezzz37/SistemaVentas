using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace CapaDatos
{
    public class Conexion
    {
        private readonly string _connectionString;

        public Conexion()
        {
            var configuration = new ConfigurationBuilder()
                .AddUserSecrets<Conexion>()
                .Build();

            _connectionString = configuration.GetConnectionString("DefaultConnection");

            if (string.IsNullOrEmpty(_connectionString))
            {
                throw new InvalidOperationException("La cadena de conexión no esta configurada en UserSecrets.");
            }
        }

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
