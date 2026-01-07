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
    public partial class FrmTratamientos : Form
    {
        public FrmTratamientos()
        {
            InitializeComponent();
        }
        void CargarDataGrid()
        {
            Negocio.Tratamiento cat = new Negocio.Tratamiento();
            DgTratamiento.DataSource = cat.ConsultarTodos();
            DgTratamiento.Columns["id_trata"].Visible = false;
            DgTratamiento.Columns["Nombre_trata"].HeaderText = "Nombre Tratamiento";
            DgTratamiento.Columns["Descrip_Trata"].HeaderText = "Descripción de Tratamiento";

        }
        void limpiar()
        {
            TxtNombre.Clear();
            TxtDescripcion.Clear();
        }
        private void FrmTratamientos_Load(object sender, EventArgs e)
        {
            CargarDataGrid();
            limpiar();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                Negocio.Tratamiento cat = new Negocio.Tratamiento();
                cat.Nombre = TxtNombre.Text;
                cat.Descripcion = TxtDescripcion.Text;

                string resultado = cat.Guardar();
                MessageBox.Show(resultado);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
            CargarDataGrid();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DgTratamiento.CurrentRow != null)
                {
                    Negocio.Tratamiento cat = new Negocio.Tratamiento();
                    cat.id = Convert.ToInt32(DgTratamiento.CurrentRow.Cells["id_Trata"].Value);

                    string resultado = cat.Eliminar();
                    MessageBox.Show(resultado);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
            CargarDataGrid();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (DgTratamiento.CurrentRow != null)
            {
                TxtNombre.Text = DgTratamiento.CurrentRow.Cells["Nombre_Trata"].Value?.ToString();
                TxtDescripcion.Text = DgTratamiento.CurrentRow.Cells["Descrip_Trata"].Value?.ToString();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (DgTratamiento.CurrentRow != null)
                {
                    Negocio.Tratamiento cat = new Negocio.Tratamiento();
                    cat.id = Convert.ToInt32(DgTratamiento.CurrentRow.Cells["id_Trata"].Value);
                    cat.Nombre = TxtNombre.Text;
                    cat.Descripcion = TxtDescripcion.Text;

                    string resultado = cat.Modificar();
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

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                ctnombre.Text = "Solo se permiten caracteres alfabeticos.";
                ctnombre.ForeColor = Color.Red;
                ctnombre.Visible = true;
            }
            else
            {
                ctnombre.Visible = false;
            }
        }

        private void TxtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite letras, números, espacios y caracteres de control
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void DgTratamiento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Evento CellClick para cargar datos al seleccionar un registro
        private void DgTratamiento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DgTratamiento.CurrentRow != null)
            {
                TxtNombre.Text = DgTratamiento.CurrentRow.Cells["Nombre_trata"].Value?.ToString() ?? "";
                TxtDescripcion.Text = DgTratamiento.CurrentRow.Cells["Descrip_Trata"].Value?.ToString() ?? "";
            }
        }
    }
}
