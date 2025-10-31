namespace SisFisio.Usuario
{
    partial class FrmTipoLesiones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTipoLesiones));
            TxtTipo = new TextBox();
            Buscar = new PictureBox();
            textBox5 = new TextBox();
            button1 = new Button();
            Dtbusqueda = new DataGridView();
            Nombre = new Label();
            panel1 = new Panel();
            Borrar = new PictureBox();
            Limpiarr = new PictureBox();
            Guardar = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)Buscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Dtbusqueda).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Borrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Limpiarr).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Guardar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // TxtTipo
            // 
            TxtTipo.Location = new Point(168, 260);
            TxtTipo.Multiline = true;
            TxtTipo.Name = "TxtTipo";
            TxtTipo.Size = new Size(287, 37);
            TxtTipo.TabIndex = 48;
            // 
            // Buscar
            // 
            Buscar.BackColor = Color.FromArgb(0, 192, 192);
            Buscar.Image = (Image)resources.GetObject("Buscar.Image");
            Buscar.Location = new Point(965, 114);
            Buscar.Name = "Buscar";
            Buscar.Size = new Size(53, 27);
            Buscar.SizeMode = PictureBoxSizeMode.Zoom;
            Buscar.TabIndex = 47;
            Buscar.TabStop = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(757, 114);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(211, 27);
            textBox5.TabIndex = 46;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(621, 380);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 45;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Dtbusqueda
            // 
            Dtbusqueda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dtbusqueda.Location = new Point(621, 160);
            Dtbusqueda.Name = "Dtbusqueda";
            Dtbusqueda.RowHeadersWidth = 51;
            Dtbusqueda.Size = new Size(467, 188);
            Dtbusqueda.TabIndex = 44;
            // 
            // Nombre
            // 
            Nombre.BackColor = SystemColors.ActiveCaption;
            Nombre.Location = new Point(168, 225);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(287, 32);
            Nombre.TabIndex = 41;
            Nombre.Text = "Tipo de Lesion\r\n";
            Nombre.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(Borrar);
            panel1.Controls.Add(Limpiarr);
            panel1.Controls.Add(Guardar);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1180, 79);
            panel1.TabIndex = 40;
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
            // Limpiarr
            // 
            Limpiarr.Image = (Image)resources.GetObject("Limpiarr.Image");
            Limpiarr.Location = new Point(1015, 23);
            Limpiarr.Name = "Limpiarr";
            Limpiarr.Size = new Size(48, 42);
            Limpiarr.SizeMode = PictureBoxSizeMode.Zoom;
            Limpiarr.TabIndex = 3;
            Limpiarr.TabStop = false;
            Limpiarr.Click += Limpiarr_Click;
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
            label1.Size = new Size(178, 38);
            label1.TabIndex = 0;
            label1.Text = "CONSULTORIO";
            // 
            // FrmTipoLesiones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            Controls.Add(TxtTipo);
            Controls.Add(Buscar);
            Controls.Add(textBox5);
            Controls.Add(button1);
            Controls.Add(Dtbusqueda);
            Controls.Add(Nombre);
            Controls.Add(panel1);
            Name = "FrmTipoLesiones";
            Text = "FrmTipoLesiones";
            Load += FrmTipoLesiones_Load;
            ((System.ComponentModel.ISupportInitialize)Buscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Dtbusqueda).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Borrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Limpiarr).EndInit();
            ((System.ComponentModel.ISupportInitialize)Guardar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtTipo;
        private PictureBox Buscar;
        private TextBox textBox5;
        private Button button1;
        private DataGridView Dtbusqueda;
        private Label Nombre;
        private Panel panel1;
        private PictureBox Borrar;
        private PictureBox Limpiarr;
        private PictureBox Guardar;
        private PictureBox pictureBox2;
        private Label label1;
    }
}