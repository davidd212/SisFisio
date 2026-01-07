namespace SisFisio.Usuario
{
    partial class FrmTratamientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTratamientos));
            TxtNombre = new TextBox();
            pictureBox1 = new PictureBox();
            textBox5 = new TextBox();
            button1 = new Button();
            DgTratamiento = new DataGridView();
            label3 = new Label();
            TxtDescripcion = new TextBox();
            Nombre = new Label();
            panel1 = new Panel();
            Eliminar = new PictureBox();
            pictureBox4 = new PictureBox();
            Guardar = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            ctnombre = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgTratamiento).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Eliminar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Guardar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(279, 157);
            TxtNombre.Multiline = true;
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(287, 37);
            TxtNombre.TabIndex = 48;
            TxtNombre.KeyPress += TxtNombre_KeyPress;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(0, 192, 192);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1018, 114);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(810, 114);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(211, 27);
            textBox5.TabIndex = 46;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(674, 380);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 45;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // DgTratamiento
            // 
            DgTratamiento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgTratamiento.Location = new Point(674, 160);
            DgTratamiento.Name = "DgTratamiento";
            DgTratamiento.RowHeadersWidth = 51;
            DgTratamiento.Size = new Size(467, 188);
            DgTratamiento.TabIndex = 44;
            DgTratamiento.CellClick += DgTratamiento_CellClick;
            DgTratamiento.CellContentClick += DgTratamiento_CellContentClick;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Location = new Point(112, 218);
            label3.Name = "label3";
            label3.Size = new Size(454, 29);
            label3.TabIndex = 43;
            label3.Text = "Descripcion detallada del Tratamiento";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtDescripcion
            // 
            TxtDescripcion.Location = new Point(112, 241);
            TxtDescripcion.Multiline = true;
            TxtDescripcion.Name = "TxtDescripcion";
            TxtDescripcion.Size = new Size(454, 121);
            TxtDescripcion.TabIndex = 42;
            TxtDescripcion.KeyPress += TxtDescripcion_KeyPress;
            // 
            // Nombre
            // 
            Nombre.BackColor = SystemColors.ActiveCaption;
            Nombre.Location = new Point(112, 160);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(172, 32);
            Nombre.TabIndex = 41;
            Nombre.Text = "Nombre del tratamiento";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(Eliminar);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(Guardar);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1180, 79);
            panel1.TabIndex = 40;
            // 
            // Eliminar
            // 
            Eliminar.Image = (Image)resources.GetObject("Eliminar.Image");
            Eliminar.Location = new Point(952, 23);
            Eliminar.Name = "Eliminar";
            Eliminar.Size = new Size(48, 42);
            Eliminar.SizeMode = PictureBoxSizeMode.Zoom;
            Eliminar.TabIndex = 4;
            Eliminar.TabStop = false;
            Eliminar.Click += Eliminar_Click;
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
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(34, 23);
            label1.Name = "label1";
            label1.Size = new Size(172, 38);
            label1.TabIndex = 0;
            label1.Text = "TRATAMIENTO";
            // 
            // ctnombre
            // 
            ctnombre.AutoSize = true;
            ctnombre.Location = new Point(290, 197);
            ctnombre.Name = "ctnombre";
            ctnombre.Size = new Size(0, 20);
            ctnombre.TabIndex = 49;
            // 
            // FrmTratamientos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            Controls.Add(ctnombre);
            Controls.Add(TxtNombre);
            Controls.Add(pictureBox1);
            Controls.Add(textBox5);
            Controls.Add(button1);
            Controls.Add(DgTratamiento);
            Controls.Add(label3);
            Controls.Add(TxtDescripcion);
            Controls.Add(Nombre);
            Controls.Add(panel1);
            Name = "FrmTratamientos";
            Text = "FrmTratamientos";
            Load += FrmTratamientos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgTratamiento).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Eliminar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)Guardar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtNombre;
        private PictureBox pictureBox1;
        private TextBox textBox5;
        private Button button1;
        private DataGridView DgTratamiento;
        private Label label3;
        private TextBox TxtDescripcion;
        private Label Nombre;
        private Panel panel1;
        private PictureBox Eliminar;
        private PictureBox pictureBox4;
        private PictureBox Guardar;
        private PictureBox pictureBox2;
        private Label label1;
        private Label ctnombre;
    }
}