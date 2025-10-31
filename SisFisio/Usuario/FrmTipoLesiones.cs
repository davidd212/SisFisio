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
    public partial class FrmTipoLesiones : Form
    {
        public FrmTipoLesiones()
        {
            InitializeComponent();
        }
        void limpiar()
        {
            TxtTipo.Clear();
        }
        void CargarDatos()
        {
            TipoLesiones tipo = new TipoLesiones();
            Dtbusqueda.DataSource = tipo.ConsultarTodos();
        }


        private void Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                TipoLesiones tipo = new TipoLesiones();
                tipo.Nom_TipoLes = TxtTipo.Text;

                string resultado = tipo.Guardar();
                MessageBox.Show(resultado);

                CargarDatos();
                limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void FrmTipoLesiones_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Dtbusqueda.CurrentRow != null)
                {
                    TipoLesiones tipo = new TipoLesiones();
                    tipo.id_TipoLes = Convert.ToInt32(Dtbusqueda.CurrentRow.Cells["id_TipoLes"].Value);
                    tipo.Nom_TipoLes = TxtTipo.Text;

                    string resultado = tipo.Modificar();
                    MessageBox.Show(resultado);

                    CargarDatos();
                    limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }

        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Dtbusqueda.CurrentRow != null)
                {
                    TipoLesiones tipo = new TipoLesiones();
                    tipo.id_TipoLes = Convert.ToInt32(Dtbusqueda.CurrentRow.Cells["id_TipoLes"].Value);

                    string resultado = tipo.Eliminar();
                    MessageBox.Show(resultado);

                    CargarDatos();
                    limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void Limpiarr_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
