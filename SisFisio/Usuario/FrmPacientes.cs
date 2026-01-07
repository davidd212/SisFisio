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

        void CargarDataGrid()
        {
            Negocio.Pacientes paciente = new Negocio.Pacientes();
            DataTable resultado = paciente.ConsultarTodos();
            DtPacientes.DataSource = resultado;
            DtPacientes.Columns["id_Pac"].Visible = false;
            DtPacientes.Columns["Nombre_Pac"].HeaderText = "Nombre Paciente";
            DtPacientes.Columns["ApellidoP_Pac"].HeaderText = "Apellido Paterno";
            DtPacientes.Columns["ApellidoM_Pac"].HeaderText = "Apellido Materno";
            DtPacientes.Columns["Telefono_Pac"].HeaderText = "Teléfono";
            DtPacientes.Columns["Fecha_Nacimiento"].HeaderText = "Fecha de Nacimiento";
            DtPacientes.Columns["Genero"].HeaderText = "Género";
        }

        private void FrmPacientes_Load(object sender, EventArgs e)
        {
            CargarDataGrid();
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

                Negocio.Pacientes paciente = new Negocio.Pacientes();


                paciente.Nombre_Pac = TxtNombre.Text;
                paciente.ApellidoP_Pac = TxtApellidoPa.Text;
                paciente.ApellidoM_Pac = TxtApellidoMa.Text;
                paciente.Telefono_Pac = TxtTelefono.Text;
                paciente.Fecha_Nacimiento = DtFecha.Value;
                paciente.Genero = RbMasculino.Checked ? "Masculino" : "Femenino";


                string resultado = paciente.Guardar();

                MessageBox.Show(resultado);
                limpiar();
                CargarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void eliminar_Click(object sender, EventArgs e)
        {

            try
            {
                Negocio.Pacientes paciente = new Negocio.Pacientes();
                paciente.id_Pac = Convert.ToInt32(DtPacientes.CurrentRow.Cells["id_Pac"].Value);

                string resultado = paciente.Eliminar();
                MessageBox.Show(resultado);

                limpiar();
                CargarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (DtPacientes.CurrentRow != null)
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
                    limpiar();
                    CargarDataGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                btnombre.Text = "Solo se permiten caracteres alfabeticos.";
                btnombre.ForeColor = Color.Red;
                btnombre.Visible = true;

            }
            else
            {
                btnombre.Visible = false;
            }
        }

        private void TxtApellidoPa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void TxtApellidoMa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Evento CellClick para cargar datos al seleccionar un registro
        private void DtPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DtPacientes.CurrentRow != null)
            {
                TxtNombre.Text = DtPacientes.CurrentRow.Cells["Nombre_Pac"].Value?.ToString() ?? "";
                TxtApellidoPa.Text = DtPacientes.CurrentRow.Cells["ApellidoP_Pac"].Value?.ToString() ?? "";
                TxtApellidoMa.Text = DtPacientes.CurrentRow.Cells["ApellidoM_Pac"].Value?.ToString() ?? "";
                TxtTelefono.Text = DtPacientes.CurrentRow.Cells["Telefono_Pac"].Value?.ToString() ?? "";

                if (DateTime.TryParse(DtPacientes.CurrentRow.Cells["Fecha_Nacimiento"].Value?.ToString(), out DateTime fecha))
                {
                    DtFecha.Value = fecha;
                }

                string genero = DtPacientes.CurrentRow.Cells["Genero"].Value?.ToString() ?? "";
                RbMasculino.Checked = genero == "Masculino";
                RbFemenino.Checked = genero == "Femenino";
            }
        }

        private void TxtApellidoMa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
