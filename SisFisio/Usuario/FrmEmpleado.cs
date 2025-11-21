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
        void CargarDataGrid()
        {
            Negocio.Empleado cat = new Negocio.Empleado();
            DtEmpleados.DataSource = cat.ConsultarTodos();
        }
        void limpiar()
        {
            TxtNumero.Clear();
            TxtNombre.Clear();
            TxtApellidoMa.Clear();
            TxtApellidoPa.Clear();
            TxtCedula.Clear();
            TxtClave.Clear();
            TxtEspecialidades.Clear();
            TxtTelefono.Clear();

        }
        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            CargarDataGrid();
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
                limpiar();
                CargarDataGrid();
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
                if (DtEmpleados.CurrentRow != null)
                {
                    Negocio.Empleado emp = new Negocio.Empleado();
                    emp.id_Emp = Convert.ToInt32(DtEmpleados.CurrentRow.Cells["id_Emp"].Value);

                    string resultado = emp.Eliminar();
                    MessageBox.Show(resultado);

                    limpiar();
                    CargarDataGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }


        private void Limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (DtEmpleados.CurrentRow != null)
                {
                    Negocio.Empleado emp = new Negocio.Empleado();

                    emp.id_Emp = Convert.ToInt32(DtEmpleados.CurrentRow.Cells["id_Emp"].Value);
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

                    string resultado = emp.Modificar();
                    MessageBox.Show(resultado);

                    DtEmpleados.DataSource = emp.ConsultarTodos();
                    limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (DtEmpleados.CurrentRow != null)
            {
                TxtNombre.Text = DtEmpleados.CurrentRow.Cells["Nombre_Emp"].Value?.ToString();
            }
        }

        private void DtEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
