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
    public partial class FrmConsultorio : Form
    {

        public FrmConsultorio()
        {
            InitializeComponent();
        }

        void Limpiar()
        {
            TxtNombre.Clear();
            TxtTelefono.Clear();
            TxtDireccion.Clear();
        }
        void CargarConsultorios()
        {
            Negocio.Consultorio consultorio = new Negocio.Consultorio();
            Dtbusqueda.DataSource = consultorio.ConsultarTodos();
            Dtbusqueda.Columns["id_Consul"].Visible = false;
            Dtbusqueda.Columns["Nombre_Consul"].HeaderText = "Nombre del Consultorio";
            Dtbusqueda.Columns["Telefono_Consul"].HeaderText = "Teléfono";
            Dtbusqueda.Columns["Direccion"].HeaderText = "Dirección";
        }

        private void FrmConsultorio_Load(object sender, EventArgs e)
        {
            CargarConsultorios();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                Negocio.Consultorio consultorio = new Negocio.Consultorio();
                consultorio.Nombre_Consul = TxtNombre.Text;
                consultorio.Telefono_Consul = TxtTelefono.Text;
                consultorio.Direccion = TxtDireccion.Text;

                string resultado = consultorio.Guardar();
                MessageBox.Show(resultado);

                Limpiar();
                CargarConsultorios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Dtbusqueda.CurrentRow != null)
                {
                    Negocio.Consultorio consultorio = new Negocio.Consultorio();
                    consultorio.id_Consul = Convert.ToInt32(Dtbusqueda.CurrentRow.Cells["id_Consul"].Value);

                    string resultado = consultorio.Eliminar();
                    MessageBox.Show(resultado);

                    Limpiar();
                    CargarConsultorios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void Limpiarm_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {

        }

        private void Dtbusqueda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dtbusqueda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Dtbusqueda.CurrentRow != null)
            {
                TxtNombre.Text = Dtbusqueda.CurrentRow.Cells["Nombre_Consul"].Value?.ToString();
                TxtTelefono.Text = Dtbusqueda.CurrentRow.Cells["Telefono_Consul"].Value?.ToString();
                TxtDireccion.Text = Dtbusqueda.CurrentRow.Cells["Direccion"].Value?.ToString();
            }
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Dtbusqueda.CurrentRow != null)
                {
                    Negocio.Consultorio consultorio = new Negocio.Consultorio();
                    consultorio.id_Consul = Convert.ToInt32(Dtbusqueda.CurrentRow.Cells["id_Consul"].Value);
                    consultorio.Nombre_Consul = TxtNombre.Text;
                    consultorio.Telefono_Consul = TxtTelefono.Text;
                    consultorio.Direccion = TxtDireccion.Text;

                    string resultado = consultorio.Modificar();
                    MessageBox.Show(resultado);

                    Limpiar();
                    CargarConsultorios();
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
            }
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
