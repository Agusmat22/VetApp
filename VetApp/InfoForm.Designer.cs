namespace VetApp
{
    partial class InfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtPhone = new TextBox();
            txtDni = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            label6 = new Label();
            txtYears = new TextBox();
            txtBirth = new TextBox();
            label7 = new Label();
            txtTipo = new TextBox();
            pcbMascota = new PictureBox();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            richTextBox1 = new RichTextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbMascota).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 19F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 102, 140);
            label1.Location = new Point(252, 62);
            label1.Name = "label1";
            label1.Size = new Size(164, 30);
            label1.TabIndex = 11;
            label1.Text = "Informacion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 102, 140);
            label5.Location = new Point(477, 302);
            label5.Name = "label5";
            label5.Size = new Size(62, 17);
            label5.TabIndex = 26;
            label5.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 102, 140);
            label4.Location = new Point(492, 240);
            label4.Name = "label4";
            label4.Size = new Size(30, 17);
            label4.TabIndex = 25;
            label4.Text = "Dni";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 102, 140);
            label3.Location = new Point(477, 179);
            label3.Name = "label3";
            label3.Size = new Size(60, 17);
            label3.TabIndex = 24;
            label3.Text = "Nombre";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = SystemColors.Info;
            txtPhone.Enabled = false;
            txtPhone.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(390, 322);
            txtPhone.MaxLength = 99999999;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(236, 25);
            txtPhone.TabIndex = 23;
            // 
            // txtDni
            // 
            txtDni.BackColor = SystemColors.Info;
            txtDni.Enabled = false;
            txtDni.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDni.Location = new Point(390, 260);
            txtDni.MaxLength = 99999999;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(236, 25);
            txtDni.TabIndex = 22;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.Info;
            txtName.Enabled = false;
            txtName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(390, 199);
            txtName.MaxLength = 99999999;
            txtName.Name = "txtName";
            txtName.Size = new Size(236, 25);
            txtName.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 102, 140);
            label2.Location = new Point(487, 431);
            label2.Name = "label2";
            label2.Size = new Size(42, 17);
            label2.TabIndex = 30;
            label2.Text = "Edad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 102, 140);
            label6.Location = new Point(484, 365);
            label6.Name = "label6";
            label6.Size = new Size(49, 17);
            label6.TabIndex = 29;
            label6.Text = "Fecha";
            // 
            // txtYears
            // 
            txtYears.BackColor = SystemColors.Info;
            txtYears.Enabled = false;
            txtYears.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtYears.Location = new Point(390, 451);
            txtYears.MaxLength = 99999999;
            txtYears.Name = "txtYears";
            txtYears.Size = new Size(236, 25);
            txtYears.TabIndex = 28;
            // 
            // txtBirth
            // 
            txtBirth.BackColor = SystemColors.Info;
            txtBirth.Enabled = false;
            txtBirth.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtBirth.Location = new Point(390, 385);
            txtBirth.MaxLength = 99999999;
            txtBirth.Name = "txtBirth";
            txtBirth.Size = new Size(236, 25);
            txtBirth.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 102, 140);
            label7.Location = new Point(489, 121);
            label7.Name = "label7";
            label7.Size = new Size(35, 17);
            label7.TabIndex = 32;
            label7.Text = "Tipo";
            // 
            // txtTipo
            // 
            txtTipo.BackColor = SystemColors.Info;
            txtTipo.Enabled = false;
            txtTipo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTipo.Location = new Point(390, 141);
            txtTipo.MaxLength = 99999999;
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(236, 25);
            txtTipo.TabIndex = 31;
            // 
            // pcbMascota
            // 
            pcbMascota.Location = new Point(35, 141);
            pcbMascota.Name = "pcbMascota";
            pcbMascota.Size = new Size(282, 178);
            pcbMascota.SizeMode = PictureBoxSizeMode.Zoom;
            pcbMascota.TabIndex = 33;
            pcbMascota.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(204, 203, 200);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(675, 42);
            panel1.TabIndex = 34;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // pictureBox4
            // 
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(633, 5);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(33, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1063, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1104, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(35, 365);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(282, 191);
            richTextBox1.TabIndex = 35;
            richTextBox1.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(0, 102, 140);
            label8.Location = new Point(121, 344);
            label8.Name = "label8";
            label8.Size = new Size(114, 18);
            label8.TabIndex = 36;
            label8.Text = "Historia Clinica";
            // 
            // InfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 227, 224);
            ClientSize = new Size(675, 584);
            Controls.Add(label8);
            Controls.Add(richTextBox1);
            Controls.Add(panel1);
            Controls.Add(pcbMascota);
            Controls.Add(label7);
            Controls.Add(txtTipo);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(txtYears);
            Controls.Add(txtBirth);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPhone);
            Controls.Add(txtDni);
            Controls.Add(txtName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InfoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InfoForm";
            Load += InfoForm_Load;
            ((System.ComponentModel.ISupportInitialize)pcbMascota).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtPhone;
        private TextBox txtDni;
        private TextBox txtName;
        private Label label2;
        private Label label6;
        private TextBox txtYears;
        private TextBox txtBirth;
        private Label label7;
        private TextBox txtTipo;
        private PictureBox pcbMascota;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private RichTextBox richTextBox1;
        private Label label8;
    }
}