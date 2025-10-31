using Microsoft.Data.SqlClient;
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

namespace SisFisio.Fornularios
{
    public partial class FrmPacientes : Form
    {
        public FrmPacientes()
        {
            InitializeComponent();
        }
        void limpiar()
        {
            TxtNombre.Clear();
            TxtApellidoPa.Clear();
            TxtApellidoMa.Clear();
            TxtTelefono.Clear();
            DtFecha.Value = DateTime.Now;
            RbMasculino.Checked = false;
            RbFemenino.Checked = false;
        }

        private void FrmPacientes_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (DtPacientes.CurrentRow != null)
            {
                TxtNombre.Text = DtPacientes.CurrentRow.Cells["Nombre_Pac"].Value?.ToString();
                TxtApellidoPa.Text = DtPacientes.CurrentRow.Cells["ApellidoP_Pac"].Value?.ToString();
                TxtApellidoMa.Text = DtPacientes.CurrentRow.Cells["ApellidoM_Pac"].Value?.ToString();
                TxtTelefono.Text = DtPacientes.CurrentRow.Cells["Telefono_Pac"].Value?.ToString();

                if (DateTime.TryParse(DtPacientes.CurrentRow.Cells["Fecha_Nacimiento"].Value?.ToString(), out DateTime fecha))
                {
                    DtFecha.Value = fecha;
                }

                string genero = DtPacientes.CurrentRow.Cells["Genero"].Value?.ToString();
                RbMasculino.Checked = genero == "Masculino";
                RbFemenino.Checked = genero == "Femenino";
            }






        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear objeto
                Negocio.Pacientes paciente = new Negocio.Pacientes();

                // Asignar propiedades
                paciente.Nombre_Pac = TxtNombre.Text;
                paciente.ApellidoP_Pac = TxtApellidoPa.Text;
                paciente.ApellidoM_Pac = TxtApellidoMa.Text;
                paciente.Telefono_Pac = TxtTelefono.Text;
                paciente.Fecha_Nacimiento = DtFecha.Value;
                paciente.Genero = RbMasculino.Checked ? "Masculino" : "Femenino";

                DtPacientes.DataSource = paciente.ConsultarTodos();
                // Guardar
                string resultado = paciente.Guardar();

                MessageBox.Show(resultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            limpiar();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {

            try
            {
                Negocio.Pacientes paciente = new Negocio.Pacientes();
                paciente.id_Pac = Convert.ToInt32(DtPacientes.CurrentRow.Cells["id_Pac"].Value);

                string resultado = paciente.Eliminar();
                MessageBox.Show(resultado);

                // Recargar el DataGridView
                DtPacientes.DataSource = paciente.ConsultarTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Negocio.Pacientes paciente = new Negocio.Pacientes();
            DataTable resultado = paciente.ConsultarTodos();
            DtPacientes.DataSource = resultado;
            int idSeleccionado = Convert.ToInt32(DtPacientes.CurrentRow.Cells["id_Pac"].Value);

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {


            Negocio.Pacientes paciente = new Negocio.Pacientes();
            DataTable resultado = paciente.ConsultarTodos();
            DtPacientes.DataSource = resultado;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Negocio.Pacientes paciente = new Negocio.Pacientes();
            paciente.id_Pac = Convert.ToInt32(DtPacientes.CurrentRow.Cells["id_Pac"].Value);
            paciente.Nombre_Pac = TxtNombre.Text;
            paciente.ApellidoP_Pac = TxtApellidoPa.Text;
            paciente.ApellidoM_Pac = TxtApellidoMa.Text;
            paciente.Telefono_Pac = TxtTelefono.Text;
            paciente.Fecha_Nacimiento = DtFecha.Value;
            paciente.Genero = RbMasculino.Checked ? "Masculino" : "Femenino";

            string resultado = paciente.Modificar();
            MessageBox.Show(resultado);
            DtPacientes.DataSource = paciente.ConsultarTodos();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
