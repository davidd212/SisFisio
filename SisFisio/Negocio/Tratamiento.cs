using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisFisio.Negocio
{
    public class Tratamiento
    {
        public int id;
        public string Nombre;
        public string Descripcion;

        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public Tratamiento()
        {
            con.ConnectionString = x.Conexion;
        }

        public string Guardar()
        {
            string msj = "";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spTratamiento", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@op", 2);
                cmd.Parameters.AddWithValue("@id_Trata", DBNull.Value);
                cmd.Parameters.AddWithValue("@Nombre_Trata", Nombre);
                cmd.Parameters.AddWithValue("@Descrip_Trata", Descripcion);

                cmd.ExecuteNonQuery();
                msj = "TRATAMIENTO GUARDADA CON ÉXITO";
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
                SqlCommand cmd = new SqlCommand("spTratamiento", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@op", 3);
                cmd.Parameters.AddWithValue("@id_Trata", id);
                cmd.Parameters.AddWithValue("@Nombre_Trata", Nombre);
                cmd.Parameters.AddWithValue("@Descrip_Trata", Descripcion);

                cmd.ExecuteNonQuery();
                msj = "TRATAMIENTO MODIFICADO CON ÉXITO";
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

        public string Eliminar()
        {
            string msj = "";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spTratamiento", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@op", 4);
                cmd.Parameters.AddWithValue("@id_Trata", id);
                cmd.Parameters.AddWithValue("@Nombre_Trata", Nombre);
                cmd.Parameters.AddWithValue("@Descrip_Trata", Descripcion);

                cmd.ExecuteNonQuery();
                msj = "TRATAMIENTO ELIMANADO CON ÉXITO";
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
        public DataTable ConsultarTodos()
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spTratamiento ", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@op", 1);
                cmd.Parameters.AddWithValue("@id_Trata", DBNull.Value);
                cmd.Parameters.AddWithValue("@Nombre_Trata", Nombre);
                cmd.Parameters.AddWithValue("@Descrip_Trata", Descripcion);

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
