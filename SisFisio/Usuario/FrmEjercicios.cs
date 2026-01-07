using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SisFisio.Negocio;

namespace SisFisio.Fornularios
{
    public partial class FrmEjercicios : Form
    {
        private string rutaImagen = "";

        public FrmEjercicios()
        {
            InitializeComponent();
        }

        void CargarDataGrid()
        {
            Ejercicio ejercicio = new Ejercicio();
            dataGridView1.DataSource = ejercicio.ConsultarTodos();
            dataGridView1.Columns["id_Ejercicio"].Visible = false;
            dataGridView1.Columns["id_catEjer"].Visible = false;
            dataGridView1.Columns["Nombre_Ejer"].HeaderText = "Nombre del Ejercicio";
            dataGridView1.Columns["Imag_Ejer"].HeaderText = "Imagen";
            dataGridView1.Columns["Descrip_Ejer"].HeaderText = "Descripción";

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.BackgroundColor = this.BackColor;
        }

        void CargarCategorias()
        {
            try
            {
                CatEjercicio cat = new CatEjercicio();
                DataTable dt = cat.ConsultarTodos();

                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "Nombre_CatEjer";
                comboBox1.ValueMember = "id_CatEjer";
                comboBox1.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message);
            }
        }

        void Limpiar()
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox6.Clear();
            comboBox1.SelectedIndex = -1;
            rutaImagen = "";
            picImagen.Image = null;
        }

        void CargarImagen(string ruta)
        {
            try
            {
                if (!string.IsNullOrEmpty(ruta) && System.IO.File.Exists(ruta))
                {
                    picImagen.Image = Image.FromFile(ruta);
                }
                else
                {
                    picImagen.Image = null;
                }
            }
            catch (Exception ex)
            {
                picImagen.Image = null;
                MessageBox.Show("Error al cargar la imagen: " + ex.Message);
            }
        }

        private void FrmEjercicios_Load(object sender, EventArgs e)
        {

        }

        private void FrmEjercicios_Load_1(object sender, EventArgs e)
        {
            CargarDataGrid();
            CargarCategorias();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione una categoría");
                    return;
                }

                Ejercicio ejercicio = new Ejercicio();
                ejercicio.id_catEjer = Convert.ToInt32(comboBox1.SelectedValue);
                ejercicio.Nombre_Ejer = textBox2.Text;
                ejercicio.Descrip_Ejer = textBox3.Text;
                ejercicio.Imag_Ejer = rutaImagen;

                string resultado = ejercicio.Guardar();
                MessageBox.Show(resultado);

                Limpiar();
                CargarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    Ejercicio ejercicio = new Ejercicio();
                    ejercicio.id_Ejercicio = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_Ejercicio"].Value);

                    string resultado = ejercicio.Eliminar();
                    MessageBox.Show(resultado);

                    Limpiar();
                    CargarDataGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    if (comboBox1.SelectedIndex == -1)
                    {
                        MessageBox.Show("Seleccione una categoría");
                        return;
                    }

                    Ejercicio ejercicio = new Ejercicio();
                    ejercicio.id_Ejercicio = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_Ejercicio"].Value);
                    ejercicio.id_catEjer = Convert.ToInt32(comboBox1.SelectedValue);
                    ejercicio.Nombre_Ejer = textBox2.Text;
                    ejercicio.Descrip_Ejer = textBox3.Text;
                    ejercicio.Imag_Ejer = rutaImagen;

                    string resultado = ejercicio.Modificar();
                    MessageBox.Show(resultado);

                    Limpiar();
                    CargarDataGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                textBox2.Text = dataGridView1.CurrentRow.Cells["Nombre_Ejer"].Value?.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells["Descrip_Ejer"].Value?.ToString();
                rutaImagen = dataGridView1.CurrentRow.Cells["Imag_Ejer"].Value?.ToString() ?? "";
                textBox6.Text = rutaImagen;

                // Cargar y mostrar la imagen
                CargarImagen(rutaImagen);

                // Seleccionar la categoría en el combobox
                if (dataGridView1.CurrentRow.Cells["id_catEjer"].Value != null)
                {
                    comboBox1.SelectedValue = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_catEjer"].Value);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.Title = "Seleccionar imagen";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    rutaImagen = openFileDialog.FileName;
                    textBox6.Text = rutaImagen;

                    
                    CargarImagen(rutaImagen);

                    MessageBox.Show("Imagen cargada correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar imagen: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCatEjercicios frmCat = new FrmCatEjercicios();
                frmCat.ShowDialog();
                CargarCategorias();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void picImagen_Click(object sender, EventArgs e)
        {

        }
    }
}
