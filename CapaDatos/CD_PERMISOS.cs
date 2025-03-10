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
    public class CD_PERMISOS
    {
        public List<Permiso> Listar(int idusuario)
        {
            List<Permiso> lista = new List<Permiso>();

            try
            {
                using (SqlConnection oconexion = new Conexion().ObtenerConexion())
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.IdRol, p.NombreMenu from PERMISOS p");
                    query.AppendLine("inner join ROl r on r.IdRol = p.IdRol");
                    query.AppendLine("inner join USUARIO u on u.IdRol = r.IdRol");
                    query.AppendLine("where u.IdUsuario = @idusuario");


                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@idusuario", idusuario);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Permiso()
                            {
                                oRol = new Rol() { idRol = Convert.ToInt32(dr["idRol"]) },
                                NombreMenu = dr["NombreMenu"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en Listar(): {ex.Message}");
                lista = new List<Permiso>();
            }

            return lista;
        }
    }
}