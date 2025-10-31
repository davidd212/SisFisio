using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisFisio.Negocio
{
    
        public class CatEjercicio
        {
            public int id_CatEjer;
            public string Nombre_CatEjer;

            ConexionSQL x = new ConexionSQL();
            SqlConnection con = new SqlConnection();

            public CatEjercicio()
            {
                con.ConnectionString = x.Conexion;
            }

            public string Guardar()
            {
                string msj = "";
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spCatEjercicio", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@op", 2);
                    cmd.Parameters.AddWithValue("@id_CatEjer", DBNull.Value);
                    cmd.Parameters.AddWithValue("@Nombre_CatEjer", Nombre_CatEjer);

                    cmd.ExecuteNonQuery();
                    msj = "CATEGORÍA GUARDADA CON ÉXITO";
                }
                catch (Exception ex)
                {
                    msj = "ERROR AL GUARDAR: " + ex.Message;
                }
                finally
                {
                    con.Close();
                }
                return msj;
            }

            public string Modificar()
            {
                string msj = "";
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spCatEjercicio", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@op", 3);
                    cmd.Parameters.AddWithValue("@id_CatEjer", id_CatEjer);
                    cmd.Parameters.AddWithValue("@Nombre_CatEjer", Nombre_CatEjer);

                    cmd.ExecuteNonQuery();
                    msj = "CATEGORÍA MODIFICADA CON ÉXITO";
                }
                catch (Exception ex)
                {
                    msj = "ERROR AL MODIFICAR: " + ex.Message;
                }
                finally
                {
                    con.Close();
                }
                return msj;
            }

            public string Eliminar()
            {
                string msj = "";
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spCatEjercicio", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@op", 4);
                    cmd.Parameters.AddWithValue("@id_CatEjer", id_CatEjer);

                    cmd.Parameters.AddWithValue("@Nombre_CatEjer", DBNull.Value);

                    cmd.ExecuteNonQuery();
                    msj = "CATEGORÍA ELIMINADA CON ÉXITO";
                }
                catch (Exception ex)
                {
                    msj = "ERROR AL ELIMINAR: " + ex.Message;
                }
                finally
                {
                    con.Close();
                }
                return msj;
            }

            public DataTable ConsultarTodos()
            {
                DataTable dt = new DataTable();
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spCatEjercicio", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@op", 1);
                    cmd.Parameters.AddWithValue("@id_CatEjer", DBNull.Value);
                    cmd.Parameters.AddWithValue("@Nombre_CatEjer", DBNull.Value);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al consultar: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
                return dt;
            }
        }
}
