using System;
using System.Collections.Generic;
using System.Data;
using CapaEntidad;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Usuario
    {
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();

            try
            {
                using (SqlConnection oconexion = new Conexion().ObtenerConexion())
                {
                    string query = "SELECT IdUsuario, Documento, NombreCompleto, Correo, Clave, Estado FROM usuario";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Usuario usuario = new Usuario()
                            {
                                IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                                Documento = dr["Documento"].ToString(),
                                NombreCompleto = dr["NombreCompleto"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                Clave = dr["Clave"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"])
                            };

                            lista.Add(usuario);
                            Console.WriteLine($"Usuario encontrado: {usuario.Documento} - {usuario.NombreCompleto}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en Listar(): {ex.Message}");
                lista = new List<Usuario>();
            }

            return lista;
        }
    }
}
