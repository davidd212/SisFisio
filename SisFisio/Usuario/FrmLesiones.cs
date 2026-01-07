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
using SisFisio.Fornularios;

namespace SisFisio.Usuario
{
    public partial class FrmLesiones : Form
    {
        public FrmLesiones()
        {
            InitializeComponent();
        }

        // Método para cargar el DataGridView de Lesiones
        void CargarDataGridLesiones()
        {
            Lesiones lesion = new Lesiones();
            DgLesiones.DataSource = lesion.ConsultarTodos();
            DgLesiones.Columns["id_Lesion"].Visible = false;
            DgLesiones.Columns["id_TipoLes"].Visible = false;
            DgLesiones.Columns["Nom_Les"].HeaderText = "Nombre de Lesión";
            DgLesiones.Columns["Grado"].HeaderText = "Grado";
            DgLesiones.Columns["Descrip_Les"].HeaderText = "Descripción";

            DgLesiones.AllowUserToAddRows = false;
            DgLesiones.RowHeadersVisible = false;
            DgLesiones.BackgroundColor = this.BackColor;
        }

        // Método para cargar el DataGridView de Ejercicios asignados
        void CargarDataGridEjercicios()
        {
            Ejercicio ejercicio = new Ejercicio();
            DgEjercico.DataSource = ejercicio.ConsultarTodos();

            // Configurar columnas
            if (DgEjercico.Columns.Contains("id_Ejercicio"))
                DgEjercico.Columns["id_Ejercicio"].Visible = false;
            if (DgEjercico.Columns.Contains("id_catEjer"))
                DgEjercico.Columns["id_catEjer"].Visible = false;
            if (DgEjercico.Columns.Contains("Nombre_Ejer"))
                DgEjercico.Columns["Nombre_Ejer"].HeaderText = "Ejercicio";
            if (DgEjercico.Columns.Contains("Descrip_Ejer"))
                DgEjercico.Columns["Descrip_Ejer"].HeaderText = "Descripción";
            if (DgEjercico.Columns.Contains("Imag_Ejer"))
                DgEjercico.Columns["Imag_Ejer"].Visible = false;

            DgEjercico.AllowUserToAddRows = false;
            DgEjercico.RowHeadersVisible = false;
            DgEjercico.BackgroundColor = this.BackColor;
        }

        // Método para cargar el ComboBox de Tipos de Lesiones
        void CargarTipoLesiones()
        {
            try
            {
                TipoLesiones tipo = new TipoLesiones();
                DataTable dt = tipo.ConsultarTodos();

                CbLesion.DataSource = dt;
                CbLesion.DisplayMember = "Nom_TipoLes";
                CbLesion.ValueMember = "id_TipoLes";
                CbLesion.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tipos de lesiones: " + ex.Message);
            }
        }

        // Método para cargar el ComboBox de Categorías de Ejercicios
        void CargarCategoriaEjercicios()
        {
            try
            {
                CatEjercicio cat = new CatEjercicio();
                DataTable dt = cat.ConsultarTodos();

                cbcategoria.DataSource = dt;
                cbcategoria.DisplayMember = "Nombre_CatEjer";
                cbcategoria.ValueMember = "id_CatEjer";
                cbcategoria.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías de ejercicios: " + ex.Message);
            }
        }

        // Método para cargar ejercicios según la categoría seleccionada
        void CargarEjerciciosPorCategoria()
        {
            try
            {
                Ejercicio cat = new Ejercicio();
                DataTable dt = cat.ConsultarTodos();

                cbejercicio.DataSource = dt;
                cbejercicio.DisplayMember = "Nombre_Ejer";
                cbejercicio.ValueMember = "id_Ejercicio";
                cbejercicio.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías de ejercicios: " + ex.Message);
            }
        }

        // Método para limpiar los controles del formulario
        void Limpiar()
        {
            TxtNombre.Clear();
            TxtGrado.Clear();
            TxtDescripcion.Clear();
            CbLesion.SelectedIndex = -1;
        }

        private void FrmLesiones_Load(object sender, EventArgs e)
        {
            CargarDataGridLesiones();
            CargarDataGridEjercicios();
            CargarTipoLesiones();
            CargarCategoriaEjercicios();
        }

