using SisFisio.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisFisio.Usuario
{
    public partial class FrmEmpleado : Form
    {
        public FrmEmpleado()
        {
            InitializeComponent();
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                Empleado emp = new Empleado();
                emp.Num_Emp = Convert.ToInt32(TxtNumero.Text);
                emp.Nombre_Emp = TxtNombre.Text;
                emp.ApellidoP_Emp = TxtApellidoPa.Text;
                emp.ApellidoM_Emp = TxtApellidoMa.Text;
                emp.Tipo_Empl = RbFisio.Checked ? "Fisioterapeuta" : "Prestador de Servicio";
                emp.Clave = TxtClave.Text;
                emp.Telefono_Emp = TxtTelefono.Text;
                emp.CedulaProfesional = TxtCedula.Text;
                emp.Especialidad = TxtEspecialidades.Text;
                emp.Estatus_Emp = Rbinactiva.Checked ? "Activo" : "Inactivo";

                string resultado = emp.Guardar();
                MessageBox.Show(resultado);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void eliminar_Click(object sender, EventArgs e)
        {

            try
            {
                Empleado emp = new Empleado();

                string resultado = emp.Eliminar();
                MessageBox.Show(resultado);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }

        }
    }
}
