namespace SisFisio.Usuario
{
    partial class FrmLesiones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLesiones));
            button3 = new Button();
            CbLesion = new ComboBox();
            pictureBox1 = new PictureBox();
            textBox5 = new TextBox();
            button1 = new Button();
            DgLesiones = new DataGridView();
            label3 = new Label();
            TxtDescripcion = new TextBox();
            label2 = new Label();
            TxtGrado = new TextBox();
            Nombre = new Label();
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label5 = new Label();
            TxtNombre = new TextBox();
            cbcategoria = new ComboBox();
            label4 = new Label();
            cbejercicio = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            DgEjercico = new DataGridView();
            AGREGAR = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgLesiones).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgEjercico).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(128, 128, 255);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(267, 121);
            button3.Name = "button3";
            button3.Size = new Size(177, 29);
            button3.TabIndex = 56;
            button3.Text = "Administrar Categorias";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // CbLesion
            // 
            CbLesion.FormattingEnabled = true;
            CbLesion.Location = new Point(34, 135);
            CbLesion.Name = "CbLesion";
            CbLesion.Size = new Size(212, 28);
            CbLesion.TabIndex = 53;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(0, 192, 192);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1047, 127);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 52;
            pictureBox1.TabStop = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(839, 127);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(211, 27);
            textBox5.TabIndex = 51;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(703, 393);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 50;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // DgLesiones
            // 
            DgLesiones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgLesiones.Location = new Point(703, 173);
            DgLesiones.Name = "DgLesiones";
            DgLesiones.RowHeadersWidth = 51;
            DgLesiones.Size = new Size(467, 188);
            DgLesiones.TabIndex = 49;
            DgLesiones.CellClick += DgPacientes_CellClick;
            DgLesiones.CellContentClick += DgPacientes_CellContentClick;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Location = new Point(34, 278);
            label3.Name = "label3";
            label3.Size = new Size(635, 25);
            label3.TabIndex = 47;
            label3.Text = "Descripcion breve de ejercicio";
            // 
            // TxtDescripcion
            // 
            TxtDescripcion.Location = new Point(34, 306);
            TxtDescripcion.Multiline = true;
            TxtDescripcion.Name = "TxtDescripcion";
            TxtDescripcion.Size = new Size(635, 89);
            TxtDescripcion.TabIndex = 46;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Location = new Point(34, 212);
            label2.Name = "label2";
            label2.Size = new Size(212, 25);
            label2.TabIndex = 45;
            label2.Text = "Grado";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // TxtGrado
            // 
            TxtGrado.Location = new Point(252, 209);
            TxtGrado.Multiline = true;
            TxtGrado.Name = "TxtGrado";
            TxtGrado.Size = new Size(212, 34);
            TxtGrado.TabIndex = 44;
            TxtGrado.KeyPress += textBox2_KeyPress;
            // 
            // Nombre
            // 
            Nombre.BackColor = SystemColors.ActiveCaption;
            Nombre.Location = new Point(34, 107);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(212, 25);
            Nombre.TabIndex = 43;
            Nombre.Text = "Tipo de Lesion";
            Nombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1180, 79);
            panel1.TabIndex = 42;
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
            pictureBox5.Click += pictureBox5_Click;
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
            label1.Size = new Size(128, 38);
            label1.TabIndex = 0;
            label1.Text = "LESIONES";
            // 
            // label5
            // 
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Location = new Point(468, 121);
            label5.Name = "label5";
            label5.Size = new Size(212, 25);
            label5.TabIndex = 58;
            label5.Text = "Nombre de la Lesion";
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(469, 149);
            TxtNombre.Multiline = true;
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(212, 34);
            TxtNombre.TabIndex = 57;
            TxtNombre.KeyPress += textBox1_KeyPress;
            // 
            // cbcategoria
            // 
            cbcategoria.FormattingEnabled = true;
            cbcategoria.Location = new Point(34, 467);
            cbcategoria.Name = "cbcategoria";
            cbcategoria.Size = new Size(212, 28);
            cbcategoria.TabIndex = 60;
            cbcategoria.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Location = new Point(34, 439);
            label4.Name = "label4";
            label4.Size = new Size(212, 25);
            label4.TabIndex = 59;
            label4.Text = "Categoria";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbejercicio
            // 
            cbejercicio.FormattingEnabled = true;
            cbejercicio.Location = new Point(312, 467);
            cbejercicio.Name = "cbejercicio";
            cbejercicio.Size = new Size(212, 28);
            cbejercicio.TabIndex = 62;
            cbejercicio.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Location = new Point(312, 439);
            label6.Name = "label6";
            label6.Size = new Size(212, 25);
            label6.TabIndex = 61;
            label6.Text = "Nombre Ejercicio";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(34, 398);
            label7.Name = "label7";
            label7.Size = new Size(135, 20);
            label7.TabIndex = 63;
            label7.Text = "Ejercicios a asignar";
            // 
            // DgEjercico
            // 
            DgEjercico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgEjercico.Location = new Point(15, 501);
            DgEjercico.Name = "DgEjercico";
            DgEjercico.RowHeadersWidth = 51;
            DgEjercico.Size = new Size(635, 140);
            DgEjercico.TabIndex = 64;
            DgEjercico.CellContentClick += dataGridView2_CellContentClick;
            // 
            // AGREGAR
            // 
            AGREGAR.BackColor = Color.Green;
            AGREGAR.ForeColor = SystemColors.Control;
            AGREGAR.Location = new Point(554, 466);
            AGREGAR.Name = "AGREGAR";
            AGREGAR.Size = new Size(94, 29);
            AGREGAR.TabIndex = 65;
            AGREGAR.Text = "AGREGAR";
            AGREGAR.UseVisualStyleBackColor = false;
            AGREGAR.Click += AGREGAR_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(667, 586);
            button2.Name = "button2";
            button2.Size = new Size(143, 29);
            button2.TabIndex = 66;
            button2.Text = "Elaborar Informe";
            button2.UseVisualStyleBackColor = false;
            // 
            // FrmLesiones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            Controls.Add(button2);
            Controls.Add(AGREGAR);
            Controls.Add(DgEjercico);
            Controls.Add(label7);
            Controls.Add(cbejercicio);
            Controls.Add(label6);
            Controls.Add(cbcategoria);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(TxtNombre);
            Controls.Add(button3);
            Controls.Add(CbLesion);
            Controls.Add(pictureBox1);
            Controls.Add(textBox5);
            Controls.Add(button1);
            Controls.Add(DgLesiones);
            Controls.Add(label3);
            Controls.Add(TxtDescripcion);
            Controls.Add(label2);
            Controls.Add(TxtGrado);
            Controls.Add(Nombre);
            Controls.Add(panel1);
            Name = "FrmLesiones";
            Text = "FrmLesiones";
            Load += FrmLesiones_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgLesiones).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgEjercico).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private ComboBox CbLesion;
        private PictureBox pictureBox1;
        private TextBox textBox5;
        private Button button1;
        private DataGridView DgLesiones;
        private Label label3;
        private TextBox TxtDescripcion;
        private Label label2;
        private TextBox TxtGrado;
        private Label Nombre;
        private Panel panel1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label5;
        private TextBox TxtNombre;
        private ComboBox cbcategoria;
        private Label label4;
        private ComboBox cbejercicio;
        private Label label6;
        private Label label7;
        private DataGridView DgEjercico;
        private Button AGREGAR;
        private Button button2;
    }
}