using SisFisio.Fornularios;
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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            FrmEmpleado x = new FrmEmpleado();
            x.Show();
        }
        void CargarCitasMenu()
        {
            try
            {
                Cita cita = new Cita();
                DtCita.DataSource = cita.ConsultarTodos();
                
                // Configurar propiedades del DataGridView
                DtCita.AllowUserToAddRows = false;
                DtCita.RowHeadersVisible = false;
                DtCita.BackgroundColor = this.BackColor;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar citas: " + ex.Message);
            }
        }

        void CargarAgendaMenu()
        {
            try
            {
                Agenda agenda = new Agenda();
                dataGridView2.DataSource = agenda.ConsultarTodos();
                
                // Configurar propiedades del DataGridView
                dataGridView2.AllowUserToAddRows = false;
                dataGridView2.RowHeadersVisible = false;
                dataGridView2.BackgroundColor = this.BackColor;
                
                // Ocultar columnas innecesarias si existen
                if (dataGridView2.Columns.Contains("id_Agenda"))
                    dataGridView2.Columns["id_Agenda"].Visible = false;
                if (dataGridView2.Columns.Contains("id_Cita"))
                    dataGridView2.Columns["id_Cita"].Visible = false;
                
                // Configurar encabezados
                if (dataGridView2.Columns.Contains("Nom_Evento"))
                    dataGridView2.Columns["Nom_Evento"].HeaderText = "Evento";
                if (dataGridView2.Columns.Contains("Fecha_Agenda"))
                    dataGridView2.Columns["Fecha_Agenda"].HeaderText = "Fecha";
                if (dataGridView2.Columns.Contains("Hora_Agenda"))
                    dataGridView2.Columns["Hora_Agenda"].HeaderText = "Hora";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar agenda: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmPacientes x = new FrmPacientes();
            x.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmConsultorio x = new FrmConsultorio();
            x.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmCatEjercicios x = new FrmCatEjercicios();
            x.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmTratamientos x = new FrmTratamientos();
            x.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmLesiones x = new FrmLesiones();
            x.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmCitas x = new FrmCitas();
            x.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmAgenda x = new FrmAgenda();
            x.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FrmDiagnostico x = new FrmDiagnostico();
            x.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Botón INICIO - Abre el formulario de Reportes
            FrmReportes reportes = new FrmReportes();
            reportes.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            CargarCitasMenu();
            CargarAgendaMenu();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FrmEjercicios x = new FrmEjercicios();
            x.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
