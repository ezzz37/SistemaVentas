using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
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
            _connectionString = "Data Source=DESKTOP-IJ001PS;Initial Catalog=DBSISTEMA_VENTAS;Trust Server Certificate=True;Authentication=ActiveDirectoryIntegrated";
        }

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(_connectionString);
        }
    }
}