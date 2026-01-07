using SisFisio.Negocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace SisFisio.Usuario
{
    public partial class FrmDiagnostico : Form
    {
        public FrmDiagnostico()
        {
            InitializeComponent();
        }

        private void FrmDiagnostico_Load(object sender, EventArgs e)
        {
            CargarDiagnosticos();
            CargarLesiones();
            CargarEscaladolor();
            CargarComplementarios();
        }

        void CargarComplementarios()
        {
            try
            {
                // Cargar Pacientes
                Pacientes p = new Pacientes();
                DataTable dtPacientes = p.ConsultarTodos();
                cbPaciente.DataSource = dtPacientes;
                cbPaciente.DisplayMember = "Nombre_Pac";
                cbPaciente.ValueMember = "id_Pac";
                cbPaciente.SelectedIndex = -1;

                // Cargar Ejercicios
                Ejercicio ejercicio = new Ejercicio();
                DataTable dtEjercicios = ejercicio.ConsultarTodos();
                cbejercicios.DataSource = dtEjercicios;
                cbejercicios.DisplayMember = "Nombre_Ejer";
                cbejercicios.ValueMember = "id_Ejercicio";
                cbejercicios.SelectedIndex = -1;

                // Cargar Consultorio
                Consultorio consul = new Consultorio();
                DataTable dtConsultorio = consul.ConsultarTodos();
                cbconsultorio.DataSource = dtConsultorio;
                cbconsultorio.DisplayMember = "Nombre_Consul";
                cbconsultorio.ValueMember = "id_Consul";
                cbconsultorio.SelectedIndex = -1;

                // Cargar Tipo de Lesiones
                TipoLesiones tipoLes = new TipoLesiones();
                DataTable dtTipoLes = tipoLes.ConsultarTodos();
                cbtipo.DataSource = dtTipoLes;
                cbtipo.DisplayMember = "Nom_TipoLes";
                cbtipo.ValueMember = "id_TipoLes";
                cbtipo.SelectedIndex = -1;

                // Cargar Nombre de Lesión (duplicado de comboBox7, pero lo dejamos por si está en uso)
                Lesiones lesiones = new Lesiones();
                DataTable dtLesiones = lesiones.ConsultarTodos();
                CbNombreLesion.DataSource = dtLesiones;
                CbNombreLesion.DisplayMember = "Nom_Les";
                CbNombreLesion.ValueMember = "id_Lesion";
                CbNombreLesion.SelectedIndex = -1;

                // Cargar Citas
                Cita cita = new Cita();
                DataTable dtCita = cita.ConsultarTodos();
                cbCita.DataSource = dtCita;
                cbCita.DisplayMember = "Motivo_Cita";
                cbCita.ValueMember = "id_Cita";
                cbCita.SelectedIndex = -1;

                // Cargar Empleados
                Empleado emp = new Empleado();
                DataTable dtEmpleados = emp.ConsultarTodos();
                cbNombrefiso.DataSource = dtEmpleados;
                cbNombrefiso.DisplayMember = "Nombre_Emp";
                cbNombrefiso.ValueMember = "id_Emp";
                cbNombrefiso.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos complementarios: " + ex.Message);
            }
        }

        void CargarDiagnosticos()
        {
            try
            {
                Diagnostico diag = new Diagnostico();
                DataTable dt = diag.ConsultarTodos();
                dataGridView1.DataSource = dt;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.BackgroundColor = this.BackColor;

                // Ocultar columnas innecesarias
                if (dataGridView1.Columns.Contains("id_DetalleDiag"))
                    dataGridView1.Columns["id_DetalleDiag"].Visible = false;
                if (dataGridView1.Columns.Contains("id_Diag"))
                    dataGridView1.Columns["id_Diag"].Visible = false;

                // Configurar encabezados si existen
                if (dataGridView1.Columns.Contains("Nombre_Diag"))
                    dataGridView1.Columns["Nombre_Diag"].HeaderText = "Nombre Diagnóstico";
                if (dataGridView1.Columns.Contains("Tipo_Diag"))
                    dataGridView1.Columns["Tipo_Diag"].HeaderText = "Tipo";
                if (dataGridView1.Columns.Contains("Descrip_Diag"))
                    dataGridView1.Columns["Descrip_Diag"].HeaderText = "Descripción";
                if (dataGridView1.Columns.Contains("RadioGrafia"))
                    dataGridView1.Columns["RadioGrafia"].HeaderText = "Radiografía";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar diagnósticos: " + ex.Message);
            }
        }

        void CargarLesiones()
        {
            try
            {
                Lesiones lesion = new Lesiones();
                DataTable dt = lesion.ConsultarTodos();

                // Limpiar comboBox7 antes de asignar
                comboBox7.DataSource = null;
                comboBox7.DataSource = dt;
                comboBox7.DisplayMember = "Nom_Les";
                comboBox7.ValueMember = "id_Lesion";
                comboBox7.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar lesiones: " + ex.Message);
            }
        }

        void CargarEscaladolor()
        {
            try
            {

                comboBox2.Items.Clear();
                comboBox2.Items.Add("Sin Dolor");
                comboBox2.Items.Add("Leve");
                comboBox2.Items.Add("Moderado");
                comboBox2.Items.Add("Fuerte");
                comboBox2.Items.Add("Extremo");
                comboBox2.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar escala de dolor: " + ex.Message);
            }
        }

        void Limpiar()
        {
            textBox4.Clear();      // Nombre Diag
            textBox2.Clear();      // Radiografia
            textBox3.Clear();      // Descripción
            comboBox7.SelectedIndex = -1;  // Lesión (PRINCIPAL)
            comboBox2.SelectedIndex = -1;  // Escala de dolor (PRINCIPAL)

            // Limpiar ComboBox que no se están usando pero están en el diseño
            cbPaciente.SelectedIndex = -1;
            cbejercicios.SelectedIndex = -1;
            cbNombrefiso.SelectedIndex = -1;
            cbconsultorio.SelectedIndex = -1;
            cbtipo.SelectedIndex = -1;
            CbNombreLesion.SelectedIndex = -1;
            cbCita.SelectedIndex = -1;

            radioButton1.Checked = false;  // Genérico
            radioButton2.Checked = false;  // Específico
            radioButton3.Checked = false;  // Sin Dolor
            radioButton4.Checked = false;  // Leve
            radioButton5.Checked = false;  // Moderado
            radioButton6.Checked = false;  // Fuerte
            radioButton7.Checked = false;  // Extremo
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {




                // Crear objeto diagnóstico y asignar valores
                Diagnostico diag = new Diagnostico();

                diag.Tipo_Diag = radioButton1.Checked ? "Genérico" : "Específico";
                diag.Nombre_Diag = textBox4.Text.Trim();
                diag.id_Lesion = Convert.ToInt32(comboBox7.SelectedValue);
                diag.RadioGrafia = textBox2.Text.Trim();
                diag.Descrip_Diag = textBox3.Text.Trim();
                diag.id_EscalaDolor = comboBox2.SelectedIndex + 1;  // Índice + 1 (1-5)

                // Guardar en BD
                string resultado = diag.Guardar();
                MessageBox.Show(resultado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar y recargar
                Limpiar();
                CargarDiagnosticos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar diagnóstico: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un diagnóstico de la tabla para modificar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validaciones
                if (string.IsNullOrWhiteSpace(textBox4.Text))
                {
                    MessageBox.Show("Ingrese el nombre del diagnóstico", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (comboBox7.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione una lesión", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!radioButton1.Checked && !radioButton2.Checked)
                {
                    MessageBox.Show("Seleccione un tipo de diagnóstico (Genérico o Específico)", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (comboBox2.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione una escala de dolor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear objeto diagnóstico con datos de la fila seleccionada
                Diagnostico diag = new Diagnostico();
                diag.id_DetalleDiag = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_DetalleDiag"].Value);

                diag.Tipo_Diag = radioButton1.Checked ? "Genérico" : "Específico";
                diag.Nombre_Diag = textBox4.Text.Trim();
                diag.id_Lesion = Convert.ToInt32(comboBox7.SelectedValue);
                diag.RadioGrafia = textBox2.Text.Trim();
                diag.Descrip_Diag = textBox3.Text.Trim();
                diag.id_EscalaDolor = comboBox2.SelectedIndex + 1;  // Índice + 1 (1-5)

                // Modificar en BD
                string resultado = diag.Modificar();
                MessageBox.Show(resultado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar y recargar
                Limpiar();
                CargarDiagnosticos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar diagnóstico: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un diagnóstico de la tabla para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Confirmación de eliminación
                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro que desea eliminar este diagnóstico?\nEsta acción no se puede deshacer.",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    Diagnostico diag = new Diagnostico();
                    diag.id_DetalleDiag = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_DetalleDiag"].Value);

                    string resultado = diag.Eliminar();
                    MessageBox.Show(resultado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar y recargar
                    Limpiar();
                    CargarDiagnosticos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar diagnóstico: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.CurrentRow != null)
            {
                try
                {
                    // Cargar campos de texto
                    textBox4.Text = dataGridView1.CurrentRow.Cells["Nombre_Diag"].Value?.ToString() ?? "";
                    textBox2.Text = dataGridView1.CurrentRow.Cells["RadioGrafia"].Value?.ToString() ?? "";
                    textBox3.Text = dataGridView1.CurrentRow.Cells["Descrip_Diag"].Value?.ToString() ?? "";

                    // Cargar tipo de diagnóstico
                    if (dataGridView1.CurrentRow.Cells["Tipo_Diag"].Value != null)
                    {
                        string tipo = dataGridView1.CurrentRow.Cells["Tipo_Diag"].Value.ToString();
                        radioButton1.Checked = tipo == "Genérico";
                        radioButton2.Checked = tipo == "Específico";
                    }

                    // Cargar lesión en comboBox7
                    if (dataGridView1.CurrentRow.Cells["id_Lesion"].Value != null && !dataGridView1.CurrentRow.Cells["id_Lesion"].Value.Equals(DBNull.Value))
                    {
                        int idLesion = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_Lesion"].Value);
                        comboBox7.SelectedValue = idLesion;
                    }

                    // Cargar escala de dolor usando RadioButtons y comboBox2
                    if (dataGridView1.CurrentRow.Cells["id_EscalaDolor"].Value != null && !dataGridView1.CurrentRow.Cells["id_EscalaDolor"].Value.Equals(DBNull.Value))
                    {
                        int escala = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_EscalaDolor"].Value);

                        // Deseleccionar todos primero
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        radioButton5.Checked = false;
                        radioButton6.Checked = false;
                        radioButton7.Checked = false;

                        // Seleccionar el correspondiente según el valor (1-5)
                        switch (escala)
                        {
                            case 1: radioButton3.Checked = true; break; // Sin Dolor
                            case 2: radioButton4.Checked = true; break; // Leve
                            case 3: radioButton5.Checked = true; break; // Moderado
                            case 4: radioButton6.Checked = true; break; // Fuerte
                            case 5: radioButton7.Checked = true; break; // Extremo
                        }

                        // También actualizar comboBox2
                        comboBox2.SelectedIndex = escala - 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message);
                }
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            // Sincronizar RadioButtons con comboBox2
            if (radioButton3.Checked) comboBox2.SelectedIndex = 0;      // Sin Dolor
            else if (radioButton4.Checked) comboBox2.SelectedIndex = 1; // Leve
            else if (radioButton5.Checked) comboBox2.SelectedIndex = 2; // Moderado
            else if (radioButton6.Checked) comboBox2.SelectedIndex = 3; // Fuerte
            else if (radioButton7.Checked) comboBox2.SelectedIndex = 4; // Extremo
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Botón para elaborar informe (implementar según necesidad)
            MessageBox.Show("Función de informe no implementada aún", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label14_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
