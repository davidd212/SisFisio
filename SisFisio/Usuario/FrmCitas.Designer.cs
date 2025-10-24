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
            dateTimePicker1 = new DateTimePicker();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            Nombre = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            label2 = new Label();
            label7 = new Label();
            dateTimePicker2 = new DateTimePicker();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label8 = new Label();
            textBox4 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(195, 225);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(271, 27);
            dateTimePicker1.TabIndex = 32;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(953, 292);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(95, 24);
            radioButton2.TabIndex = 31;
            radioButton2.TabStop = true;
            radioButton2.Text = "Femenino";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(953, 262);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(97, 24);
            radioButton1.TabIndex = 30;
            radioButton1.TabStop = true;
            radioButton1.Text = "Masculino";
            radioButton1.UseVisualStyleBackColor = true;
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
            Nombre.Text = "Nombre de Cita";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(195, 130);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 34);
            textBox1.TabIndex = 20;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1180, 79);
            panel1.TabIndex = 19;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(952, 23);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(48, 42);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1015, 23);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(48, 42);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(898, 27);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
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
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(953, 322);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(102, 24);
            radioButton3.TabIndex = 33;
            radioButton3.TabStop = true;
            radioButton3.Text = "No Asisitio";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(952, 352);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(83, 24);
            radioButton4.TabIndex = 34;
            radioButton4.TabStop = true;
            radioButton4.Text = "Cancelo";
            radioButton4.UseVisualStyleBackColor = true;
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
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(626, 225);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(193, 27);
            dateTimePicker2.TabIndex = 37;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(88, 345);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(255, 28);
            comboBox1.TabIndex = 38;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(429, 345);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(255, 28);
            comboBox2.TabIndex = 40;
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
            // textBox4
            // 
            textBox4.Location = new Point(905, 124);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(212, 34);
            textBox4.TabIndex = 26;
            // 
            // FrmCitas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            Controls.Add(comboBox2);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker2);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(dateTimePicker1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(Nombre);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Name = "FrmCitas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dateTimePicker1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label Nombre;
        private TextBox textBox1;
        private Panel panel1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label1;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Label label2;
        private Label label7;
        private DateTimePicker dateTimePicker2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label8;
        private TextBox textBox4;
    }
}