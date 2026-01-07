using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisFisio.Negocio
{
    public class Ejercicio
    {
        public int id_Ejercicio;
        public int id_catEjer;
        public string Nombre_Ejer;
        public string Imag_Ejer;
        public string Descrip_Ejer;

        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public Ejercicio()
        {
            con.ConnectionString = x.Conexion;
        }

        public string Guardar()
        {
            string msj = "";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spEjercicios", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@op", 2); // Insertar
                cmd.Parameters.AddWithValue("@id_Ejercicio", DBNull.Value);
                cmd.Parameters.AddWithValue("@id_catEjer", id_catEjer);
                cmd.Parameters.AddWithValue("@Nombre_Ejer", Nombre_Ejer);
                cmd.Parameters.AddWithValue("@Imag_Ejer", Imag_Ejer ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Descrip_Ejer", Descrip_Ejer ?? (object)DBNull.Value);

                cmd.ExecuteNonQuery();
                msj = "EJERCICIO GUARDADO CON ÉXITO";
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
                SqlCommand cmd = new SqlCommand("spEjercicios", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@op", 3); // Modificar
                cmd.Parameters.AddWithValue("@id_Ejercicio", id_Ejercicio);
                cmd.Parameters.AddWithValue("@id_catEjer", id_catEjer);
                cmd.Parameters.AddWithValue("@Nombre_Ejer", Nombre_Ejer);
                cmd.Parameters.AddWithValue("@Imag_Ejer", Imag_Ejer ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Descrip_Ejer", Descrip_Ejer ?? (object)DBNull.Value);

                cmd.ExecuteNonQuery();
                msj = "EJERCICIO MODIFICADO CON ÉXITO";
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
                SqlCommand cmd = new SqlCommand("spEjercicios", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@op", 4); // Eliminar
                cmd.Parameters.AddWithValue("@id_Ejercicio", id_Ejercicio);
                cmd.Parameters.AddWithValue("@id_catEjer", DBNull.Value);
                cmd.Parameters.AddWithValue("@Nombre_Ejer", DBNull.Value);
                cmd.Parameters.AddWithValue("@Imag_Ejer", DBNull.Value);
                cmd.Parameters.AddWithValue("@Descrip_Ejer", DBNull.Value);

                cmd.ExecuteNonQuery();
                msj = "EJERCICIO ELIMINADO CON ÉXITO";
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
                SqlCommand cmd = new SqlCommand("spEjercicios", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@op", 1); // Consultar todos
                cmd.Parameters.AddWithValue("@id_Ejercicio", DBNull.Value);
                cmd.Parameters.AddWithValue("@id_catEjer", DBNull.Value);
                cmd.Parameters.AddWithValue("@Nombre_Ejer", DBNull.Value);
                cmd.Parameters.AddWithValue("@Imag_Ejer", DBNull.Value);
                cmd.Parameters.AddWithValue("@Descrip_Ejer", DBNull.Value);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar ejercicios: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
    }
}
