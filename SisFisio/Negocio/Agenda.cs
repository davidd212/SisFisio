using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisFisio.Negocio
{
    public class Agenda
    {
        public int id;
        public string Evento;
        public DateTime Fecha;
        public DateTime Hora;

        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public Agenda()
        {
            con.ConnectionString = x.Conexion;
        }
        public string Guardar()
        {
            string msj = "";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spAgenda", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@op", 2);
                cmd.Parameters.AddWithValue("@id_Agenda", DBNull.Value);
                cmd.Parameters.AddWithValue("@Nom_Evento", Evento);
                cmd.Parameters.AddWithValue("@Fecha_Agenda", Fecha);
                cmd.Parameters.AddWithValue("@Hora", Hora);
                cmd.ExecuteNonQuery();
                msj = "EVENTO GUARDADO CON ÉXITO";
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
    }
}
