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
            TxtEvento = new TextBox();
            Nombre = new Label();
            panel1 = new Panel();
            Borrar = new PictureBox();
            Guardar = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            DtFecha = new DateTimePicker();
            label3 = new Label();
            Dthora = new DateTimePicker();
            CbCita = new ComboBox();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Borrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Guardar).BeginInit();
            SuspendLayout();
            // 
            // TxtEvento
            // 
            TxtEvento.Location = new Point(541, 193);
            TxtEvento.Multiline = true;
            TxtEvento.Name = "TxtEvento";
            TxtEvento.Size = new Size(287, 37);
            TxtEvento.TabIndex = 55;
            // 
            // Nombre
            // 
            Nombre.BackColor = SystemColors.ActiveCaption;
            Nombre.Location = new Point(399, 198);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(136, 32);
            Nombre.TabIndex = 50;
            Nombre.Text = "Evento a Registrar";
            Nombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(Borrar);
            panel1.Controls.Add(Guardar);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1180, 79);
            panel1.TabIndex = 49;
            panel1.Paint += panel1_Paint;
            // 
            // Borrar
            // 
            Borrar.Image = (Image)resources.GetObject("Borrar.Image");
            Borrar.Location = new Point(999, 23);
            Borrar.Name = "Borrar";
            Borrar.Size = new Size(48, 42);
            Borrar.SizeMode = PictureBoxSizeMode.Zoom;
            Borrar.TabIndex = 4;
            Borrar.TabStop = false;
            Borrar.Click += Borrar_Click;
            // 
            // Guardar
            // 
            Guardar.Image = (Image)resources.GetObject("Guardar.Image");
            Guardar.Location = new Point(925, 23);
            Guardar.Name = "Guardar";
            Guardar.Size = new Size(48, 42);
            Guardar.SizeMode = PictureBoxSizeMode.Zoom;
            Guardar.TabIndex = 2;
            Guardar.TabStop = false;
            Guardar.Click += Guardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(62, 27);
            label1.Name = "label1";
            label1.Size = new Size(239, 38);
            label1.TabIndex = 0;
            label1.Text = "AGENDA PERSONAL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(399, 264);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 56;
            label2.Text = "Selecciona la Fecha";
            // 
            // DtFecha
            // 
            DtFecha.Location = new Point(541, 259);
            DtFecha.Name = "DtFecha";
            DtFecha.Size = new Size(287, 27);
            DtFecha.TabIndex = 57;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(399, 311);
            label3.Name = "label3";
            label3.Size = new Size(142, 20);
            label3.TabIndex = 58;
            label3.Text = "Selecciona una hora";
            // 
            // Dthora
            // 
            Dthora.Format = DateTimePickerFormat.Time;
            Dthora.Location = new Point(541, 306);
            Dthora.Name = "Dthora";
            Dthora.Size = new Size(287, 27);
            Dthora.TabIndex = 59;
            // 
            // CbCita
            // 
            CbCita.FormattingEnabled = true;
            CbCita.Location = new Point(541, 344);
            CbCita.Name = "CbCita";
            CbCita.Size = new Size(287, 28);
            CbCita.TabIndex = 60;
            CbCita.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(500, 344);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 61;
            label4.Text = "Cita";
            // 
            // FrmAgenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 498);
            Controls.Add(label4);
            Controls.Add(CbCita);
            Controls.Add(Dthora);
            Controls.Add(label3);
            Controls.Add(DtFecha);
            Controls.Add(label2);
            Controls.Add(TxtEvento);
            Controls.Add(Nombre);
            Controls.Add(panel1);
            Name = "FrmAgenda";
            Text = "FrmAgenda";
            Load += FrmAgenda_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Borrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Guardar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtEvento;
        private Label Nombre;
        private Panel panel1;
        private PictureBox Guardar;
        private Label label1;
        private PictureBox Borrar;
        private Label label2;
        private DateTimePicker DtFecha;
        private Label label3;
        private DateTimePicker Dthora;
        private ComboBox CbCita;
        private Label label4;
    }
}