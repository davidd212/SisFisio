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
    public partial class FrmCitas : Form
    {
        public FrmCitas()
        {
            InitializeComponent();
        }
        void CargarPacientes()
        {
            Pacientes p = new Pacientes();
            DataTable dt = p.ConsultarTodos();

            CboPaciente.DataSource = dt;
            CboPaciente.DisplayMember = "Nombre_Pac";   // o Nombre Completo si tú lo armas
            CboPaciente.ValueMember = "id_Pac";
            CboPaciente.SelectedIndex = -1;
        }
        void limpiar()
        {
            TxtFolio.Clear();
            TxtMotivo.Clear();
            CboEmpleado.SelectedIndex = -1;
            CboPaciente.SelectedIndex = -1;

        }
        void CargarEmpleados()
        {
            Empleado emp = new Empleado();
            DataTable dt = emp.ConsultarTodos();

            CboEmpleado.DataSource = dt;
            CboEmpleado.DisplayMember = "Nombre_Emp";
            CboEmpleado.ValueMember = "id_Emp";
            CboEmpleado.SelectedIndex = -1;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Guardar_Click(object sender, EventArgs e)
        {

            Cita cita = new Cita();
            cita.Folio = TxtFolio.Text;
            cita.Motivo_Cita = TxtMotivo.Text;
            cita.Fecha_Cita = DtpFechaCita.Value.Date;
            cita.Hora_Cita = DtpHoraCita.Value.ToString("HH:mm");
            cita.id_Pac = Convert.ToInt32(CboPaciente.SelectedValue);
            cita.id_Emp = Convert.ToInt32(CboEmpleado.SelectedValue);

            if (RdAsistio.Checked)
            {
                cita.Estatus_Cita = "Asistio";
            }
            else if (Rdproceso != null && Rdproceso.Checked)
            {
                cita.Estatus_Cita = "En proceso";
            }
            else if (Rdnoasistio != null && Rdnoasistio.Checked)
            {
                cita.Estatus_Cita = "No Asistio";
            }
            else if (RdCancelo != null && RdCancelo.Checked)
            {
                cita.Estatus_Cita = "Cancelo";
            }
            else
            {
                cita.Estatus_Cita = string.Empty;
            }

            string resultado = cita.Guardar();
            MessageBox.Show(resultado);
            limpiar();
        }

        private void CboEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmCitas_Load(object sender, EventArgs e)
        {
            CargarPacientes();
            CargarEmpleados();
        }

        private void Borrar_Click(object sender, EventArgs e)
        {

            try
            {


                Negocio.Cita cat = new Negocio.Cita();

                string resultado = cat.Eliminar();
                MessageBox.Show(resultado);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            limpiar();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }

}
