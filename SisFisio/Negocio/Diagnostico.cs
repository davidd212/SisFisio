using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisFisio.Negocio
{
    public class Diagnostico
    {

        public int id_DetalleDiag;
        public string Tipo_Diag;
        public string Nombre_Diag;
        public int id_Lesion;
        public string RadioGrafia;
        public string Descrip_Diag;
        public int id_EscalaDolor;



        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public Diagnostico()
        {
            con.ConnectionString = x.Conexion;
        }


        public string Guardar()
        {
            string msj = "";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spDetalleDiag", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@op", 2);
                cmd.Parameters.AddWithValue("@id_DetalleDiag", DBNull.Value);
                cmd.Parameters.AddWithValue("@Tipo_Diag", Tipo_Diag);
                cmd.Parameters.AddWithValue("@Nombre_Diag", Nombre_Diag);
                cmd.Parameters.AddWithValue("@id_Lesion", id_Lesion);
                cmd.Parameters.AddWithValue("@RadioGrafia", string.IsNullOrWhiteSpace(RadioGrafia) ? (object)DBNull.Value : RadioGrafia);
                cmd.Parameters.AddWithValue("@Descrip_Diag", string.IsNullOrWhiteSpace(Descrip_Diag) ? (object)DBNull.Value : Descrip_Diag);
                cmd.Parameters.AddWithValue("@id_EscalaDolor", id_EscalaDolor);

                cmd.ExecuteNonQuery();
                msj = "DETALLE DE DIAGNÓSTICO GUARDADO CON ÉXITO";
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

        // ===============================
        // MODIFICAR
        // ===============================
        public string Modificar()
        {
            string msj = "";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spDetalleDiag", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@op", 3);
                cmd.Parameters.AddWithValue("@id_DetalleDiag", id_DetalleDiag);
                cmd.Parameters.AddWithValue("@Tipo_Diag", Tipo_Diag);
                cmd.Parameters.AddWithValue("@Nombre_Diag", Nombre_Diag);
                cmd.Parameters.AddWithValue("@id_Lesion", id_Lesion);
                cmd.Parameters.AddWithValue("@RadioGrafia", string.IsNullOrWhiteSpace(RadioGrafia) ? (object)DBNull.Value : RadioGrafia);
                cmd.Parameters.AddWithValue("@Descrip_Diag", string.IsNullOrWhiteSpace(Descrip_Diag) ? (object)DBNull.Value : Descrip_Diag);
                cmd.Parameters.AddWithValue("@id_EscalaDolor", id_EscalaDolor);

                cmd.ExecuteNonQuery();
                msj = "DETALLE DE DIAGNÓSTICO MODIFICADO CON ÉXITO";
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

        // ===============================
        // ELIMINAR
        // ===============================
        public string Eliminar()
        {
            string msj = "";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spDetalleDiag", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@op", 4);
                cmd.Parameters.AddWithValue("@id_DetalleDiag", id_DetalleDiag);
                cmd.Parameters.AddWithValue("@Tipo_Diag", DBNull.Value);
                cmd.Parameters.AddWithValue("@Nombre_Diag", DBNull.Value);
                cmd.Parameters.AddWithValue("@id_Lesion", DBNull.Value);
                cmd.Parameters.AddWithValue("@RadioGrafia", DBNull.Value);
                cmd.Parameters.AddWithValue("@Descrip_Diag", DBNull.Value);
                cmd.Parameters.AddWithValue("@id_EscalaDolor", DBNull.Value);

                cmd.ExecuteNonQuery();
                msj = "DETALLE DE DIAGNÓSTICO ELIMINADO CON ÉXITO";
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

        // ===============================
        // CONSULTAR TODOS
        // ===============================
        public DataTable ConsultarTodos()
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spDetalleDiag", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@op", 1);
                cmd.Parameters.AddWithValue("@id_DetalleDiag", DBNull.Value);
                cmd.Parameters.AddWithValue("@Tipo_Diag", DBNull.Value);
                cmd.Parameters.AddWithValue("@Nombre_Diag", DBNull.Value);
                cmd.Parameters.AddWithValue("@id_Lesion", DBNull.Value);
                cmd.Parameters.AddWithValue("@RadioGrafia", DBNull.Value);
                cmd.Parameters.AddWithValue("@Descrip_Diag", DBNull.Value);
                cmd.Parameters.AddWithValue("@id_EscalaDolor", DBNull.Value);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar detalle diagnóstico: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

    }
}

