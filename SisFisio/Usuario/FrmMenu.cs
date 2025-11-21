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
            Cita cita = new Cita();
            DtCita.DataSource = cita.ConsultarTodos();
            
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

        }

        private void button11_Click(object sender, EventArgs e)
        {
            FrmDiagnostico x = new FrmDiagnostico();
            x.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
            DtCita.AllowUserToAddRows = false;
            DtCita.RowHeadersVisible = false;

            DtCita.AllowUserToAddRows = false;
            DtCita.RowHeadersVisible = false;

            
            DtCita.BackgroundColor = this.BackColor;
            DtCita.BackgroundColor = this.BackColor;



        }
    }
}
