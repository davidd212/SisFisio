namespace SisFisio
{
    partial class Usuarios
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            label1 = new Label();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            txtUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            txtcontra = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            btnIniciar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.BorderRadius = 15;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(616, 111);
            label1.Name = "label1";
            label1.Size = new Size(92, 26);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            label1.Click += label1_Click;
            // 
            // guna2Separator1
            // 
            guna2Separator1.Location = new Point(547, 63);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(250, 12);
            guna2Separator1.TabIndex = 1;
            // 
            // txtUsuario
            // 
            txtUsuario.BorderRadius = 4;
            txtUsuario.CustomizableEdges = customizableEdges3;
            txtUsuario.DefaultText = "";
            txtUsuario.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUsuario.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUsuario.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUsuario.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUsuario.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsuario.Font = new Font("Segoe UI", 9F);
            txtUsuario.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsuario.Location = new Point(587, 141);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "";
            txtUsuario.SelectedText = "";
            txtUsuario.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtUsuario.Size = new Size(160, 30);
            txtUsuario.TabIndex = 2;
            // 
            // txtcontra
            // 
            txtcontra.BorderRadius = 4;
            txtcontra.CustomizableEdges = customizableEdges1;
            txtcontra.DefaultText = "";
            txtcontra.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtcontra.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtcontra.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtcontra.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtcontra.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtcontra.Font = new Font("Segoe UI", 9F);
            txtcontra.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtcontra.Location = new Point(587, 208);
            txtcontra.Margin = new Padding(3, 4, 3, 4);
            txtcontra.Name = "txtcontra";
            txtcontra.PlaceholderText = "";
            txtcontra.SelectedText = "";
            txtcontra.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtcontra.Size = new Size(160, 30);
            txtcontra.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Elephant", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(597, 178);
            label2.Name = "label2";
            label2.Size = new Size(128, 26);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.IndianRed;
            btnIniciar.Location = new Point(616, 256);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(92, 39);
            btnIniciar.TabIndex = 5;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(737, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 52);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Proyecto_nuevo;
            ClientSize = new Size(821, 358);
            Controls.Add(pictureBox1);
            Controls.Add(btnIniciar);
            Controls.Add(label2);
            Controls.Add(txtcontra);
            Controls.Add(txtUsuario);
            Controls.Add(guna2Separator1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Usuarios";
            Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2TextBox txtUsuario;
        private Guna.UI2.WinForms.Guna2TextBox txtcontra;
        private Label label2;
        private Button btnIniciar;
        private PictureBox pictureBox1;
    }
}