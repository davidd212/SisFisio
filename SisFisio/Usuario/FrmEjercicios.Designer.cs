namespace SisFisio.Fornularios
{
    partial class FrmEjercicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEjercicios));
            BusquedapictureBox = new PictureBox();
            BusquedatextBox5 = new TextBox();
            Editarbutton = new Button();
            EjerciciosdataGridView = new DataGridView();
            ImagenDeReferencialabel = new Label();
            DescripcionEjerciciolabel = new Label();
            DescripcionDelEjerciciotextBox = new TextBox();
            NombreEjerciciolabel = new Label();
            NombreDelEjerciciotextbox = new TextBox();
            Ejerciciospanel = new Panel();
            EliminarpictureBox = new PictureBox();
            LimpiarpictureBox = new PictureBox();
            GuardarpictureBox = new PictureBox();
            BuscarpictureBox = new PictureBox();
            label1 = new Label();
            ImagenDeReferenciatextBox6 = new TextBox();
            CargarImagenbutton = new Button();
            AdministrarCategoriasbutton = new Button();
            CategoriacomboBox = new ComboBox();
            CategoriaLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)BusquedapictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EjerciciosdataGridView).BeginInit();
            Ejerciciospanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EliminarpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LimpiarpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GuardarpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BuscarpictureBox).BeginInit();
            SuspendLayout();
            // 
            // BusquedapictureBox
            // 
            BusquedapictureBox.BackColor = Color.FromArgb(0, 192, 192);
            BusquedapictureBox.Image = (Image)resources.GetObject("BusquedapictureBox.Image");
            BusquedapictureBox.Location = new Point(871, 98);
            BusquedapictureBox.Margin = new Padding(3, 2, 3, 2);
            BusquedapictureBox.Name = "BusquedapictureBox";
            BusquedapictureBox.Size = new Size(46, 20);
            BusquedapictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            BusquedapictureBox.TabIndex = 36;
            BusquedapictureBox.TabStop = false;
            // 
            // BusquedatextBox5
            // 
            BusquedatextBox5.Location = new Point(689, 98);
            BusquedatextBox5.Margin = new Padding(3, 2, 3, 2);
            BusquedatextBox5.Name = "BusquedatextBox5";
            BusquedatextBox5.Size = new Size(185, 23);
            BusquedatextBox5.TabIndex = 35;
            // 
            // Editarbutton
            // 
            Editarbutton.BackColor = SystemColors.ActiveCaption;
            Editarbutton.Location = new Point(570, 297);
            Editarbutton.Margin = new Padding(3, 2, 3, 2);
            Editarbutton.Name = "Editarbutton";
            Editarbutton.Size = new Size(82, 22);
            Editarbutton.TabIndex = 34;
            Editarbutton.Text = "Editar";
            Editarbutton.UseVisualStyleBackColor = false;
            // 
            // EjerciciosdataGridView
            // 
            EjerciciosdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EjerciciosdataGridView.Location = new Point(570, 132);
            EjerciciosdataGridView.Margin = new Padding(3, 2, 3, 2);
            EjerciciosdataGridView.Name = "EjerciciosdataGridView";
            EjerciciosdataGridView.RowHeadersWidth = 51;
            EjerciciosdataGridView.Size = new Size(409, 141);
            EjerciciosdataGridView.TabIndex = 33;
            // 
            // ImagenDeReferencialabel
            // 
            ImagenDeReferencialabel.BackColor = SystemColors.ActiveCaption;
            ImagenDeReferencialabel.Location = new Point(277, 236);
            ImagenDeReferencialabel.Name = "ImagenDeReferencialabel";
            ImagenDeReferencialabel.Size = new Size(186, 19);
            ImagenDeReferencialabel.TabIndex = 27;
            ImagenDeReferencialabel.Text = "Imagen de Referencia";
            // 
            // DescripcionEjerciciolabel
            // 
            DescripcionEjerciciolabel.BackColor = SystemColors.ActiveCaption;
            DescripcionEjerciciolabel.Location = new Point(74, 236);
            DescripcionEjerciciolabel.Name = "DescripcionEjerciciolabel";
            DescripcionEjerciciolabel.Size = new Size(186, 19);
            DescripcionEjerciciolabel.TabIndex = 25;
            DescripcionEjerciciolabel.Text = "Descripcion del Ejercicio";
            // 
            // DescripcionDelEjerciciotextBox
            // 
            DescripcionDelEjerciciotextBox.Location = new Point(74, 256);
            DescripcionDelEjerciciotextBox.Margin = new Padding(3, 2, 3, 2);
            DescripcionDelEjerciciotextBox.Multiline = true;
            DescripcionDelEjerciciotextBox.Name = "DescripcionDelEjerciciotextBox";
            DescripcionDelEjerciciotextBox.Size = new Size(186, 117);
            DescripcionDelEjerciciotextBox.TabIndex = 24;
            // 
            // NombreEjerciciolabel
            // 
            NombreEjerciciolabel.BackColor = SystemColors.ActiveCaption;
            NombreEjerciciolabel.Location = new Point(74, 169);
            NombreEjerciciolabel.Name = "NombreEjerciciolabel";
            NombreEjerciciolabel.Size = new Size(186, 19);
            NombreEjerciciolabel.TabIndex = 23;
            NombreEjerciciolabel.Text = "Nombre del ejercicio";
            // 
            // NombreDelEjerciciotextbox
            // 
            NombreDelEjerciciotextbox.Location = new Point(74, 190);
            NombreDelEjerciciotextbox.Margin = new Padding(3, 2, 3, 2);
            NombreDelEjerciciotextbox.Multiline = true;
            NombreDelEjerciciotextbox.Name = "NombreDelEjerciciotextbox";
            NombreDelEjerciciotextbox.Size = new Size(186, 26);
            NombreDelEjerciciotextbox.TabIndex = 22;
            // 
            // Ejerciciospanel
            // 
            Ejerciciospanel.BackColor = Color.Navy;
            Ejerciciospanel.Controls.Add(EliminarpictureBox);
            Ejerciciospanel.Controls.Add(LimpiarpictureBox);
            Ejerciciospanel.Controls.Add(GuardarpictureBox);
            Ejerciciospanel.Controls.Add(BuscarpictureBox);
            Ejerciciospanel.Controls.Add(label1);
            Ejerciciospanel.Location = new Point(1, 1);
            Ejerciciospanel.Margin = new Padding(3, 2, 3, 2);
            Ejerciciospanel.Name = "Ejerciciospanel";
            Ejerciciospanel.Size = new Size(1032, 59);
            Ejerciciospanel.TabIndex = 19;
            // 
            // EliminarpictureBox
            // 
            EliminarpictureBox.Image = (Image)resources.GetObject("EliminarpictureBox.Image");
            EliminarpictureBox.Location = new Point(833, 17);
            EliminarpictureBox.Margin = new Padding(3, 2, 3, 2);
            EliminarpictureBox.Name = "EliminarpictureBox";
            EliminarpictureBox.Size = new Size(42, 32);
            EliminarpictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            EliminarpictureBox.TabIndex = 4;
            EliminarpictureBox.TabStop = false;
            // 
            // LimpiarpictureBox
            // 
            LimpiarpictureBox.Image = (Image)resources.GetObject("LimpiarpictureBox.Image");
            LimpiarpictureBox.Location = new Point(888, 17);
            LimpiarpictureBox.Margin = new Padding(3, 2, 3, 2);
            LimpiarpictureBox.Name = "LimpiarpictureBox";
            LimpiarpictureBox.Size = new Size(42, 32);
            LimpiarpictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            LimpiarpictureBox.TabIndex = 3;
            LimpiarpictureBox.TabStop = false;
            // 
            // GuardarpictureBox
            // 
            GuardarpictureBox.Image = (Image)resources.GetObject("GuardarpictureBox.Image");
            GuardarpictureBox.Location = new Point(786, 20);
            GuardarpictureBox.Margin = new Padding(3, 2, 3, 2);
            GuardarpictureBox.Name = "GuardarpictureBox";
            GuardarpictureBox.Size = new Size(42, 28);
            GuardarpictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            GuardarpictureBox.TabIndex = 2;
            GuardarpictureBox.TabStop = false;
            // 
            // BuscarpictureBox
            // 
            BuscarpictureBox.Image = Properties.Resources.buscar;
            BuscarpictureBox.Location = new Point(935, 14);
            BuscarpictureBox.Margin = new Padding(3, 2, 3, 2);
            BuscarpictureBox.Name = "BuscarpictureBox";
            BuscarpictureBox.Size = new Size(42, 34);
            BuscarpictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            BuscarpictureBox.TabIndex = 1;
            BuscarpictureBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(30, 17);
            label1.Name = "label1";
            label1.Size = new Size(119, 30);
            label1.TabIndex = 0;
            label1.Text = "EJERCICIOS";
            // 
            // ImagenDeReferenciatextBox6
            // 
            ImagenDeReferenciatextBox6.Location = new Point(277, 256);
            ImagenDeReferenciatextBox6.Margin = new Padding(3, 2, 3, 2);
            ImagenDeReferenciatextBox6.Multiline = true;
            ImagenDeReferenciatextBox6.Name = "ImagenDeReferenciatextBox6";
            ImagenDeReferenciatextBox6.Size = new Size(186, 117);
            ImagenDeReferenciatextBox6.TabIndex = 39;
            // 
            // CargarImagenbutton
            // 
            CargarImagenbutton.BackColor = Color.MidnightBlue;
            CargarImagenbutton.ForeColor = SystemColors.ButtonHighlight;
            CargarImagenbutton.Location = new Point(297, 377);
            CargarImagenbutton.Margin = new Padding(3, 2, 3, 2);
            CargarImagenbutton.Name = "CargarImagenbutton";
            CargarImagenbutton.Size = new Size(136, 33);
            CargarImagenbutton.TabIndex = 40;
            CargarImagenbutton.Text = "Cargar imagen";
            CargarImagenbutton.UseVisualStyleBackColor = false;
            // 
            // AdministrarCategoriasbutton
            // 
            AdministrarCategoriasbutton.BackColor = Color.FromArgb(128, 128, 255);
            AdministrarCategoriasbutton.ForeColor = SystemColors.ButtonHighlight;
            AdministrarCategoriasbutton.Location = new Point(277, 110);
            AdministrarCategoriasbutton.Margin = new Padding(3, 2, 3, 2);
            AdministrarCategoriasbutton.Name = "AdministrarCategoriasbutton";
            AdministrarCategoriasbutton.Size = new Size(155, 22);
            AdministrarCategoriasbutton.TabIndex = 41;
            AdministrarCategoriasbutton.Text = "Administrar Categorias";
            AdministrarCategoriasbutton.UseVisualStyleBackColor = false;
            // 
            // CategoriacomboBox
            // 
            CategoriacomboBox.FormattingEnabled = true;
            CategoriacomboBox.Location = new Point(74, 121);
            CategoriacomboBox.Margin = new Padding(3, 2, 3, 2);
            CategoriacomboBox.Name = "CategoriacomboBox";
            CategoriacomboBox.Size = new Size(186, 23);
            CategoriacomboBox.TabIndex = 37;
            // 
            // CategoriaLabel
            // 
            CategoriaLabel.BackColor = SystemColors.ActiveCaption;
            CategoriaLabel.Location = new Point(74, 100);
            CategoriaLabel.Name = "CategoriaLabel";
            CategoriaLabel.Size = new Size(186, 19);
            CategoriaLabel.TabIndex = 21;
            CategoriaLabel.Text = "Categoria";
            CategoriaLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmEjercicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 490);
            Controls.Add(AdministrarCategoriasbutton);
            Controls.Add(CargarImagenbutton);
            Controls.Add(ImagenDeReferenciatextBox6);
            Controls.Add(CategoriacomboBox);
            Controls.Add(BusquedapictureBox);
            Controls.Add(BusquedatextBox5);
            Controls.Add(Editarbutton);
            Controls.Add(EjerciciosdataGridView);
            Controls.Add(ImagenDeReferencialabel);
            Controls.Add(DescripcionEjerciciolabel);
            Controls.Add(DescripcionDelEjerciciotextBox);
            Controls.Add(NombreEjerciciolabel);
            Controls.Add(NombreDelEjerciciotextbox);
            Controls.Add(CategoriaLabel);
            Controls.Add(Ejerciciospanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmEjercicios";
            Text = "FrmEjercicios";
            ((System.ComponentModel.ISupportInitialize)BusquedapictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)EjerciciosdataGridView).EndInit();
            Ejerciciospanel.ResumeLayout(false);
            Ejerciciospanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EliminarpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)LimpiarpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)GuardarpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)BuscarpictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox BusquedapictureBox;
        private TextBox BusquedatextBox5;
        private Button Editarbutton;
        private DataGridView EjerciciosdataGridView;
        private Label ImagenDeReferencialabel;
        private Label DescripcionEjerciciolabel;
        private TextBox DescripcionDelEjerciciotextBox;
        private Label NombreEjerciciolabel;
        private TextBox NombreDelEjerciciotextbox;
        private Panel Ejerciciospanel;
        private PictureBox EliminarpictureBox;
        private PictureBox LimpiarpictureBox;
        private PictureBox GuardarpictureBox;
        private PictureBox BuscarpictureBox;
        private Label label1;
        private TextBox ImagenDeReferenciatextBox6;
        private Button CargarImagenbutton;
        private Button AdministrarCategoriasbutton;
        private ComboBox CategoriacomboBox;
        private Label CategoriaLabel;
    }
}