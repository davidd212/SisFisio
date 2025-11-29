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
            TxtTipo = new TextBox();
            Nombre = new Label();
            panel1 = new Panel();
            Guardar = new PictureBox();
            label1 = new Label();
            Borrar = new PictureBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            DtpHoraCita = new DateTimePicker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Guardar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Borrar).BeginInit();
            SuspendLayout();
            // 
            // TxtTipo
            // 
            TxtTipo.Location = new Point(554, 225);
            TxtTipo.Multiline = true;
            TxtTipo.Name = "TxtTipo";
            TxtTipo.Size = new Size(287, 37);
            TxtTipo.TabIndex = 55;
            // 
            // Nombre
            // 
            Nombre.BackColor = SystemColors.ActiveCaption;
            Nombre.Location = new Point(412, 230);
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
            // Borrar
            // 
            Borrar.Image = (Image)resources.GetObject("Borrar.Image");
            Borrar.Location = new Point(999, 23);
            Borrar.Name = "Borrar";
            Borrar.Size = new Size(48, 42);
            Borrar.SizeMode = PictureBoxSizeMode.Zoom;
            Borrar.TabIndex = 4;
            Borrar.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(412, 296);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 56;
            label2.Text = "Selecciona la Fecha";
            label2.Click += label2_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(554, 291);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(287, 27);
            dateTimePicker1.TabIndex = 57;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(412, 343);
            label3.Name = "label3";
            label3.Size = new Size(142, 20);
            label3.TabIndex = 58;
            label3.Text = "Selecciona una hora";
            // 
            // DtpHoraCita
            // 
            DtpHoraCita.Format = DateTimePickerFormat.Time;
            DtpHoraCita.Location = new Point(554, 338);
            DtpHoraCita.Name = "DtpHoraCita";
            DtpHoraCita.Size = new Size(287, 27);
            DtpHoraCita.TabIndex = 59;
            // 
            // FrmAgenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 498);
            Controls.Add(DtpHoraCita);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(TxtTipo);
            Controls.Add(Nombre);
            Controls.Add(panel1);
            Name = "FrmAgenda";
            Text = "FrmAgenda";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Guardar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Borrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtTipo;
        private Label Nombre;
        private Panel panel1;
        private PictureBox Guardar;
        private Label label1;
        private PictureBox Borrar;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private DateTimePicker DtpHoraCita;
    }
}