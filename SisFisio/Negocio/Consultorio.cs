using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisFisio.Negocio
{
    class Consultorio
    {
        public int id_Consul;
        public string Nombre_Consul;
        public string Telefono_Consul;
        public string Direccion;

        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public Consultorio()
        {
            con.ConnectionString = x.Conexion;
        }

        public string Guardar()
        {
            string msj = "";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spConsultorio", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@op", 2); // Insertar
                cmd.Parameters.AddWithValue("@id_Consul", DBNull.Value); // autogenerado
                cmd.Parameters.AddWithValue("@Nombre_Consul", Nombre_Consul);
                cmd.Parameters.AddWithValue("@Telefono_Consul", Telefono_Consul);
                cmd.Parameters.AddWithValue("@Direccion", Direccion);

                cmd.ExecuteNonQuery();
                msj = "CONSULTORIO GUARDADO CON ÉXITO";
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
                SqlCommand cmd = new SqlCommand("spConsultorio", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@op", 3); // Modificar
                cmd.Parameters.AddWithValue("@id_Consul", id_Consul);
                cmd.Parameters.AddWithValue("@Nombre_Consul", Nombre_Consul);
                cmd.Parameters.AddWithValue("@Telefono_Consul", Telefono_Consul);
                cmd.Parameters.AddWithValue("@Direccion", Direccion);

                cmd.ExecuteNonQuery();
                msj = "CONSULTORIO MODIFICADO CON ÉXITO";
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
                SqlCommand cmd = new SqlCommand("spConsultorio", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@op", 4); // Eliminar
                cmd.Parameters.AddWithValue("@id_Consul", id_Consul);

                // No necesitamos los demás campos
                cmd.Parameters.AddWithValue("@Nombre_Consul", DBNull.Value);
                cmd.Parameters.AddWithValue("@Telefono_Consul", DBNull.Value);
                cmd.Parameters.AddWithValue("@Direccion", DBNull.Value);

                cmd.ExecuteNonQuery();
                msj = "CONSULTORIO ELIMINADO CON ÉXITO";
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
                SqlCommand cmd = new SqlCommand("spConsultorio", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@op", 1); // Consultar todos
                cmd.Parameters.AddWithValue("@id_Consul", DBNull.Value);
                cmd.Parameters.AddWithValue("@Nombre_Consul", DBNull.Value);
                cmd.Parameters.AddWithValue("@Telefono_Consul", DBNull.Value);
                cmd.Parameters.AddWithValue("@Direccion", DBNull.Value);

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
