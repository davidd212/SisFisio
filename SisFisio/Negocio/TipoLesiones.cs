using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisFisio.Negocio
{
   public  class TipoLesiones
    {
        public int id_TipoLes;
        public string Nom_TipoLes;

        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public TipoLesiones()
        {
            con.ConnectionString = x.Conexion;
        }

        public string Guardar()
        {
            string msj = "";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spTipoLesiones", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@op", 2); // Insertar
                cmd.Parameters.AddWithValue("@id_TipoLes", DBNull.Value); // autogenerado
                cmd.Parameters.AddWithValue("@Nom_TipoLes", Nom_TipoLes);

                cmd.ExecuteNonQuery();
                msj = "TIPO DE LESIÓN GUARDADO CON ÉXITO";
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
                SqlCommand cmd = new SqlCommand("spTipoLesiones", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@op", 3); // Modificar
                cmd.Parameters.AddWithValue("@id_TipoLes", id_TipoLes);
                cmd.Parameters.AddWithValue("@Nom_TipoLes", Nom_TipoLes);

                cmd.ExecuteNonQuery();
                msj = "TIPO DE LESIÓN MODIFICADO CON ÉXITO";
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
                SqlCommand cmd = new SqlCommand("spTipoLesiones", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@op", 4); // Eliminar
                cmd.Parameters.AddWithValue("@id_TipoLes", id_TipoLes);
                cmd.Parameters.AddWithValue("@Nom_TipoLes", DBNull.Value);

                cmd.ExecuteNonQuery();
                msj = "TIPO DE LESIÓN ELIMINADO CON ÉXITO";
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
                SqlCommand cmd = new SqlCommand("spTipoLesiones", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@op", 1); // Consultar todos
                cmd.Parameters.AddWithValue("@id_TipoLes", DBNull.Value);
                cmd.Parameters.AddWithValue("@Nom_TipoLes", DBNull.Value);

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
