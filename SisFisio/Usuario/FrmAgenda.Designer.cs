namespace SisFisio.Usuario
{
    partial class FrmAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgenda));
            dateTimePicker2 = new DateTimePicker();
            label7 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            Nombre = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(554, 331);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(193, 27);
            dateTimePicker2.TabIndex = 55;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(432, 334);
            label7.Name = "label7";
            label7.Size = new Size(116, 20);
            label7.TabIndex = 54;
            label7.Text = "Asigna una hora";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(432, 280);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 53;
            label2.Text = "Asigna un Fecha";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(554, 275);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(271, 27);
            dateTimePicker1.TabIndex = 50;
            // 
            // Nombre
            // 
            Nombre.BackColor = SystemColors.ActiveCaption;
            Nombre.Location = new Point(436, 210);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(132, 34);
            Nombre.TabIndex = 43;
            Nombre.Text = "Evento  registrar";
            Nombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(574, 210);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 34);
            textBox1.TabIndex = 42;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1180, 79);
            panel1.TabIndex = 41;
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
            label1.Location = new Point(40, 27);
            label1.Name = "label1";
            label1.Size = new Size(242, 38);
            label1.TabIndex = 0;
            label1.Text = "SOLICITUD DE CITAS";
            // 
            // FrmAgenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            Controls.Add(dateTimePicker2);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(Nombre);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Name = "FrmAgenda";
            Text = "FrmAgenda";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker2;
        private Label label7;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label Nombre;
        private TextBox textBox1;
        private Panel panel1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label1;
    }
}