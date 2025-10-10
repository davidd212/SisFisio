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
    public partial class FrmPanel : Form
    {
        public FrmPanel()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked_2(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked_3(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked_4(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            FrmEmpleado Empleado = new FrmEmpleado();
            Empleado.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            CitasMedicas Medicas = new CitasMedicas();
            Medicas.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Pacientes pacientes = new Pacientes();
            pacientes.Show();
        }
    }
}
