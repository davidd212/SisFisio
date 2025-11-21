using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisFisio.Negocio
{
    public class Cita
    {
        public int id_Cita;
        public string Folio;
        public string Motivo_Cita;
        public DateTime Fecha_Cita;
        public string Hora_Cita;      // lo mando como string "HH:mm"
        public int id_Pac;
        public int id_Emp;
        public string Estatus_Cita;

        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public Cita()
        {
            con.ConnectionString = x.Conexion;
        }

        public string Guardar()
        {

            string msj = "";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spCita", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@op", 2);          // Insertar
                cmd.Parameters.AddWithValue("@id_Cita", DBNull.Value);
                cmd.Parameters.AddWithValue("@Folio", Folio);
                cmd.Parameters.AddWithValue("@Motivo_Cita", Motivo_Cita);
                cmd.Parameters.AddWithValue("@Fecha_Cita", Fecha_Cita);
                cmd.Parameters.AddWithValue("@Hora_Cita", Hora_Cita);
                cmd.Parameters.AddWithValue("@id_Pac", id_Pac);
                cmd.Parameters.AddWithValue("@id_Emp", id_Emp);
                cmd.Parameters.AddWithValue("@Estatus_Cita", Estatus_Cita);
                

                cmd.ExecuteNonQuery();
                msj = "CITA GUARDADA CON ÉXITO";
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
                SqlCommand cmd = new SqlCommand("spCita", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@op", 3);          // Modificar
                cmd.Parameters.AddWithValue("@id_Cita", id_Cita);
                cmd.Parameters.AddWithValue("@Folio", Folio);
                cmd.Parameters.AddWithValue("@Motivo_Cita", Motivo_Cita);
                cmd.Parameters.AddWithValue("@Fecha_Cita", Fecha_Cita);
                cmd.Parameters.AddWithValue("@Hora_Cita", Hora_Cita);
                cmd.Parameters.AddWithValue("@id_Pac", id_Pac);
                cmd.Parameters.AddWithValue("@id_Emp", id_Emp);
                cmd.Parameters.AddWithValue("@Estatus_Cita", Estatus_Cita);

                cmd.ExecuteNonQuery();
                msj = "CITA MODIFICADA CON ÉXITO";
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
                SqlCommand cmd = new SqlCommand("spCita", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@op", 4);          // Eliminar
                cmd.Parameters.AddWithValue("@id_Cita", id_Cita);
                cmd.Parameters.AddWithValue("@Folio", DBNull.Value);
                cmd.Parameters.AddWithValue("@Motivo_Cita", DBNull.Value);
                cmd.Parameters.AddWithValue("@Fecha_Cita", DBNull.Value);
                cmd.Parameters.AddWithValue("@Hora_Cita", DBNull.Value);
                cmd.Parameters.AddWithValue("@id_Pac", DBNull.Value);
                cmd.Parameters.AddWithValue("@id_Emp", DBNull.Value);
                cmd.Parameters.AddWithValue("@Estatus_Cita", DBNull.Value);

                cmd.ExecuteNonQuery();
                msj = "CITA ELIMINADA CON ÉXITO";
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
                SqlCommand cmd = new SqlCommand("spCita", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@op", 1);          // Consultar todos
                cmd.Parameters.AddWithValue("@id_Cita", DBNull.Value);
                cmd.Parameters.AddWithValue("@Folio", DBNull.Value);
                cmd.Parameters.AddWithValue("@Motivo_Cita", DBNull.Value);
                cmd.Parameters.AddWithValue("@Fecha_Cita", DBNull.Value);
                cmd.Parameters.AddWithValue("@Hora_Cita", DBNull.Value);
                cmd.Parameters.AddWithValue("@id_Pac", DBNull.Value);
                cmd.Parameters.AddWithValue("@id_Emp", DBNull.Value);
                cmd.Parameters.AddWithValue("@Estatus_Cita", DBNull.Value);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar citas: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;

        }
    }
}
