namespace SisFisio.Usuario
{
    partial class FrmCitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCitas));
            FechadateTimePicker = new DateTimePicker();
            FemeninoradioButton = new RadioButton();
            MasculinoradioButton = new RadioButton();
            Generolabel = new Label();
            Foliolabel = new Label();
            Pacientelabel = new Label();
            NombreCitaLabel = new Label();
            textBoxNombre1 = new TextBox();
            SolicitudDeCitaspanel = new Panel();
            EliminarpictureBox = new PictureBox();
            LimpiarpictureBox = new PictureBox();
            GuardarpictureBox = new PictureBox();
            BuscarpictureBox = new PictureBox();
            label1 = new Label();
            NoAsistioradioButton = new RadioButton();
            CanceloradioButton = new RadioButton();
            AsignaFechalabel = new Label();
            AsignaHoralabel = new Label();
            HoradateTimePicker = new DateTimePicker();
            PacientecomboBox = new ComboBox();
            FisioterapiacomboBox = new ComboBox();
            Fisioterapialabel = new Label();
            textBoxNombre4 = new TextBox();
            SolicitudDeCitaspanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EliminarpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LimpiarpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GuardarpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BuscarpictureBox).BeginInit();
            SuspendLayout();
            // 
            // FechadateTimePicker
            // 
            FechadateTimePicker.Location = new Point(171, 169);
            FechadateTimePicker.Margin = new Padding(3, 2, 3, 2);
            FechadateTimePicker.Name = "FechadateTimePicker";
            FechadateTimePicker.Size = new Size(238, 23);
            FechadateTimePicker.TabIndex = 32;
            // 
            // FemeninoradioButton
            // 
            FemeninoradioButton.AutoSize = true;
            FemeninoradioButton.Location = new Point(834, 219);
            FemeninoradioButton.Margin = new Padding(3, 2, 3, 2);
            FemeninoradioButton.Name = "FemeninoradioButton";
            FemeninoradioButton.Size = new Size(78, 19);
            FemeninoradioButton.TabIndex = 31;
            FemeninoradioButton.TabStop = true;
            FemeninoradioButton.Text = "Femenino";
            FemeninoradioButton.UseVisualStyleBackColor = true;
            FemeninoradioButton.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // MasculinoradioButton
            // 
            MasculinoradioButton.AutoSize = true;
            MasculinoradioButton.Location = new Point(834, 196);
            MasculinoradioButton.Margin = new Padding(3, 2, 3, 2);
            MasculinoradioButton.Name = "MasculinoradioButton";
            MasculinoradioButton.Size = new Size(80, 19);
            MasculinoradioButton.TabIndex = 30;
            MasculinoradioButton.TabStop = true;
            MasculinoradioButton.Text = "Masculino";
            MasculinoradioButton.UseVisualStyleBackColor = true;
            // 
            // Generolabel
            // 
            Generolabel.BackColor = SystemColors.ActiveCaption;
            Generolabel.Location = new Point(803, 169);
            Generolabel.Name = "Generolabel";
            Generolabel.Size = new Size(186, 19);
            Generolabel.TabIndex = 29;
            Generolabel.Text = "Genero";
            // 
            // Foliolabel
            // 
            Foliolabel.BackColor = SystemColors.ActiveCaption;
            Foliolabel.Location = new Point(684, 98);
            Foliolabel.Name = "Foliolabel";
            Foliolabel.Size = new Size(102, 19);
            Foliolabel.TabIndex = 27;
            Foliolabel.Text = "FOLIO";
            Foliolabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // Pacientelabel
            // 
            Pacientelabel.BackColor = SystemColors.ActiveCaption;
            Pacientelabel.Location = new Point(77, 241);
            Pacientelabel.Name = "Pacientelabel";
            Pacientelabel.Size = new Size(223, 19);
            Pacientelabel.TabIndex = 25;
            Pacientelabel.Text = "Paciente";
            Pacientelabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // NombreCitaLabel
            // 
            NombreCitaLabel.BackColor = SystemColors.ActiveCaption;
            NombreCitaLabel.Location = new Point(62, 100);
            NombreCitaLabel.Name = "NombreCitaLabel";
            NombreCitaLabel.Size = new Size(103, 19);
            NombreCitaLabel.TabIndex = 21;
            NombreCitaLabel.Text = "Nombre de Cita";
            // 
            // textBoxNombre1
            // 
            textBoxNombre1.Location = new Point(171, 98);
            textBoxNombre1.Margin = new Padding(3, 2, 3, 2);
            textBoxNombre1.Multiline = true;
            textBoxNombre1.Name = "textBoxNombre1";
            textBoxNombre1.Size = new Size(186, 26);
            textBoxNombre1.TabIndex = 20;
            // 
            // SolicitudDeCitaspanel
            // 
            SolicitudDeCitaspanel.BackColor = Color.Navy;
            SolicitudDeCitaspanel.Controls.Add(EliminarpictureBox);
            SolicitudDeCitaspanel.Controls.Add(LimpiarpictureBox);
            SolicitudDeCitaspanel.Controls.Add(GuardarpictureBox);
            SolicitudDeCitaspanel.Controls.Add(BuscarpictureBox);
            SolicitudDeCitaspanel.Controls.Add(label1);
            SolicitudDeCitaspanel.Location = new Point(0, 1);
            SolicitudDeCitaspanel.Margin = new Padding(3, 2, 3, 2);
            SolicitudDeCitaspanel.Name = "SolicitudDeCitaspanel";
            SolicitudDeCitaspanel.Size = new Size(1032, 59);
            SolicitudDeCitaspanel.TabIndex = 19;
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
            // NoAsistioradioButton
            // 
            NoAsistioradioButton.AutoSize = true;
            NoAsistioradioButton.Location = new Point(834, 242);
            NoAsistioradioButton.Margin = new Padding(3, 2, 3, 2);
            NoAsistioradioButton.Name = "NoAsistioradioButton";
            NoAsistioradioButton.Size = new Size(82, 19);
            NoAsistioradioButton.TabIndex = 33;
            NoAsistioradioButton.TabStop = true;
            NoAsistioradioButton.Text = "No Asisitio";
            NoAsistioradioButton.UseVisualStyleBackColor = true;
            // 
            // CanceloradioButton
            // 
            CanceloradioButton.AutoSize = true;
            CanceloradioButton.Location = new Point(833, 264);
            CanceloradioButton.Margin = new Padding(3, 2, 3, 2);
            CanceloradioButton.Name = "CanceloradioButton";
            CanceloradioButton.Size = new Size(68, 19);
            CanceloradioButton.TabIndex = 34;
            CanceloradioButton.TabStop = true;
            CanceloradioButton.Text = "Cancelo";
            CanceloradioButton.UseVisualStyleBackColor = true;
            // 
            // AsignaFechalabel
            // 
            AsignaFechalabel.AutoSize = true;
            AsignaFechalabel.Location = new Point(64, 172);
            AsignaFechalabel.Name = "AsignaFechalabel";
            AsignaFechalabel.Size = new Size(94, 15);
            AsignaFechalabel.TabIndex = 35;
            AsignaFechalabel.Text = "Asigna un Fecha";
            // 
            // AsignaHoralabel
            // 
            AsignaHoralabel.AutoSize = true;
            AsignaHoralabel.Location = new Point(441, 171);
            AsignaHoralabel.Name = "AsignaHoralabel";
            AsignaHoralabel.Size = new Size(93, 15);
            AsignaHoralabel.TabIndex = 36;
            AsignaHoralabel.Text = "Asigna una hora";
            // 
            // HoradateTimePicker
            // 
            HoradateTimePicker.Format = DateTimePickerFormat.Time;
            HoradateTimePicker.Location = new Point(548, 169);
            HoradateTimePicker.Margin = new Padding(3, 2, 3, 2);
            HoradateTimePicker.Name = "HoradateTimePicker";
            HoradateTimePicker.Size = new Size(169, 23);
            HoradateTimePicker.TabIndex = 37;
            // 
            // PacientecomboBox
            // 
            PacientecomboBox.FormattingEnabled = true;
            PacientecomboBox.Location = new Point(77, 259);
            PacientecomboBox.Margin = new Padding(3, 2, 3, 2);
            PacientecomboBox.Name = "PacientecomboBox";
            PacientecomboBox.Size = new Size(224, 23);
            PacientecomboBox.TabIndex = 38;
            // 
            // FisioterapiacomboBox
            // 
            FisioterapiacomboBox.FormattingEnabled = true;
            FisioterapiacomboBox.Location = new Point(375, 259);
            FisioterapiacomboBox.Margin = new Padding(3, 2, 3, 2);
            FisioterapiacomboBox.Name = "FisioterapiacomboBox";
            FisioterapiacomboBox.Size = new Size(224, 23);
            FisioterapiacomboBox.TabIndex = 40;
            // 
            // Fisioterapialabel
            // 
            Fisioterapialabel.BackColor = SystemColors.ActiveCaption;
            Fisioterapialabel.Location = new Point(375, 241);
            Fisioterapialabel.Name = "Fisioterapialabel";
            Fisioterapialabel.Size = new Size(223, 19);
            Fisioterapialabel.TabIndex = 39;
            Fisioterapialabel.Text = "Fisiooterapia";
            Fisioterapialabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxNombre4
            // 
            textBoxNombre4.Location = new Point(792, 93);
            textBoxNombre4.Margin = new Padding(3, 2, 3, 2);
            textBoxNombre4.Multiline = true;
            textBoxNombre4.Name = "textBoxNombre4";
            textBoxNombre4.Size = new Size(186, 26);
            textBoxNombre4.TabIndex = 26;
            // 
            // FrmCitas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 490);
            Controls.Add(FisioterapiacomboBox);
            Controls.Add(Fisioterapialabel);
            Controls.Add(PacientecomboBox);
            Controls.Add(HoradateTimePicker);
            Controls.Add(AsignaHoralabel);
            Controls.Add(AsignaFechalabel);
            Controls.Add(CanceloradioButton);
            Controls.Add(NoAsistioradioButton);
            Controls.Add(FechadateTimePicker);
            Controls.Add(FemeninoradioButton);
            Controls.Add(MasculinoradioButton);
            Controls.Add(Generolabel);
            Controls.Add(Foliolabel);
            Controls.Add(textBoxNombre4);
            Controls.Add(Pacientelabel);
            Controls.Add(NombreCitaLabel);
            Controls.Add(textBoxNombre1);
            Controls.Add(SolicitudDeCitaspanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmCitas";
            SolicitudDeCitaspanel.ResumeLayout(false);
            SolicitudDeCitaspanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EliminarpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)LimpiarpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)GuardarpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)BuscarpictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker FechadateTimePicker;
        private RadioButton FemeninoradioButton;
        private RadioButton MasculinoradioButton;
        private Label Generolabel;
        private Label Foliolabel;
        private Label Pacientelabel;
        private Label NombreCitaLabel;
        private TextBox textBoxNombre1;
        private Panel SolicitudDeCitaspanel;
        private PictureBox EliminarpictureBox;
        private PictureBox LimpiarpictureBox;
        private PictureBox GuardarpictureBox;
        private PictureBox BuscarpictureBox;
        private Label label1;
        private RadioButton NoAsistioradioButton;
        private RadioButton CanceloradioButton;
        private Label AsignaFechalabel;
        private Label AsignaHoralabel;
        private DateTimePicker HoradateTimePicker;
        private ComboBox PacientecomboBox;
        private ComboBox FisioterapiacomboBox;
        private Label Fisioterapialabel;
        private TextBox textBoxNombre4;
    }
}