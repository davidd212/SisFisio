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
            Pacientespanel = new Panel();
            EliminarpictureBox = new PictureBox();
            LimpiarpictureBox = new PictureBox();
            GuardarpictureBox = new PictureBox();
            BuscarpictureBox = new PictureBox();
            label1 = new Label();
            NombretextBox1 = new TextBox();
            Nombre = new Label();
            ApellidoPaternolabel = new Label();
            NombretextBox2 = new TextBox();
            Telefonolabel = new Label();
            NombretextBox3 = new TextBox();
            ApellidoMaternolabel = new Label();
            NombretextBox4 = new TextBox();
            FechaDeNacimientolabel = new Label();
            Generolabel = new Label();
            MasculinoradioButton = new RadioButton();
            FemeninoradioButton = new RadioButton();
            FechaNacimientodateTimePicker = new DateTimePicker();
            PacientesdataGridView = new DataGridView();
            Editarbutton = new Button();
            NombretextBox = new TextBox();
            BusquedapictureBox = new PictureBox();
            Pacientespanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EliminarpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LimpiarpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GuardarpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BuscarpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PacientesdataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BusquedapictureBox).BeginInit();
            SuspendLayout();
            // 
            // Pacientespanel
            // 
            Pacientespanel.BackColor = Color.Navy;
            Pacientespanel.Controls.Add(EliminarpictureBox);
            Pacientespanel.Controls.Add(LimpiarpictureBox);
            Pacientespanel.Controls.Add(GuardarpictureBox);
            Pacientespanel.Controls.Add(BuscarpictureBox);
            Pacientespanel.Controls.Add(label1);
            Pacientespanel.Location = new Point(3, 1);
            Pacientespanel.Margin = new Padding(3, 2, 3, 2);
            Pacientespanel.Name = "Pacientespanel";
            Pacientespanel.Size = new Size(1032, 59);
            Pacientespanel.TabIndex = 0;
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
            label1.Size = new Size(112, 30);
            label1.TabIndex = 0;
            label1.Text = "PACIENTES";
            // 
            // NombretextBox1
            // 
            NombretextBox1.Location = new Point(75, 121);
            NombretextBox1.Margin = new Padding(3, 2, 3, 2);
            NombretextBox1.Multiline = true;
            NombretextBox1.Name = "NombretextBox1";
            NombretextBox1.Size = new Size(186, 26);
            NombretextBox1.TabIndex = 1;
            // 
            // Nombre
            // 
            Nombre.BackColor = SystemColors.ActiveCaption;
            Nombre.Location = new Point(75, 100);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(186, 19);
            Nombre.TabIndex = 2;
            Nombre.Text = "Nombre";
            // 
            // ApellidoPaternolabel
            // 
            ApellidoPaternolabel.BackColor = SystemColors.ActiveCaption;
            ApellidoPaternolabel.Location = new Point(75, 169);
            ApellidoPaternolabel.Name = "ApellidoPaternolabel";
            ApellidoPaternolabel.Size = new Size(186, 19);
            ApellidoPaternolabel.TabIndex = 4;
            ApellidoPaternolabel.Text = "Apellido Paterno";
            // 
            // NombretextBox2
            // 
            NombretextBox2.Location = new Point(75, 190);
            NombretextBox2.Margin = new Padding(3, 2, 3, 2);
            NombretextBox2.Multiline = true;
            NombretextBox2.Name = "NombretextBox2";
            NombretextBox2.Size = new Size(186, 26);
            NombretextBox2.TabIndex = 3;
            // 
            // Telefonolabel
            // 
            Telefonolabel.BackColor = SystemColors.ActiveCaption;
            Telefonolabel.Location = new Point(75, 236);
            Telefonolabel.Name = "Telefonolabel";
            Telefonolabel.Size = new Size(186, 19);
            Telefonolabel.TabIndex = 6;
            Telefonolabel.Text = "Telefono";
            // 
            // NombretextBox3
            // 
            NombretextBox3.Location = new Point(75, 256);
            NombretextBox3.Margin = new Padding(3, 2, 3, 2);
            NombretextBox3.Multiline = true;
            NombretextBox3.Name = "NombretextBox3";
            NombretextBox3.Size = new Size(186, 26);
            NombretextBox3.TabIndex = 5;
            // 
            // ApellidoMaternolabel
            // 
            ApellidoMaternolabel.BackColor = SystemColors.ActiveCaption;
            ApellidoMaternolabel.Location = new Point(279, 169);
            ApellidoMaternolabel.Name = "ApellidoMaternolabel";
            ApellidoMaternolabel.Size = new Size(186, 19);
            ApellidoMaternolabel.TabIndex = 8;
            ApellidoMaternolabel.Text = "Apellido Materno";
            // 
            // NombretextBox4
            // 
            NombretextBox4.Location = new Point(279, 190);
            NombretextBox4.Margin = new Padding(3, 2, 3, 2);
            NombretextBox4.Multiline = true;
            NombretextBox4.Name = "NombretextBox4";
            NombretextBox4.Size = new Size(186, 26);
            NombretextBox4.TabIndex = 7;
            // 
            // FechaDeNacimientolabel
            // 
            FechaDeNacimientolabel.BackColor = SystemColors.ActiveCaption;
            FechaDeNacimientolabel.Location = new Point(279, 236);
            FechaDeNacimientolabel.Name = "FechaDeNacimientolabel";
            FechaDeNacimientolabel.Size = new Size(186, 19);
            FechaDeNacimientolabel.TabIndex = 10;
            FechaDeNacimientolabel.Text = "Fecha de nacimiento";
            // 
            // Generolabel
            // 
            Generolabel.BackColor = SystemColors.ActiveCaption;
            Generolabel.Location = new Point(75, 302);
            Generolabel.Name = "Generolabel";
            Generolabel.Size = new Size(186, 19);
            Generolabel.TabIndex = 11;
            Generolabel.Text = "Genero";
            // 
            // MasculinoradioButton
            // 
            MasculinoradioButton.AutoSize = true;
            MasculinoradioButton.Location = new Point(106, 330);
            MasculinoradioButton.Margin = new Padding(3, 2, 3, 2);
            MasculinoradioButton.Name = "MasculinoradioButton";
            MasculinoradioButton.Size = new Size(80, 19);
            MasculinoradioButton.TabIndex = 12;
            MasculinoradioButton.TabStop = true;
            MasculinoradioButton.Text = "Masculino";
            MasculinoradioButton.UseVisualStyleBackColor = true;
            // 
            // FemeninoradioButton
            // 
            FemeninoradioButton.AutoSize = true;
            FemeninoradioButton.Location = new Point(106, 352);
            FemeninoradioButton.Margin = new Padding(3, 2, 3, 2);
            FemeninoradioButton.Name = "FemeninoradioButton";
            FemeninoradioButton.Size = new Size(78, 19);
            FemeninoradioButton.TabIndex = 13;
            FemeninoradioButton.TabStop = true;
            FemeninoradioButton.Text = "Femenino";
            FemeninoradioButton.UseVisualStyleBackColor = true;
            // 
            // FechaNacimientodateTimePicker
            // 
            FechaNacimientodateTimePicker.Location = new Point(275, 255);
            FechaNacimientodateTimePicker.Margin = new Padding(3, 2, 3, 2);
            FechaNacimientodateTimePicker.Name = "FechaNacimientodateTimePicker";
            FechaNacimientodateTimePicker.Size = new Size(190, 23);
            FechaNacimientodateTimePicker.TabIndex = 14;
            // 
            // PacientesdataGridView
            // 
            PacientesdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PacientesdataGridView.Location = new Point(571, 132);
            PacientesdataGridView.Margin = new Padding(3, 2, 3, 2);
            PacientesdataGridView.Name = "PacientesdataGridView";
            PacientesdataGridView.RowHeadersWidth = 51;
            PacientesdataGridView.Size = new Size(409, 141);
            PacientesdataGridView.TabIndex = 15;
            // 
            // Editarbutton
            // 
            Editarbutton.BackColor = SystemColors.ActiveCaption;
            Editarbutton.Location = new Point(571, 297);
            Editarbutton.Margin = new Padding(3, 2, 3, 2);
            Editarbutton.Name = "Editarbutton";
            Editarbutton.Size = new Size(82, 22);
            Editarbutton.TabIndex = 16;
            Editarbutton.Text = "Editar";
            Editarbutton.UseVisualStyleBackColor = false;
            // 
            // NombretextBox
            // 
            NombretextBox.Location = new Point(690, 98);
            NombretextBox.Margin = new Padding(3, 2, 3, 2);
            NombretextBox.Name = "NombretextBox";
            NombretextBox.Size = new Size(185, 23);
            NombretextBox.TabIndex = 17;
            // 
            // BusquedapictureBox
            // 
            BusquedapictureBox.BackColor = Color.FromArgb(0, 192, 192);
            BusquedapictureBox.Image = (Image)resources.GetObject("BusquedapictureBox.Image");
            BusquedapictureBox.Location = new Point(872, 98);
            BusquedapictureBox.Margin = new Padding(3, 2, 3, 2);
            BusquedapictureBox.Name = "BusquedapictureBox";
            BusquedapictureBox.Size = new Size(46, 20);
            BusquedapictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            BusquedapictureBox.TabIndex = 18;
            BusquedapictureBox.TabStop = false;
            BusquedapictureBox.Click += pictureBox1_Click;
            // 
            // FrmPacientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 490);
            Controls.Add(BusquedapictureBox);
            Controls.Add(NombretextBox);
            Controls.Add(Editarbutton);
            Controls.Add(PacientesdataGridView);
            Controls.Add(FechaNacimientodateTimePicker);
            Controls.Add(FemeninoradioButton);
            Controls.Add(MasculinoradioButton);
            Controls.Add(Generolabel);
            Controls.Add(FechaDeNacimientolabel);
            Controls.Add(ApellidoMaternolabel);
            Controls.Add(NombretextBox4);
            Controls.Add(Telefonolabel);
            Controls.Add(NombretextBox3);
            Controls.Add(ApellidoPaternolabel);
            Controls.Add(NombretextBox2);
            Controls.Add(Nombre);
            Controls.Add(NombretextBox1);
            Controls.Add(Pacientespanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmPacientes";
            Load += FrmPacientes_Load;
            Pacientespanel.ResumeLayout(false);
            Pacientespanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EliminarpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)LimpiarpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)GuardarpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)BuscarpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)PacientesdataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)BusquedapictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Pacientespanel;
        private Label label1;
        private TextBox NombretextBox1;
        private Label Nombre;
        private Label ApellidoPaternolabel;
        private TextBox NombretextBox2;
        private Label Telefonolabel;
        private TextBox NombretextBox3;
        private Label ApellidoMaternolabel;
        private TextBox NombretextBox4;
        private Label FechaDeNacimientolabel;
        private Label Generolabel;
        private RadioButton MasculinoradioButton;
        private RadioButton FemeninoradioButton;
        private DateTimePicker FechaNacimientodateTimePicker;
        private DataGridView PacientesdataGridView;
        private Button Editarbutton;
        private TextBox NombretextBox;
        private PictureBox BusquedapictureBox;
        private PictureBox BuscarpictureBox;
        private PictureBox GuardarpictureBox;
        private PictureBox EliminarpictureBox;
        private PictureBox LimpiarpictureBox;
    }
}