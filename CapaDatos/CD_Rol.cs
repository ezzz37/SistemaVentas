using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaEntidad;
using Microsoft.Data.SqlClient;
using System.Reflection;

namespace CapaDatos
{
    public class CD_Rol
    {
            public List<Rol> Listar()
            {
                List<Rol> lista = new List<Rol>();

                try
                {
                    using (SqlConnection oconexion = new Conexion().ObtenerConexion())
                    {
                        StringBuilder query = new StringBuilder();
                        query.AppendLine("SELECT idRol, Descripcion FROM ROL");

                        SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                        cmd.CommandType = CommandType.Text;

                        oconexion.Open();

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                lista.Add(new Rol()
                                {
                                    idRol = Convert.ToInt32(dr["idRol"]),
                                    Descripcion = dr["Descripcion"].ToString(),
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error en Listar(): {ex.Message}");
                    lista = new List<Rol>();
                }
                return lista;
            }
    }
}
