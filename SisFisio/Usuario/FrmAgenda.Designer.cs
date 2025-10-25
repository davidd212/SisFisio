namespace SisFisio.Usuario
{
    partial class FrmAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgenda));
            HoradateTimePicker = new DateTimePicker();
            AsignaUnaHoralabel = new Label();
            AsignaUnaFechalabel = new Label();
            FechadateTimePicker = new DateTimePicker();
            EventoRegistrarLabel = new Label();
            NombretextBox = new TextBox();
            SolicitudDeCitasPanel = new Panel();
            EliminarpictureBox = new PictureBox();
            LimpiarpictureBox = new PictureBox();
            GuardarpictureBox = new PictureBox();
            BuscarpictureBox = new PictureBox();
            label1 = new Label();
            SolicitudDeCitasPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EliminarpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LimpiarpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GuardarpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BuscarpictureBox).BeginInit();
            SuspendLayout();
            // 
            // HoradateTimePicker
            // 
            HoradateTimePicker.Format = DateTimePickerFormat.Time;
            HoradateTimePicker.Location = new Point(485, 248);
            HoradateTimePicker.Margin = new Padding(3, 2, 3, 2);
            HoradateTimePicker.Name = "HoradateTimePicker";
            HoradateTimePicker.Size = new Size(169, 23);
            HoradateTimePicker.TabIndex = 55;
            // 
            // AsignaUnaHoralabel
            // 
            AsignaUnaHoralabel.AutoSize = true;
            AsignaUnaHoralabel.Location = new Point(378, 250);
            AsignaUnaHoralabel.Name = "AsignaUnaHoralabel";
            AsignaUnaHoralabel.Size = new Size(93, 15);
            AsignaUnaHoralabel.TabIndex = 54;
            AsignaUnaHoralabel.Text = "Asigna una hora";
            // 
            // AsignaUnaFechalabel
            // 
            AsignaUnaFechalabel.AutoSize = true;
            AsignaUnaFechalabel.Location = new Point(378, 210);
            AsignaUnaFechalabel.Name = "AsignaUnaFechalabel";
            AsignaUnaFechalabel.Size = new Size(94, 15);
            AsignaUnaFechalabel.TabIndex = 53;
            AsignaUnaFechalabel.Text = "Asigna un Fecha";
            // 
            // FechadateTimePicker
            // 
            FechadateTimePicker.Location = new Point(485, 206);
            FechadateTimePicker.Margin = new Padding(3, 2, 3, 2);
            FechadateTimePicker.Name = "FechadateTimePicker";
            FechadateTimePicker.Size = new Size(238, 23);
            FechadateTimePicker.TabIndex = 50;
            // 
            // EventoRegistrarLabel
            // 
            EventoRegistrarLabel.BackColor = SystemColors.ActiveCaption;
            EventoRegistrarLabel.Location = new Point(382, 158);
            EventoRegistrarLabel.Name = "EventoRegistrarLabel";
            EventoRegistrarLabel.Size = new Size(116, 26);
            EventoRegistrarLabel.TabIndex = 43;
            EventoRegistrarLabel.Text = "Evento  registrar";
            EventoRegistrarLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NombretextBox
            // 
            NombretextBox.Location = new Point(502, 158);
            NombretextBox.Margin = new Padding(3, 2, 3, 2);
            NombretextBox.Multiline = true;
            NombretextBox.Name = "NombretextBox";
            NombretextBox.Size = new Size(212, 26);
            NombretextBox.TabIndex = 42;
            // 
            // SolicitudDeCitasPanel
            // 
            SolicitudDeCitasPanel.BackColor = Color.Navy;
            SolicitudDeCitasPanel.Controls.Add(EliminarpictureBox);
            SolicitudDeCitasPanel.Controls.Add(LimpiarpictureBox);
            SolicitudDeCitasPanel.Controls.Add(GuardarpictureBox);
            SolicitudDeCitasPanel.Controls.Add(BuscarpictureBox);
            SolicitudDeCitasPanel.Controls.Add(label1);
            SolicitudDeCitasPanel.Location = new Point(1, 0);
            SolicitudDeCitasPanel.Margin = new Padding(3, 2, 3, 2);
            SolicitudDeCitasPanel.Name = "SolicitudDeCitasPanel";
            SolicitudDeCitasPanel.Size = new Size(1032, 59);
            SolicitudDeCitasPanel.TabIndex = 41;
            // 
            // EliminarpictureBox
            // 
            EliminarpictureBox.Image = (Image)resources.GetObject("EliminarpictureBox.Image");
            EliminarpictureBox.Location = new Point(833, 17);
            EliminarpictureBox.Margin = new Padding(3, 2, 3, 2);
            EliminarpictureBox.Name = "EliminarpictureBox";
            EliminarpictureBox.Size = new Size(42, 32);
            EliminarpictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            EliminarpictureBox.TabIndex = 4;
            EliminarpictureBox.TabStop = false;
            // 
            // LimpiarpictureBox
            // 
            LimpiarpictureBox.Image = (Image)resources.GetObject("LimpiarpictureBox.Image");
            LimpiarpictureBox.Location = new Point(888, 17);
            LimpiarpictureBox.Margin = new Padding(3, 2, 3, 2);
            LimpiarpictureBox.Name = "LimpiarpictureBox";
            LimpiarpictureBox.Size = new Size(42, 32);
            LimpiarpictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            LimpiarpictureBox.TabIndex = 3;
            LimpiarpictureBox.TabStop = false;
            // 
            // GuardarpictureBox
            // 
            GuardarpictureBox.Image = (Image)resources.GetObject("GuardarpictureBox.Image");
            GuardarpictureBox.Location = new Point(786, 20);
            GuardarpictureBox.Margin = new Padding(3, 2, 3, 2);
            GuardarpictureBox.Name = "GuardarpictureBox";
            GuardarpictureBox.Size = new Size(42, 28);
            GuardarpictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            GuardarpictureBox.TabIndex = 2;
            GuardarpictureBox.TabStop = false;
            // 
            // BuscarpictureBox
            // 
            BuscarpictureBox.Image = Properties.Resources.buscar;
            BuscarpictureBox.Location = new Point(935, 14);
            BuscarpictureBox.Margin = new Padding(3, 2, 3, 2);
            BuscarpictureBox.Name = "BuscarpictureBox";
            BuscarpictureBox.Size = new Size(42, 34);
            BuscarpictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            BuscarpictureBox.TabIndex = 1;
            BuscarpictureBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(35, 20);
            label1.Name = "label1";
            label1.Size = new Size(193, 30);
            label1.TabIndex = 0;
            label1.Text = "SOLICITUD DE CITAS";
            // 
            // FrmAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 490);
            Controls.Add(HoradateTimePicker);
            Controls.Add(AsignaUnaHoralabel);
            Controls.Add(AsignaUnaFechalabel);
            Controls.Add(FechadateTimePicker);
            Controls.Add(EventoRegistrarLabel);
            Controls.Add(NombretextBox);
            Controls.Add(SolicitudDeCitasPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmAgenda";
            Text = "FrmAgenda";
            SolicitudDeCitasPanel.ResumeLayout(false);
            SolicitudDeCitasPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EliminarpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)LimpiarpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)GuardarpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)BuscarpictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker HoradateTimePicker;
        private Label AsignaUnaHoralabel;
        private Label AsignaUnaFechalabel;
        private DateTimePicker FechadateTimePicker;
        private Label EventoRegistrarLabel;
        private TextBox NombretextBox;
        private Panel SolicitudDeCitasPanel;
        private PictureBox EliminarpictureBox;
        private PictureBox LimpiarpictureBox;
        private PictureBox GuardarpictureBox;
        private PictureBox BuscarpictureBox;
        private Label label1;
    }
}