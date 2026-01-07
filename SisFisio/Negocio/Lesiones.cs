using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisFisio.Negocio
{
    public class Lesiones
    {
        public int id_Lesion;
        public int id_TipoLes;
        public string Nom_Les;
        public string Grado;
        public string Descrip_Les;

        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public Lesiones()
        {
            con.ConnectionString = x.Conexion;
        }

        public string Guardar()
        {
            string msj = "";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spLesiones", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@op", 2); // Insertar
                cmd.Parameters.AddWithValue("@id_Lesion", DBNull.Value);
                cmd.Parameters.AddWithValue("@id_TipoLes", id_TipoLes);
                cmd.Parameters.AddWithValue("@Nom_Les", Nom_Les);
                cmd.Parameters.AddWithValue("@Grado", string.IsNullOrWhiteSpace(Grado) ? (object)DBNull.Value : Grado);
                cmd.Parameters.AddWithValue("@Descrip_Les", string.IsNullOrWhiteSpace(Descrip_Les) ? (object)DBNull.Value : Descrip_Les);

                cmd.ExecuteNonQuery();
                msj = "LESIÓN GUARDADA CON ÉXITO";
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
                SqlCommand cmd = new SqlCommand("spLesiones", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@op", 3); // Modificar
                cmd.Parameters.AddWithValue("@id_Lesion", id_Lesion);
                cmd.Parameters.AddWithValue("@id_TipoLes", id_TipoLes);
                cmd.Parameters.AddWithValue("@Nom_Les", Nom_Les);
                cmd.Parameters.AddWithValue("@Grado", string.IsNullOrWhiteSpace(Grado) ? (object)DBNull.Value : Grado);
                cmd.Parameters.AddWithValue("@Descrip_Les", string.IsNullOrWhiteSpace(Descrip_Les) ? (object)DBNull.Value : Descrip_Les);

                cmd.ExecuteNonQuery();
                msj = "LESIÓN MODIFICADA CON ÉXITO";
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
                SqlCommand cmd = new SqlCommand("spLesiones", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@op", 4); // Eliminar
                cmd.Parameters.AddWithValue("@id_Lesion", id_Lesion);
                cmd.Parameters.AddWithValue("@id_TipoLes", DBNull.Value);
                cmd.Parameters.AddWithValue("@Nom_Les", DBNull.Value);
                cmd.Parameters.AddWithValue("@Grado", DBNull.Value);
                cmd.Parameters.AddWithValue("@Descrip_Les", DBNull.Value);

                cmd.ExecuteNonQuery();
                msj = "LESIÓN ELIMINADA CON ÉXITO";
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
                SqlCommand cmd = new SqlCommand("spLesiones", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@op", 1); // Consultar todos
                cmd.Parameters.AddWithValue("@id_Lesion", DBNull.Value);
                cmd.Parameters.AddWithValue("@id_TipoLes", DBNull.Value);
                cmd.Parameters.AddWithValue("@Nom_Les", DBNull.Value);
                cmd.Parameters.AddWithValue("@Grado", DBNull.Value);
                cmd.Parameters.AddWithValue("@Descrip_Les", DBNull.Value);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar lesiones: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
    }
}
