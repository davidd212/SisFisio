using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisFisio.Negocio
{
    public class Pacientes
    {
        public int id_Pac;
        public string Nombre_Pac;
        public string ApellidoP_Pac;
        public string ApellidoM_Pac;
        public string Telefono_Pac;
        public DateTime Fecha_Nacimiento;
        public string Genero;

        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public Pacientes()
        {

            con.ConnectionString = x.Conexion;

        }
        public string Guardar()
        {
            string msj = "";

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spPacientes", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@op", 2); // Insertar
                cmd.Parameters.AddWithValue("@id_Pac", DBNull.Value); // se autogenera
                cmd.Parameters.AddWithValue("@Nombre_Pac", Nombre_Pac);
                cmd.Parameters.AddWithValue("@ApellidoP_Pac", ApellidoP_Pac);
                cmd.Parameters.AddWithValue("@ApellidoM_Pac", ApellidoM_Pac);
                cmd.Parameters.AddWithValue("@Telefono_Pac", Telefono_Pac);
                cmd.Parameters.AddWithValue("@Fecha_Nacimiento", Fecha_Nacimiento);
                cmd.Parameters.AddWithValue("@Genero", Genero);

                cmd.ExecuteNonQuery();
                msj = "PACIENTE GUARDADO CON ÉXITO";
            }
            catch (Exception ex)
            {
                msj = " ERROR AL GUARDAR: " + ex.Message;
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
                SqlCommand cmd = new SqlCommand("spPacientes", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@op", 3); // Modificar
                cmd.Parameters.AddWithValue("@id_Pac", id_Pac);
                cmd.Parameters.AddWithValue("@Nombre_Pac", Nombre_Pac);
                cmd.Parameters.AddWithValue("@ApellidoP_Pac", ApellidoP_Pac);
                cmd.Parameters.AddWithValue("@ApellidoM_Pac", ApellidoM_Pac);
                cmd.Parameters.AddWithValue("@Telefono_Pac", Telefono_Pac);
                cmd.Parameters.AddWithValue("@Fecha_Nacimiento", Fecha_Nacimiento);
                cmd.Parameters.AddWithValue("@Genero", Genero);

                cmd.ExecuteNonQuery();
                msj = "PACIENTE MODIFICADO CON ÉXITO";
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
                SqlCommand cmd = new SqlCommand("spPacientes", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@op", 4); // Eliminar
                cmd.Parameters.AddWithValue("@id_Pac", id_Pac);

                // Los demás parámetros no son necesarios
                
                cmd.Parameters.AddWithValue("@Nombre_Pac", DBNull.Value);
                cmd.Parameters.AddWithValue("@ApellidoP_Pac", DBNull.Value);
                cmd.Parameters.AddWithValue("@ApellidoM_Pac", DBNull.Value);
                cmd.Parameters.AddWithValue("@Telefono_Pac", DBNull.Value);
                cmd.Parameters.AddWithValue("@Fecha_Nacimiento", DBNull.Value);
                cmd.Parameters.AddWithValue("@Genero", DBNull.Value);

                cmd.ExecuteNonQuery();
                msj = "PACIENTE ELIMINADO CON ÉXITO";
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
                SqlCommand cmd = new SqlCommand("spPacientes", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@op", 1); // Consultar todos
                cmd.Parameters.AddWithValue("@id_Pac", DBNull.Value);
                cmd.Parameters.AddWithValue("@Nombre_Pac", DBNull.Value);
                cmd.Parameters.AddWithValue("@ApellidoP_Pac", DBNull.Value);
                cmd.Parameters.AddWithValue("@ApellidoM_Pac", DBNull.Value);
                cmd.Parameters.AddWithValue("@Telefono_Pac", DBNull.Value);
                cmd.Parameters.AddWithValue("@Fecha_Nacimiento", DBNull.Value);
                cmd.Parameters.AddWithValue("@Genero", DBNull.Value);

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
