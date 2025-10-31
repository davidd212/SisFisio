namespace SisFisio.Fornularios
{
    partial class FrmCatEjercicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCatEjercicios));
            TxtNombre = new TextBox();
            TxtBuscar = new PictureBox();
            textBox5 = new TextBox();
            button1 = new Button();
            DtCatEjercicio = new DataGridView();
            Nombre = new Label();
            panel1 = new Panel();
            Eliminar = new PictureBox();
            Limpiar = new PictureBox();
            Guardar = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)TxtBuscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DtCatEjercicio).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Eliminar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Limpiar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Guardar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(192, 255);
            TxtNombre.Multiline = true;
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(287, 42);
            TxtNombre.TabIndex = 48;
            // 
            // TxtBuscar
            // 
            TxtBuscar.BackColor = Color.FromArgb(0, 192, 192);
            TxtBuscar.Image = (Image)resources.GetObject("TxtBuscar.Image");
            TxtBuscar.Location = new Point(956, 131);
            TxtBuscar.Name = "TxtBuscar";
            TxtBuscar.Size = new Size(53, 27);
            TxtBuscar.SizeMode = PictureBoxSizeMode.Zoom;
            TxtBuscar.TabIndex = 47;
            TxtBuscar.TabStop = false;
            TxtBuscar.Click += pictureBox1_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(748, 131);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(211, 27);
            textBox5.TabIndex = 46;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(612, 397);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 45;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // DtCatEjercicio
            // 
            DtCatEjercicio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtCatEjercicio.Location = new Point(612, 177);
            DtCatEjercicio.Name = "DtCatEjercicio";
            DtCatEjercicio.RowHeadersWidth = 51;
            DtCatEjercicio.Size = new Size(467, 188);
            DtCatEjercicio.TabIndex = 44;
            DtCatEjercicio.CellClick += DtCatEjercicio_CellClick;
            DtCatEjercicio.CellContentClick += DtCatEjercicio_CellContentClick;
            // 
            // Nombre
            // 
            Nombre.BackColor = SystemColors.ActiveCaption;
            Nombre.Location = new Point(192, 220);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(287, 32);
            Nombre.TabIndex = 41;
            Nombre.Text = "Nombre de la nueva categoria";
            Nombre.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(Eliminar);
            panel1.Controls.Add(Limpiar);
            panel1.Controls.Add(Guardar);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1180, 79);
            panel1.TabIndex = 40;
            // 
            // Eliminar
            // 
            Eliminar.Image = (Image)resources.GetObject("Eliminar.Image");
            Eliminar.Location = new Point(910, 23);
            Eliminar.Name = "Eliminar";
            Eliminar.Size = new Size(48, 42);
            Eliminar.SizeMode = PictureBoxSizeMode.Zoom;
            Eliminar.TabIndex = 4;
            Eliminar.TabStop = false;
            Eliminar.Click += Eliminar_Click;
            // 
            // Limpiar
            // 
            Limpiar.Image = (Image)resources.GetObject("Limpiar.Image");
            Limpiar.Location = new Point(988, 23);
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
            Guardar.Location = new Point(839, 23);
            Guardar.Name = "Guardar";
            Guardar.Size = new Size(48, 38);
            Guardar.SizeMode = PictureBoxSizeMode.Zoom;
            Guardar.TabIndex = 2;
            Guardar.TabStop = false;
            Guardar.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.buscar;
            pictureBox2.Location = new Point(1068, 23);
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
            label1.Size = new Size(178, 38);
            label1.TabIndex = 0;
            label1.Text = "CONSULTORIO";
            // 
            // FrmCatEjercicios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            Controls.Add(TxtNombre);
            Controls.Add(TxtBuscar);
            Controls.Add(textBox5);
            Controls.Add(button1);
            Controls.Add(DtCatEjercicio);
            Controls.Add(Nombre);
            Controls.Add(panel1);
            Name = "FrmCatEjercicios";
            Text = "FrmCatEjercicios";
            Load += FrmCatEjercicios_Load;
            ((System.ComponentModel.ISupportInitialize)TxtBuscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)DtCatEjercicio).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Eliminar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Limpiar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Guardar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtNombre;
        private PictureBox TxtBuscar;
        private TextBox textBox5;
        private Button button1;
        private DataGridView DtCatEjercicio;
        private Label Nombre;
        private Panel panel1;
        private PictureBox Eliminar;
        private PictureBox Limpiar;
        private PictureBox Guardar;
        private PictureBox pictureBox2;
        private Label label1;
    }
}