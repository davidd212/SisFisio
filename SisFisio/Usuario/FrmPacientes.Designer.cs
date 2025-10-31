namespace SisFisio.Fornularios
{
    partial class FrmPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPacientes));
            panel1 = new Panel();
            eliminar = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            TxtNombre = new TextBox();
            Nombre = new Label();
            label2 = new Label();
            TxtApellidoPa = new TextBox();
            label3 = new Label();
            TxtTelefono = new TextBox();
            label4 = new Label();
            TxtApellidoMa = new TextBox();
            label5 = new Label();
            label6 = new Label();
            RbMasculino = new RadioButton();
            RbFemenino = new RadioButton();
            DtFecha = new DateTimePicker();
            DtPacientes = new DataGridView();
            button1 = new Button();
            textBox5 = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)eliminar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DtPacientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(eliminar);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1180, 79);
            panel1.TabIndex = 0;
            // 
            // eliminar
            // 
            eliminar.Image = (Image)resources.GetObject("eliminar.Image");
            eliminar.Location = new Point(952, 23);
            eliminar.Name = "eliminar";
            eliminar.Size = new Size(48, 42);
            eliminar.SizeMode = PictureBoxSizeMode.Zoom;
            eliminar.TabIndex = 4;
            eliminar.TabStop = false;
            eliminar.Click += eliminar_Click;
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
            pictureBox4.Click += pictureBox4_Click;
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
            pictureBox3.Click += pictureBox3_Click;
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
            label1.Location = new Point(34, 23);
            label1.Name = "label1";
            label1.Size = new Size(141, 38);
            label1.TabIndex = 0;
            label1.Text = "PACIENTES";
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(86, 161);
            TxtNombre.Multiline = true;
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(212, 34);
            TxtNombre.TabIndex = 1;
            // 
            // Nombre
            // 
            Nombre.BackColor = SystemColors.ActiveCaption;
            Nombre.Location = new Point(86, 133);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(212, 25);
            Nombre.TabIndex = 2;
            Nombre.Text = "Nombre";
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Location = new Point(86, 225);
            label2.Name = "label2";
            label2.Size = new Size(212, 25);
            label2.TabIndex = 4;
            label2.Text = "Apellido Paterno";
            // 
            // TxtApellidoPa
            // 
            TxtApellidoPa.Location = new Point(86, 253);
            TxtApellidoPa.Multiline = true;
            TxtApellidoPa.Name = "TxtApellidoPa";
            TxtApellidoPa.Size = new Size(212, 34);
            TxtApellidoPa.TabIndex = 3;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Location = new Point(86, 314);
            label3.Name = "label3";
            label3.Size = new Size(212, 25);
            label3.TabIndex = 6;
            label3.Text = "Telefono";
            // 
            // TxtTelefono
            // 
            TxtTelefono.Location = new Point(86, 342);
            TxtTelefono.Multiline = true;
            TxtTelefono.Name = "TxtTelefono";
            TxtTelefono.Size = new Size(212, 34);
            TxtTelefono.TabIndex = 5;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Location = new Point(319, 225);
            label4.Name = "label4";
            label4.Size = new Size(212, 25);
            label4.TabIndex = 8;
            label4.Text = "Apellido Materno";
            // 
            // TxtApellidoMa
            // 
            TxtApellidoMa.Location = new Point(319, 253);
            TxtApellidoMa.Multiline = true;
            TxtApellidoMa.Name = "TxtApellidoMa";
            TxtApellidoMa.Size = new Size(212, 34);
            TxtApellidoMa.TabIndex = 7;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Location = new Point(319, 314);
            label5.Name = "label5";
            label5.Size = new Size(212, 25);
            label5.TabIndex = 10;
            label5.Text = "Fecha de nacimiento";
            // 
            // label6
            // 
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Location = new Point(86, 403);
            label6.Name = "label6";
            label6.Size = new Size(212, 25);
            label6.TabIndex = 11;
            label6.Text = "Genero";
            // 
            // RbMasculino
            // 
            RbMasculino.AutoSize = true;
            RbMasculino.Location = new Point(121, 440);
            RbMasculino.Name = "RbMasculino";
            RbMasculino.Size = new Size(97, 24);
            RbMasculino.TabIndex = 12;
            RbMasculino.TabStop = true;
            RbMasculino.Text = "Masculino";
            RbMasculino.UseVisualStyleBackColor = true;
            // 
            // RbFemenino
            // 
            RbFemenino.AutoSize = true;
            RbFemenino.Location = new Point(121, 470);
            RbFemenino.Name = "RbFemenino";
            RbFemenino.Size = new Size(95, 24);
            RbFemenino.TabIndex = 13;
            RbFemenino.TabStop = true;
            RbFemenino.Text = "Femenino";
            RbFemenino.UseVisualStyleBackColor = true;
            // 
            // DtFecha
            // 
            DtFecha.Location = new Point(314, 340);
            DtFecha.Name = "DtFecha";
            DtFecha.Size = new Size(217, 27);
            DtFecha.TabIndex = 14;
            // 
            // DtPacientes
            // 
            DtPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtPacientes.Location = new Point(653, 176);
            DtPacientes.Name = "DtPacientes";
            DtPacientes.RowHeadersWidth = 51;
            DtPacientes.Size = new Size(467, 188);
            DtPacientes.TabIndex = 15;
            DtPacientes.CellClick += dataGridView1_CellContentClick;
            DtPacientes.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(653, 399);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 16;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(789, 130);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(211, 27);
            textBox5.TabIndex = 17;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(0, 192, 192);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(997, 130);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FrmPacientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            Controls.Add(pictureBox1);
            Controls.Add(textBox5);
            Controls.Add(button1);
            Controls.Add(DtPacientes);
            Controls.Add(DtFecha);
            Controls.Add(RbFemenino);
            Controls.Add(RbMasculino);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(TxtApellidoMa);
            Controls.Add(label3);
            Controls.Add(TxtTelefono);
            Controls.Add(label2);
            Controls.Add(TxtApellidoPa);
            Controls.Add(Nombre);
            Controls.Add(TxtNombre);
            Controls.Add(panel1);
            Name = "FrmPacientes";
            Load += FrmPacientes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)eliminar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)DtPacientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox TxtNombre;
        private Label Nombre;
        private Label label2;
        private TextBox TxtApellidoPa;
        private Label label3;
        private TextBox TxtTelefono;
        private Label label4;
        private TextBox TxtApellidoMa;
        private Label label5;
        private Label label6;
        private RadioButton RbMasculino;
        private RadioButton RbFemenino;
        private DateTimePicker DtFecha;
        private DataGridView DtPacientes;
        private Button button1;
        private TextBox textBox5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox eliminar;
        private PictureBox pictureBox4;
    }
}