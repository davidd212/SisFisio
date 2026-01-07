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
            DtpFechaCita = new DateTimePicker();
            RdAsistio = new RadioButton();
            Rdproceso = new RadioButton();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            Nombre = new Label();
            TxtMotivo = new TextBox();
            panel1 = new Panel();
            Borrar = new PictureBox();
            Limpiar = new PictureBox();
            Guardar = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            Rdnoasistio = new RadioButton();
            RdCancelo = new RadioButton();
            label2 = new Label();
            label7 = new Label();
            DtpHoraCita = new DateTimePicker();
            CboPaciente = new ComboBox();
            CboEmpleado = new ComboBox();
            label8 = new Label();
            TxtFolio = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Borrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Limpiar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Guardar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // DtpFechaCita
            // 
            DtpFechaCita.Location = new Point(195, 225);
            DtpFechaCita.Name = "DtpFechaCita";
            DtpFechaCita.Size = new Size(271, 27);
            DtpFechaCita.TabIndex = 32;
            // 
            // RdAsistio
            // 
            RdAsistio.AutoSize = true;
            RdAsistio.Location = new Point(953, 292);
            RdAsistio.Name = "RdAsistio";
            RdAsistio.Size = new Size(74, 24);
            RdAsistio.TabIndex = 31;
            RdAsistio.TabStop = true;
            RdAsistio.Text = "Asistio";
            RdAsistio.UseVisualStyleBackColor = true;
            RdAsistio.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // Rdproceso
            // 
            Rdproceso.AutoSize = true;
            Rdproceso.Location = new Point(953, 262);
            Rdproceso.Name = "Rdproceso";
            Rdproceso.Size = new Size(102, 24);
            Rdproceso.TabIndex = 30;
            Rdproceso.TabStop = true;
            Rdproceso.Text = "En Proceso";
            Rdproceso.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Location = new Point(918, 225);
            label6.Name = "label6";
            label6.Size = new Size(212, 25);
            label6.TabIndex = 29;
            label6.Text = "Genero";
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Location = new Point(782, 130);
            label4.Name = "label4";
            label4.Size = new Size(117, 25);
            label4.TabIndex = 27;
            label4.Text = "FOLIO";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Location = new Point(88, 321);
            label3.Name = "label3";
            label3.Size = new Size(255, 25);
            label3.TabIndex = 25;
            label3.Text = "Paciente";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // Nombre
            // 
            Nombre.BackColor = SystemColors.ActiveCaption;
            Nombre.Location = new Point(71, 133);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(118, 25);
            Nombre.TabIndex = 21;
            Nombre.Text = "Motivo de Cita";
            // 
            // TxtMotivo
            // 
            TxtMotivo.Location = new Point(195, 130);
            TxtMotivo.Multiline = true;
            TxtMotivo.Name = "TxtMotivo";
            TxtMotivo.Size = new Size(212, 34);
            TxtMotivo.TabIndex = 20;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(Borrar);
            panel1.Controls.Add(Limpiar);
            panel1.Controls.Add(Guardar);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1180, 79);
            panel1.TabIndex = 19;
            // 
            // Borrar
            // 
            Borrar.Image = (Image)resources.GetObject("Borrar.Image");
            Borrar.Location = new Point(952, 23);
            Borrar.Name = "Borrar";
            Borrar.Size = new Size(48, 42);
            Borrar.SizeMode = PictureBoxSizeMode.Zoom;
            Borrar.TabIndex = 4;
            Borrar.TabStop = false;
            Borrar.Click += Borrar_Click;
            // 
            // Limpiar
            // 
            Limpiar.Image = (Image)resources.GetObject("Limpiar.Image");
            Limpiar.Location = new Point(1015, 23);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(48, 42);
            Limpiar.SizeMode = PictureBoxSizeMode.Zoom;
            Limpiar.TabIndex = 3;
            Limpiar.TabStop = false;
            Limpiar.Click += pictureBox4_Click;
            // 
            // Guardar
            // 
            Guardar.Image = (Image)resources.GetObject("Guardar.Image");
            Guardar.Location = new Point(898, 27);
            Guardar.Name = "Guardar";
            Guardar.Size = new Size(48, 38);
            Guardar.SizeMode = PictureBoxSizeMode.Zoom;
            Guardar.TabIndex = 2;
            Guardar.TabStop = false;
            Guardar.Click += Guardar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.buscar;
            pictureBox2.Location = new Point(1069, 19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(40, 27);
            label1.Name = "label1";
            label1.Size = new Size(242, 38);
            label1.TabIndex = 0;
            label1.Text = "SOLICITUD DE CITAS";
            // 
            // Rdnoasistio
            // 
            Rdnoasistio.AutoSize = true;
            Rdnoasistio.Location = new Point(953, 322);
            Rdnoasistio.Name = "Rdnoasistio";
            Rdnoasistio.Size = new Size(102, 24);
            Rdnoasistio.TabIndex = 33;
            Rdnoasistio.TabStop = true;
            Rdnoasistio.Text = "No Asisitio";
            Rdnoasistio.UseVisualStyleBackColor = true;
            // 
            // RdCancelo
            // 
            RdCancelo.AutoSize = true;
            RdCancelo.Location = new Point(952, 352);
            RdCancelo.Name = "RdCancelo";
            RdCancelo.Size = new Size(83, 24);
            RdCancelo.TabIndex = 34;
            RdCancelo.TabStop = true;
            RdCancelo.Text = "Cancelo";
            RdCancelo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 230);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 35;
            label2.Text = "Asigna un Fecha";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(504, 228);
            label7.Name = "label7";
            label7.Size = new Size(116, 20);
            label7.TabIndex = 36;
            label7.Text = "Asigna una hora";
            // 
            // DtpHoraCita
            // 
            DtpHoraCita.Format = DateTimePickerFormat.Time;
            DtpHoraCita.Location = new Point(626, 225);
            DtpHoraCita.Name = "DtpHoraCita";
            DtpHoraCita.Size = new Size(193, 27);
            DtpHoraCita.TabIndex = 37;
            // 
            // CboPaciente
            // 
            CboPaciente.FormattingEnabled = true;
            CboPaciente.Location = new Point(88, 345);
            CboPaciente.Name = "CboPaciente";
            CboPaciente.Size = new Size(255, 28);
            CboPaciente.TabIndex = 38;
            CboPaciente.SelectedIndexChanged += CboPaciente_SelectedIndexChanged;
            // 
            // CboEmpleado
            // 
            CboEmpleado.FormattingEnabled = true;
            CboEmpleado.Location = new Point(429, 345);
            CboEmpleado.Name = "CboEmpleado";
            CboEmpleado.Size = new Size(255, 28);
            CboEmpleado.TabIndex = 40;
            CboEmpleado.SelectedIndexChanged += CboEmpleado_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.BackColor = SystemColors.ActiveCaption;
            label8.Location = new Point(429, 321);
            label8.Name = "label8";
            label8.Size = new Size(255, 25);
            label8.TabIndex = 39;
            label8.Text = "Fisiooterapia";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // TxtFolio
            // 
            TxtFolio.Location = new Point(905, 124);
            TxtFolio.Multiline = true;
            TxtFolio.Name = "TxtFolio";
            TxtFolio.Size = new Size(212, 34);
            TxtFolio.TabIndex = 26;
            // 
            // FrmCitas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            Controls.Add(CboEmpleado);
            Controls.Add(label8);
            Controls.Add(CboPaciente);
            Controls.Add(DtpHoraCita);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(RdCancelo);
            Controls.Add(Rdnoasistio);
            Controls.Add(DtpFechaCita);
            Controls.Add(RdAsistio);
            Controls.Add(Rdproceso);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(TxtFolio);
            Controls.Add(label3);
            Controls.Add(Nombre);
            Controls.Add(TxtMotivo);
            Controls.Add(panel1);
            Name = "FrmCitas";
            Load += FrmCitas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Borrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Limpiar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Guardar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker DtpFechaCita;
        private RadioButton RdAsistio;
        private RadioButton Rdproceso;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label Nombre;
        private TextBox TxtMotivo;
        private Panel panel1;
        private PictureBox Borrar;
        private PictureBox Limpiar;
        private PictureBox Guardar;
        private PictureBox pictureBox2;
        private Label label1;
        private RadioButton Rdnoasistio;
        private RadioButton RdCancelo;
        private Label label2;
        private Label label7;
        private DateTimePicker DtpHoraCita;
        private ComboBox CboPaciente;
        private ComboBox CboEmpleado;
        private Label label8;
        private TextBox TxtFolio;
    }
}