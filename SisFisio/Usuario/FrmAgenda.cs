using SisFisio.Negocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace SisFisio.Usuario
{
    public partial class FrmAgenda : Form
    {
        public FrmAgenda()
        {
            InitializeComponent();
        }

        private void FrmAgenda_Load(object sender, EventArgs e)
        {
            CargarCitas();
            CargarAgendas();
        }

        void CargarCitas()
        {
            try
            {
                Cita cita = new Cita();
                DataTable dt = cita.ConsultarTodos();

                CbCita.DataSource = null;
                CbCita.DataSource = dt;
                // Mostrar combinación de Folio y Motivo para identificar la cita
                if (dt.Columns.Contains("Folio") && dt.Columns.Contains("Motivo_Cita"))
                {
                    if (!dt.Columns.Contains("Display"))
                        dt.Columns.Add("Display", typeof(string));

                    foreach (DataRow row in dt.Rows)
                    {
                        string folio = row["Folio"]?.ToString() ?? "";
                        string motivo = row["Motivo_Cita"]?.ToString() ?? "";
                        row["Display"] = string.IsNullOrWhiteSpace(folio) ? motivo : $"{folio} - {motivo}";
                    }

                    CbCita.DisplayMember = "Display";
                }
                else if (dt.Columns.Contains("Motivo_Cita"))
                {
                    CbCita.DisplayMember = "Motivo_Cita";
                }
                else
                {
                    CbCita.DisplayMember = "id_Cita";
                }

                CbCita.ValueMember = "id_Cita";
                CbCita.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar citas: " + ex.Message);
            }
        }

        void CargarAgendas()
        {
            try
            {
                Agenda agenda = new Agenda();
                DataTable dt = agenda.ConsultarTodos();

                // Aquí puedes agregar un DataGridView si necesitas mostrar las agendas existentes
                // Por ahora solo cargamos para validar que funciona
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar agendas: " + ex.Message);
            }
        }

        void Limpiar()
        {
            TxtEvento.Clear();
            DtFecha.Value = DateTime.Now;
            Dthora.Value = DateTime.Now;
            CbCita.SelectedIndex = -1;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones
                if (string.IsNullOrWhiteSpace(TxtEvento.Text))
                {
                    MessageBox.Show("Ingrese el nombre del evento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (CbCita.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione una cita", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear objeto Agenda y asignar valores correctamente
                Agenda agenda = new Agenda();
                agenda.Nom_Evento = TxtEvento.Text.Trim();          // Nombre del evento (string)
                agenda.Fecha_Agenda = DtFecha.Value.Date;            // Fecha (DateTime)
                agenda.Hora_Agenda = Dthora.Value;                   // Hora (DateTime) - toma la hora del DateTimePicker
                agenda.id_Cita = Convert.ToInt32(CbCita.SelectedValue); // ID de la cita (int)

                // Guardar en BD
                string resultado = agenda.Guardar();
                MessageBox.Show(resultado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar y recargar
                Limpiar();
                CargarAgendas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
