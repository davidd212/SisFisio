namespace SisFisio.Usuario
{
    partial class FrmEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleado));
            pictureBox1 = new PictureBox();
            textBox5 = new TextBox();
            button1 = new Button();
            DtEmpleados = new DataGridView();
            RbPrestador = new RadioButton();
            RbFisio = new RadioButton();
            label6 = new Label();
            label4 = new Label();
            TxtApellidoPa = new TextBox();
            label3 = new Label();
            TxtCedula = new TextBox();
            label2 = new Label();
            TxtNombre = new TextBox();
            Nombre = new Label();
            TxtNumero = new TextBox();
            panel1 = new Panel();
            eliminar = new PictureBox();
            Limpiar = new PictureBox();
            Guardar = new PictureBox();
            Buscar = new PictureBox();
            label1 = new Label();
            label7 = new Label();
            TxtApellidoMa = new TextBox();
            RbActiva = new RadioButton();
            Rbinactiva = new RadioButton();
            label8 = new Label();
            label9 = new Label();
            TxtEspecialidades = new TextBox();
            TxtClave = new TextBox();
            label10 = new Label();
            label11 = new Label();
            TxtTelefono = new TextBox();
            groupBox1 = new GroupBox();
            lblAvisoNumero = new Label();
            ctnombre = new Label();
            ctClave = new Label();
            ctcedula = new Label();
            ctEspecialidades = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DtEmpleados).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)eliminar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Limpiar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Guardar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Buscar).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(0, 192, 192);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1032, 116);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(824, 116);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(211, 27);
            textBox5.TabIndex = 35;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(752, 405);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 34;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // DtEmpleados
            // 
            DtEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtEmpleados.Location = new Point(752, 162);
            DtEmpleados.Name = "DtEmpleados";
            DtEmpleados.RowHeadersWidth = 51;
            DtEmpleados.Size = new Size(418, 217);
            DtEmpleados.TabIndex = 33;
            DtEmpleados.CellContentClick += DtEmpleados_CellContentClick;
            // 
            // RbPrestador
            // 
            RbPrestador.AutoSize = true;
            RbPrestador.Location = new Point(25, 44);
            RbPrestador.Name = "RbPrestador";
            RbPrestador.Size = new Size(170, 24);
            RbPrestador.TabIndex = 31;
            RbPrestador.TabStop = true;
            RbPrestador.Text = "Prestador de Servicio";
            RbPrestador.UseVisualStyleBackColor = true;
            RbPrestador.CheckedChanged += RbPrestador_CheckedChanged;
            // 
            // RbFisio
            // 
            RbFisio.AutoSize = true;
            RbFisio.Location = new Point(25, 16);
            RbFisio.Name = "RbFisio";
            RbFisio.Size = new Size(107, 24);
            RbFisio.TabIndex = 30;
            RbFisio.TabStop = true;
            RbFisio.Text = "Fisioterapia";
            RbFisio.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Location = new Point(37, 273);
            label6.Name = "label6";
            label6.Size = new Size(212, 25);
            label6.TabIndex = 29;
            label6.Text = "Tipo Empleado";
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Location = new Point(268, 184);
            label4.Name = "label4";
            label4.Size = new Size(212, 25);
            label4.TabIndex = 27;
            label4.Text = "Apellido Paterno";
            // 
            // TxtApellidoPa
            // 
            TxtApellidoPa.Location = new Point(268, 212);
            TxtApellidoPa.Multiline = true;
            TxtApellidoPa.Name = "TxtApellidoPa";
            TxtApellidoPa.Size = new Size(212, 34);
            TxtApellidoPa.TabIndex = 26;
            TxtApellidoPa.KeyPress += TxtNombre_KeyPress;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Location = new Point(37, 468);
            label3.Name = "label3";
            label3.Size = new Size(141, 25);
            label3.TabIndex = 25;
            label3.Text = "Cedula Profesional";
            // 
            // TxtCedula
            // 
            TxtCedula.Location = new Point(184, 465);
            TxtCedula.Multiline = true;
            TxtCedula.Name = "TxtCedula";
            TxtCedula.Size = new Size(212, 34);
            TxtCedula.TabIndex = 24;
            TxtCedula.KeyPress += TxtCedula_KeyPress;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Location = new Point(37, 184);
            label2.Name = "label2";
            label2.Size = new Size(212, 25);
            label2.TabIndex = 23;
            label2.Text = "Nombre";
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(37, 212);
            TxtNombre.Multiline = true;
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(212, 34);
            TxtNombre.TabIndex = 22;
            TxtNombre.KeyPress += TxtNombre_KeyPress;
            // 
            // Nombre
            // 
            Nombre.BackColor = SystemColors.ActiveCaption;
            Nombre.Location = new Point(50, 125);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(117, 25);
            Nombre.TabIndex = 21;
            Nombre.Text = "Num Empleado";
            // 
            // TxtNumero
            // 
            TxtNumero.Location = new Point(173, 122);
            TxtNumero.Multiline = true;
            TxtNumero.Name = "TxtNumero";
            TxtNumero.Size = new Size(212, 34);
            TxtNumero.TabIndex = 20;
            TxtNumero.TextChanged += TxtNumero_TextChanged;
            TxtNumero.KeyPress += TxtNumero_KeyPress;
            TxtNumero.KeyUp += TxtNumero_KeyUp;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(eliminar);
            panel1.Controls.Add(Limpiar);
            panel1.Controls.Add(Guardar);
            panel1.Controls.Add(Buscar);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1180, 79);
            panel1.TabIndex = 19;
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
            // Limpiar
            // 
            Limpiar.Image = (Image)resources.GetObject("Limpiar.Image");
            Limpiar.Location = new Point(1015, 23);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(48, 42);
            Limpiar.SizeMode = PictureBoxSizeMode.Zoom;
            Limpiar.TabIndex = 3;
            Limpiar.TabStop = false;
            Limpiar.Click += Limpiar_Click;
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
            // Buscar
            // 
            Buscar.Image = Properties.Resources.buscar;
            Buscar.Location = new Point(1069, 19);
            Buscar.Name = "Buscar";
            Buscar.Size = new Size(48, 46);
            Buscar.SizeMode = PictureBoxSizeMode.Zoom;
            Buscar.TabIndex = 1;
            Buscar.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(34, 23);
            label1.Name = "label1";
            label1.Size = new Size(157, 38);
            label1.TabIndex = 0;
            label1.Text = "EMPLEADOS";
            // 
            // label7
            // 
            label7.BackColor = SystemColors.ActiveCaption;
            label7.Location = new Point(497, 184);
            label7.Name = "label7";
            label7.Size = new Size(212, 25);
            label7.TabIndex = 38;
            label7.Text = "Apellido Materno";
            // 
            // TxtApellidoMa
            // 
            TxtApellidoMa.Location = new Point(497, 212);
            TxtApellidoMa.Multiline = true;
            TxtApellidoMa.Name = "TxtApellidoMa";
            TxtApellidoMa.Size = new Size(212, 34);
            TxtApellidoMa.TabIndex = 37;
            TxtApellidoMa.KeyPress += TxtNombre_KeyPress;
            // 
            // RbActiva
            // 
            RbActiva.AutoSize = true;
            RbActiva.Location = new Point(153, 419);
            RbActiva.Name = "RbActiva";
            RbActiva.Size = new Size(71, 24);
            RbActiva.TabIndex = 41;
            RbActiva.TabStop = true;
            RbActiva.Text = "Activa";
            RbActiva.UseVisualStyleBackColor = true;
            RbActiva.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // Rbinactiva
            // 
            Rbinactiva.AutoSize = true;
            Rbinactiva.Location = new Point(50, 419);
            Rbinactiva.Name = "Rbinactiva";
            Rbinactiva.Size = new Size(81, 24);
            Rbinactiva.TabIndex = 40;
            Rbinactiva.TabStop = true;
            Rbinactiva.Text = "Inactiva";
            Rbinactiva.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.BackColor = SystemColors.ActiveCaption;
            label8.Location = new Point(37, 382);
            label8.Name = "label8";
            label8.Size = new Size(212, 25);
            label8.TabIndex = 39;
            label8.Text = "Estatus";
            // 
            // label9
            // 
            label9.BackColor = SystemColors.ActiveCaption;
            label9.Location = new Point(37, 513);
            label9.Name = "label9";
            label9.Size = new Size(141, 25);
            label9.TabIndex = 43;
            label9.Text = "Especialidades";
            // 
            // TxtEspecialidades
            // 
            TxtEspecialidades.Location = new Point(184, 510);
            TxtEspecialidades.Multiline = true;
            TxtEspecialidades.Name = "TxtEspecialidades";
            TxtEspecialidades.Size = new Size(212, 34);
            TxtEspecialidades.TabIndex = 42;
            TxtEspecialidades.KeyPress += TxtEspecialidades_KeyPress;
            // 
            // TxtClave
            // 
            TxtClave.Location = new Point(289, 301);
            TxtClave.Multiline = true;
            TxtClave.Name = "TxtClave";
            TxtClave.Size = new Size(191, 34);
            TxtClave.TabIndex = 44;
            // 
            // label10
            // 
            label10.BackColor = SystemColors.ActiveCaption;
            label10.Location = new Point(289, 273);
            label10.Name = "label10";
            label10.Size = new Size(191, 25);
            label10.TabIndex = 45;
            label10.Text = "Clave de Usuario\r\n";
            // 
            // label11
            // 
            label11.BackColor = SystemColors.ActiveCaption;
            label11.Location = new Point(497, 273);
            label11.Name = "label11";
            label11.Size = new Size(212, 25);
            label11.TabIndex = 47;
            label11.Text = "Telefono";
            // 
            // TxtTelefono
            // 
            TxtTelefono.Location = new Point(497, 301);
            TxtTelefono.Multiline = true;
            TxtTelefono.Name = "TxtTelefono";
            TxtTelefono.Size = new Size(212, 34);
            TxtTelefono.TabIndex = 46;
            TxtTelefono.KeyPress += TxtClave_KeyPress;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RbPrestador);
            groupBox1.Controls.Add(RbFisio);
            groupBox1.Location = new Point(23, 301);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(239, 78);
            groupBox1.TabIndex = 48;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lblAvisoNumero
            // 
            lblAvisoNumero.AutoSize = true;
            lblAvisoNumero.Location = new Point(153, 159);
            lblAvisoNumero.Name = "lblAvisoNumero";
            lblAvisoNumero.Size = new Size(0, 20);
            lblAvisoNumero.TabIndex = 49;
            // 
            // ctnombre
            // 
            ctnombre.AutoSize = true;
            ctnombre.Location = new Point(103, 249);
            ctnombre.Name = "ctnombre";
            ctnombre.Size = new Size(0, 20);
            ctnombre.TabIndex = 50;
            // 
            // ctClave
            // 
            ctClave.AutoSize = true;
            ctClave.Location = new Point(451, 349);
            ctClave.Name = "ctClave";
            ctClave.Size = new Size(0, 20);
            ctClave.TabIndex = 51;
            // 
            // ctcedula
            // 
            ctcedula.AutoSize = true;
            ctcedula.Location = new Point(415, 473);
            ctcedula.Name = "ctcedula";
            ctcedula.Size = new Size(0, 20);
            ctcedula.TabIndex = 52;
            // 
            // ctEspecialidades
            // 
            ctEspecialidades.AutoSize = true;
            ctEspecialidades.Location = new Point(415, 518);
            ctEspecialidades.Name = "ctEspecialidades";
            ctEspecialidades.Size = new Size(0, 20);
            ctEspecialidades.TabIndex = 53;
            // 
            // FrmEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            Controls.Add(ctEspecialidades);
            Controls.Add(ctcedula);
            Controls.Add(ctClave);
            Controls.Add(ctnombre);
            Controls.Add(lblAvisoNumero);
            Controls.Add(groupBox1);
            Controls.Add(label11);
            Controls.Add(TxtTelefono);
            Controls.Add(label10);
            Controls.Add(TxtClave);
            Controls.Add(label9);
            Controls.Add(TxtEspecialidades);
            Controls.Add(RbActiva);
            Controls.Add(Rbinactiva);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(TxtApellidoMa);
            Controls.Add(pictureBox1);
            Controls.Add(textBox5);
            Controls.Add(button1);
            Controls.Add(DtEmpleados);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(TxtApellidoPa);
            Controls.Add(label3);
            Controls.Add(TxtCedula);
            Controls.Add(label2);
            Controls.Add(TxtNombre);
            Controls.Add(Nombre);
            Controls.Add(TxtNumero);
            Controls.Add(panel1);
            Name = "FrmEmpleado";
            Text = "FrmEmpleado";
            Load += FrmEmpleado_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DtEmpleados).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)eliminar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Limpiar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Guardar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Buscar).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox5;
        private Button button1;
        private DataGridView DtEmpleados;
        private RadioButton RbPrestador;
        private RadioButton RbFisio;
        private Label label6;
        private Label label4;
        private TextBox TxtApellidoPa;
        private Label label3;
        private TextBox TxtCedula;
        private Label label2;
        private TextBox TxtNombre;
        private Label Nombre;
        private TextBox TxtNumero;
        private Panel panel1;
        private PictureBox eliminar;
        private PictureBox Limpiar;
        private PictureBox Guardar;
        private PictureBox Buscar;
        private Label label1;
        private Label label7;
        private TextBox TxtApellidoMa;
        private RadioButton RbActiva;
        private RadioButton Rbinactiva;
        private Label label8;
        private Label label9;
        private TextBox TxtEspecialidades;
        private TextBox TxtClave;
        private Label label10;
        private Label label11;
        private TextBox TxtTelefono;
        private GroupBox groupBox1;
        private Label lblAvisoNumero;
        private Label ctnombre;
        private Label ctClave;
        private Label ctcedula;
        private Label ctEspecialidades;
    }
}