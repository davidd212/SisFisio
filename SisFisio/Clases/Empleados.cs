using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace SisFisio.Clases
{
    public class Empleados
    {
        ConexionClase x = new ConexionClase();
        SqlConnection con = new SqlConnection();



        // CAMPOS
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

        

        // MÉTODO GUARDAR
        public string Guardar()
        {
            string msj = "";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spEmpleados", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del procedimiento
                cmd.Parameters.AddWithValue("@op", 1);
                cmd.Parameters.AddWithValue("@id_Emp", DBNull.Value);
                cmd.Parameters.AddWithValue("@Num_Emp", Num_Emp);
                cmd.Parameters.AddWithValue("@Nombre_Emp", Nombre_Emp);
                cmd.Parameters.AddWithValue("@ApellidoP_Emp", ApellidoP_Emp);
                cmd.Parameters.AddWithValue("@ApellidoM_Emp", ApellidoM_Emp);
                cmd.Parameters.AddWithValue("@Tipo_Empl", DBNull.Value); // el SP lo usa, pero la tabla tiene Tipo_Empl
                cmd.Parameters.AddWithValue("@Clave", Clave);
                cmd.Parameters.AddWithValue("@Telefono_Emp", Telefono_Emp);
                cmd.Parameters.AddWithValue("@CedulaProfesional", CedulaProfesional);
                cmd.Parameters.AddWithValue("@Especialidad", Especialidad);
                cmd.Parameters.AddWithValue("@Estatus_Emp", DBNull.Value);

                cmd.ExecuteNonQuery();
                con.Close();

                msj = "Empleado guardado correctamente.";
            }
            catch (Exception ex)
            {
                msj = "Error al guardar empleado: " + ex.Message;
            }
            return msj;
        }

        

        

        
    
}
    }
