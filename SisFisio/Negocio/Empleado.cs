using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisFisio.Negocio
{
    public class Empleado
    {
        public int id_Emp;
        public int Num_Emp;
        public string Nombre_Emp;
        public string ApellidoP_Emp;
        public string ApellidoM_Emp;
        public string Tipo_Empl;
        public string Clave;
        public string Telefono_Emp;
        public string CedulaProfesional;
        public string Especialidad;
        public string Estatus_Emp;

        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public Empleado()
        {
            con.ConnectionString = x.Conexion;
        }

        public string Guardar()
        {
            string msj = "";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spEmpleados", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@op", 2);
                cmd.Parameters.AddWithValue("@id_Emp", DBNull.Value);
                cmd.Parameters.AddWithValue("@Num_Emp", Num_Emp);
                cmd.Parameters.AddWithValue("@Nombre_Emp", Nombre_Emp);
                cmd.Parameters.AddWithValue("@ApellidoP_Emp", ApellidoP_Emp);
                cmd.Parameters.AddWithValue("@ApellidoM_Emp", ApellidoM_Emp);
                cmd.Parameters.AddWithValue("@Tipo_Empl", Tipo_Empl);
                cmd.Parameters.AddWithValue("@Clave", Clave);
                cmd.Parameters.AddWithValue("@Telefono_Emp", Telefono_Emp);
                cmd.Parameters.AddWithValue("@CedulaProfesional", CedulaProfesional);
                cmd.Parameters.AddWithValue("@Especialidad", Especialidad);
                cmd.Parameters.AddWithValue("@Estatus_Emp", Estatus_Emp);

                cmd.ExecuteNonQuery();
                msj = "EMPLEADO GUARDADO CON ÉXITO";
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
                SqlCommand cmd = new SqlCommand("spEmpleados", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@op", 3);
                cmd.Parameters.AddWithValue("@id_Emp", id_Emp);
                cmd.Parameters.AddWithValue("@Num_Emp", Num_Emp);
                cmd.Parameters.AddWithValue("@Nombre_Emp", Nombre_Emp);
                cmd.Parameters.AddWithValue("@ApellidoP_Emp", ApellidoP_Emp);
                cmd.Parameters.AddWithValue("@ApellidoM_Emp", ApellidoM_Emp);
                cmd.Parameters.AddWithValue("@Tipo_Empl", Tipo_Empl);
                cmd.Parameters.AddWithValue("@Clave", Clave);
                cmd.Parameters.AddWithValue("@Telefono_Emp", Telefono_Emp);
                cmd.Parameters.AddWithValue("@CedulaProfesional", CedulaProfesional);
                cmd.Parameters.AddWithValue("@Especialidad", Especialidad);
                cmd.Parameters.AddWithValue("@Estatus_Emp", Estatus_Emp);

                cmd.ExecuteNonQuery();
                msj = "EMPLEADO MODIFICADO CON ÉXITO";
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
                SqlCommand cmd = new SqlCommand("spEmpleados", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@op", 4);
                cmd.Parameters.AddWithValue("@id_Emp", id_Emp);

                cmd.Parameters.AddWithValue("@Num_Emp", DBNull.Value);
                cmd.Parameters.AddWithValue("@Nombre_Emp", DBNull.Value);
                cmd.Parameters.AddWithValue("@ApellidoP_Emp", DBNull.Value);
                cmd.Parameters.AddWithValue("@ApellidoM_Emp", DBNull.Value);
                cmd.Parameters.AddWithValue("@Tipo_Empl", DBNull.Value);
                cmd.Parameters.AddWithValue("@Clave", DBNull.Value);
                cmd.Parameters.AddWithValue("@Telefono_Emp", DBNull.Value);
                cmd.Parameters.AddWithValue("@CedulaProfesional", DBNull.Value);
                cmd.Parameters.AddWithValue("@Especialidad", DBNull.Value);
                cmd.Parameters.AddWithValue("@Estatus_Emp", DBNull.Value);

                cmd.ExecuteNonQuery();
                msj = "EMPLEADO ELIMINADO CON ÉXITO";
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
                SqlCommand cmd = new SqlCommand("spEmpleados", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@op", 1);
                cmd.Parameters.AddWithValue("@id_Emp", DBNull.Value);
                cmd.Parameters.AddWithValue("@Num_Emp", DBNull.Value);
                cmd.Parameters.AddWithValue("@Nombre_Emp", DBNull.Value);
                cmd.Parameters.AddWithValue("@ApellidoP_Emp", DBNull.Value);
                cmd.Parameters.AddWithValue("@ApellidoM_Emp", DBNull.Value);
                cmd.Parameters.AddWithValue("@Tipo_Empl", DBNull.Value);
                cmd.Parameters.AddWithValue("@Clave", DBNull.Value);
                cmd.Parameters.AddWithValue("@Telefono_Emp", DBNull.Value);
                cmd.Parameters.AddWithValue("@CedulaProfesional", DBNull.Value);
                cmd.Parameters.AddWithValue("@Especialidad", DBNull.Value);
                cmd.Parameters.AddWithValue("@Estatus_Emp", DBNull.Value);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al consultar: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
    }
}

