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
    }
}
