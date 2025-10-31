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
    public partial class FrmCatEjercicios : Form
    {
        public FrmCatEjercicios()
        {
            InitializeComponent();
        }
        void CargarDataGrid()
        {
            Negocio.CatEjercicio cat = new Negocio.CatEjercicio();
            DtCatEjercicio.DataSource = cat.ConsultarTodos();
        }
        void limpiar()
        {
            TxtNombre.Clear();
        }
        private void FrmCatEjercicios_Load(object sender, EventArgs e)
        {
            CargarDataGrid();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                Negocio.CatEjercicio cat = new Negocio.CatEjercicio();
                cat.Nombre_CatEjer = TxtNombre.Text;

                string resultado = cat.Guardar();
                MessageBox.Show(resultado);
                limpiar();
                CargarDataGrid();
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
                if (DtCatEjercicio.CurrentRow != null)
                {
                    Negocio.CatEjercicio cat = new Negocio.CatEjercicio();
                    cat.id_CatEjer = Convert.ToInt32(DtCatEjercicio.CurrentRow.Cells["id_CatEjer"].Value);

                    string resultado = cat.Eliminar();
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (DtCatEjercicio.CurrentRow != null)
                {
                    Negocio.CatEjercicio cat = new Negocio.CatEjercicio();
                    cat.id_CatEjer = Convert.ToInt32(DtCatEjercicio.CurrentRow.Cells["id_CatEjer"].Value);
                    cat.Nombre_CatEjer = TxtNombre.Text;

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (DtCatEjercicio.CurrentRow != null)
            {
                TxtNombre.Text = DtCatEjercicio.CurrentRow.Cells["Nombre_CatEjer"].Value?.ToString();
            }
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void DtCatEjercicio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DtCatEjercicio.CurrentRow != null)
            {
                TxtNombre.Text = DtCatEjercicio.CurrentRow.Cells["Nombre_CatEjer"].Value?.ToString();
            }
        }

        private void DtCatEjercicio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
