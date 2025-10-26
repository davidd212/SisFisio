namespace SisFisio.Fornularios
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            ListadoSesionCita = new Panel();
            label1 = new Label();
            DatosAgendapanel = new Panel();
            DatosAgendalabel = new Label();
            BuscarpictureBox = new PictureBox();
            BuscartextBox5 = new TextBox();
            BuscarpictureBox2 = new PictureBox();
            BuscartextBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ListadoSesionCita.SuspendLayout();
            DatosAgendapanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BuscarpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BuscarpictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightBlue;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(276, 700);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(293, 226);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(415, 193);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(762, 226);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(415, 193);
            dataGridView2.TabIndex = 2;
            // 
            // ListadoSesionCita
            // 
            ListadoSesionCita.BackColor = SystemColors.ActiveCaption;
            ListadoSesionCita.Controls.Add(label1);
            ListadoSesionCita.Location = new Point(320, 192);
            ListadoSesionCita.Name = "ListadoSesionCita";
            ListadoSesionCita.Size = new Size(355, 25);
            ListadoSesionCita.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(97, 3);
            label1.Name = "label1";
            label1.Size = new Size(133, 16);
            label1.TabIndex = 0;
            label1.Text = "Listado de sesion / citas";
            // 
            // DatosAgendapanel
            // 
            DatosAgendapanel.BackColor = SystemColors.ActiveCaption;
            DatosAgendapanel.Controls.Add(DatosAgendalabel);
            DatosAgendapanel.Location = new Point(789, 195);
            DatosAgendapanel.Name = "DatosAgendapanel";
            DatosAgendapanel.Size = new Size(355, 25);
            DatosAgendapanel.TabIndex = 6;
            // 
            // DatosAgendalabel
            // 
            DatosAgendalabel.AutoSize = true;
            DatosAgendalabel.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DatosAgendalabel.Location = new Point(116, 5);
            DatosAgendalabel.Name = "DatosAgendalabel";
            DatosAgendalabel.Size = new Size(104, 16);
            DatosAgendalabel.TabIndex = 0;
            DatosAgendalabel.Text = "Datos de agenda";
            // 
            // BuscarpictureBox
            // 
            BuscarpictureBox.BackColor = Color.FromArgb(0, 192, 192);
            BuscarpictureBox.Image = (Image)resources.GetObject("BuscarpictureBox.Image");
            BuscarpictureBox.Location = new Point(619, 135);
            BuscarpictureBox.Name = "BuscarpictureBox";
            BuscarpictureBox.Size = new Size(53, 27);
            BuscarpictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            BuscarpictureBox.TabIndex = 38;
            BuscarpictureBox.TabStop = false;
            // 
            // BuscartextBox5
            // 
            BuscartextBox5.Location = new Point(417, 135);
            BuscartextBox5.Name = "BuscartextBox5";
            BuscartextBox5.Size = new Size(205, 24);
            BuscartextBox5.TabIndex = 37;
            // 
            // BuscarpictureBox2
            // 
            BuscarpictureBox2.BackColor = Color.FromArgb(0, 192, 192);
            BuscarpictureBox2.Image = (Image)resources.GetObject("BuscarpictureBox2.Image");
            BuscarpictureBox2.Location = new Point(1086, 136);
            BuscarpictureBox2.Name = "BuscarpictureBox2";
            BuscarpictureBox2.Size = new Size(53, 27);
            BuscarpictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            BuscarpictureBox2.TabIndex = 40;
            BuscarpictureBox2.TabStop = false;
            // 
            // BuscartextBox1
            // 
            BuscartextBox1.Location = new Point(884, 136);
            BuscartextBox1.Name = "BuscartextBox1";
            BuscartextBox1.Size = new Size(205, 24);
            BuscartextBox1.TabIndex = 39;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 700);
            Controls.Add(BuscarpictureBox2);
            Controls.Add(BuscartextBox1);
            Controls.Add(BuscarpictureBox);
            Controls.Add(BuscartextBox5);
            Controls.Add(DatosAgendapanel);
            Controls.Add(ListadoSesionCita);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ListadoSesionCita.ResumeLayout(false);
            ListadoSesionCita.PerformLayout();
            DatosAgendapanel.ResumeLayout(false);
            DatosAgendapanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BuscarpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)BuscarpictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Panel ListadoSesionCita;
        private Label label1;
        private Panel DatosAgendapanel;
        private Label DatosAgendalabel;
        private PictureBox BuscarpictureBox;
        private TextBox BuscartextBox5;
        private PictureBox BuscarpictureBox2;
        private TextBox BuscartextBox1;
    }
}