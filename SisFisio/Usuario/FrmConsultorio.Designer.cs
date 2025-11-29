namespace SisFisio.Fornularios
{
    partial class FrmConsultorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultorio));
            Buscar = new PictureBox();
            textBox5 = new TextBox();
            modificar = new Button();
            Dtbusqueda = new DataGridView();
            label3 = new Label();
            TxtDireccion = new TextBox();
            Nombre = new Label();
            panel1 = new Panel();
            Eliminar = new PictureBox();
            Limpiarm = new PictureBox();
            Guardar = new PictureBox();
            Bu = new PictureBox();
            label1 = new Label();
            TxtNombre = new TextBox();
            label2 = new Label();
            TxtTelefono = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Buscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Dtbusqueda).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Eliminar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Limpiarm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Guardar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Bu).BeginInit();
            SuspendLayout();
            // 
            // Buscar
            // 
            Buscar.BackColor = Color.FromArgb(0, 192, 192);
            Buscar.Image = (Image)resources.GetObject("Buscar.Image");
            Buscar.Location = new Point(1016, 113);
            Buscar.Name = "Buscar";
            Buscar.Size = new Size(53, 27);
            Buscar.SizeMode = PictureBoxSizeMode.Zoom;
            Buscar.TabIndex = 36;
            Buscar.TabStop = false;
            Buscar.Click += Buscar_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(808, 113);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(211, 27);
            textBox5.TabIndex = 35;
            // 
            // modificar
            // 
            modificar.BackColor = SystemColors.ActiveCaption;
            modificar.Location = new Point(672, 379);
            modificar.Name = "modificar";
            modificar.Size = new Size(94, 29);
            modificar.TabIndex = 34;
            modificar.Text = "Editar";
            modificar.UseVisualStyleBackColor = false;
            // 
            // Dtbusqueda
            // 
            Dtbusqueda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dtbusqueda.Location = new Point(672, 159);
            Dtbusqueda.Name = "Dtbusqueda";
            Dtbusqueda.RowHeadersWidth = 51;
            Dtbusqueda.Size = new Size(467, 188);
            Dtbusqueda.TabIndex = 33;
            Dtbusqueda.CellContentClick += Dtbusqueda_CellContentClick;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Location = new Point(110, 290);
            label3.Name = "label3";
            label3.Size = new Size(454, 25);
            label3.TabIndex = 25;
            label3.Text = "Direccion del Consultorio";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtDireccion
            // 
            TxtDireccion.Location = new Point(110, 313);
            TxtDireccion.Multiline = true;
            TxtDireccion.Name = "TxtDireccion";
            TxtDireccion.Size = new Size(454, 95);
            TxtDireccion.TabIndex = 24;
            // 
            // Nombre
            // 
            Nombre.BackColor = SystemColors.ActiveCaption;
            Nombre.Location = new Point(110, 159);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(172, 32);
            Nombre.TabIndex = 21;
            Nombre.Text = "Nombre del Consulorio";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(Eliminar);
            panel1.Controls.Add(Limpiarm);
            panel1.Controls.Add(Guardar);
            panel1.Controls.Add(Bu);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1180, 79);
            panel1.TabIndex = 19;
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
            // Limpiarm
            // 
            Limpiarm.Image = (Image)resources.GetObject("Limpiarm.Image");
            Limpiarm.Location = new Point(1015, 23);
            Limpiarm.Name = "Limpiarm";
            Limpiarm.Size = new Size(48, 42);
            Limpiarm.SizeMode = PictureBoxSizeMode.Zoom;
            Limpiarm.TabIndex = 3;
            Limpiarm.TabStop = false;
            Limpiarm.Click += Limpiarm_Click;
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
            // Bu
            // 
            Bu.Image = Properties.Resources.buscar;
            Bu.Location = new Point(1069, 19);
            Bu.Name = "Bu";
            Bu.Size = new Size(48, 46);
            Bu.SizeMode = PictureBoxSizeMode.Zoom;
            Bu.TabIndex = 1;
            Bu.TabStop = false;
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
            // TxtNombre
            // 
            TxtNombre.Location = new Point(277, 156);
            TxtNombre.Multiline = true;
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(287, 37);
            TxtNombre.TabIndex = 37;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Location = new Point(110, 222);
            label2.Name = "label2";
            label2.Size = new Size(172, 32);
            label2.TabIndex = 38;
            label2.Text = "Telefono";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtTelefono
            // 
            TxtTelefono.Location = new Point(277, 219);
            TxtTelefono.Multiline = true;
            TxtTelefono.Name = "TxtTelefono";
            TxtTelefono.Size = new Size(196, 37);
            TxtTelefono.TabIndex = 39;
            // 
            // FrmConsultorio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            Controls.Add(TxtTelefono);
            Controls.Add(label2);
            Controls.Add(TxtNombre);
            Controls.Add(Buscar);
            Controls.Add(textBox5);
            Controls.Add(modificar);
            Controls.Add(Dtbusqueda);
            Controls.Add(label3);
            Controls.Add(TxtDireccion);
            Controls.Add(Nombre);
            Controls.Add(panel1);
            Name = "FrmConsultorio";
            Text = "FrmConsultorio";
            Load += FrmConsultorio_Load;
            ((System.ComponentModel.ISupportInitialize)Buscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Dtbusqueda).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Eliminar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Limpiarm).EndInit();
            ((System.ComponentModel.ISupportInitialize)Guardar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Bu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Buscar;
        private TextBox textBox5;
        private Button modificar;
        private DataGridView Dtbusqueda;
        private Label label3;
        private TextBox TxtDireccion;
        private Label Nombre;
        private Panel panel1;
        private PictureBox Eliminar;
        private PictureBox Limpiarm;
        private PictureBox Guardar;
        private PictureBox Bu;
        private Label label1;
        private TextBox TxtNombre;
        private Label label2;
        private TextBox TxtTelefono;
    }
}