        // Botón Guardar (pictureBox3)
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxtNombre.Text))
                {
                    MessageBox.Show("Ingrese el nombre de la lesión", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (CbLesion.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un tipo de lesión", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Lesiones lesion = new Lesiones();
                lesion.id_TipoLes = Convert.ToInt32(CbLesion.SelectedValue);
                lesion.Nom_Les = TxtNombre.Text.Trim();
                lesion.Grado = TxtGrado.Text.Trim();
                lesion.Descrip_Les = TxtDescripcion.Text.Trim();

                string resultado = lesion.Guardar();
                MessageBox.Show(resultado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Limpiar();
                CargarDataGridLesiones();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón Eliminar (pictureBox5)
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            try
            {
                if (DgLesiones.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione una lesión para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro que desea eliminar esta lesión?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    Lesiones lesion = new Lesiones();
                    lesion.id_Lesion = Convert.ToInt32(DgLesiones.CurrentRow.Cells["id_Lesion"].Value);

                    string resultado = lesion.Eliminar();
                    MessageBox.Show(resultado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Limpiar();
                    CargarDataGridLesiones();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón Limpiar (pictureBox4)
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        // Botón Editar/Modificar (button1)
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (DgLesiones.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione una lesión para modificar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(TxtNombre.Text))
                {
                    MessageBox.Show("Ingrese el nombre de la lesión", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (CbLesion.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un tipo de lesión", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Lesiones lesion = new Lesiones();
                lesion.id_Lesion = Convert.ToInt32(DgLesiones.CurrentRow.Cells["id_Lesion"].Value);
                lesion.id_TipoLes = Convert.ToInt32(CbLesion.SelectedValue);
                lesion.Nom_Les = TxtNombre.Text.Trim();
                lesion.Grado = TxtGrado.Text.Trim();
                lesion.Descrip_Les = TxtDescripcion.Text.Trim();

                string resultado = lesion.Modificar();
                MessageBox.Show(resultado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Limpiar();
                CargarDataGridLesiones();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evento no utilizado pero requerido
        }

        // Evento CellClick del DataGridView de Lesiones
        private void DgPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgLesiones.CurrentRow != null)
            {
                TxtNombre.Text = DgLesiones.CurrentRow.Cells["Nom_Les"].Value?.ToString() ?? "";
                TxtGrado.Text = DgLesiones.CurrentRow.Cells["Grado"].Value?.ToString() ?? "";
                TxtDescripcion.Text = DgLesiones.CurrentRow.Cells["Descrip_Les"].Value?.ToString() ?? "";

                // Seleccionar el tipo de lesión en el combobox
                if (DgLesiones.CurrentRow.Cells["id_TipoLes"].Value != null)
                {
                    CbLesion.SelectedValue = Convert.ToInt32(DgLesiones.CurrentRow.Cells["id_TipoLes"].Value);
                }
            }
        }

        // Botón para administrar tipos de lesiones (button3)
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                FrmTipoLesiones frmTipo = new FrmTipoLesiones();
                frmTipo.ShowDialog();
                CargarTipoLesiones(); // Recargar el combo después de cerrar el formulario
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento cuando cambia la selección del combo de categorías
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarEjerciciosPorCategoria();
        }

        // Validación KeyPress para el nombre de la lesión (solo letras y espacios)
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        // Validación KeyPress para el grado (solo números)
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            // Evento no utilizado
        }

        // Botón AGREGAR - Abre el formulario de Ejercicios
        private void AGREGAR_Click(object sender, EventArgs e)
        {
            try
            {
                // Abrir el formulario de Ejercicios para agregar nuevos ejercicios
                FrmEjercicios frmEjercicios = new FrmEjercicios();
                frmEjercicios.ShowDialog();

                // Recargar el DataGridView de ejercicios después de cerrar el formulario
                CargarDataGridEjercicios();

                // También recargar el combo de ejercicios si hay una categoría seleccionada
                if (cbcategoria.SelectedIndex != -1)
                {
                    CargarEjerciciosPorCategoria();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario de ejercicios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evento no utilizado pero requerido
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
