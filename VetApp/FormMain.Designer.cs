namespace VetApp
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnPets = new Button();
            btnRegister = new Button();
            btnExit = new Button();
            panelFormContent = new Panel();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(204, 203, 200);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1149, 42);
            panel1.TabIndex = 0;
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
            pictureBox2.MouseClick += pictureBox2_MouseClick;
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
            pictureBox1.MouseClick += pictureBox1_MouseClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(204, 203, 200);
            panel2.Location = new Point(215, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(2, 565);
            panel2.TabIndex = 1;
            // 
            // btnPets
            // 
            btnPets.Cursor = Cursors.Hand;
            btnPets.FlatAppearance.BorderSize = 0;
            btnPets.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 102, 140);
            btnPets.FlatStyle = FlatStyle.Flat;
            btnPets.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnPets.Image = (Image)resources.GetObject("btnPets.Image");
            btnPets.ImageAlign = ContentAlignment.MiddleLeft;
            btnPets.Location = new Point(0, 310);
            btnPets.Name = "btnPets";
            btnPets.Size = new Size(215, 54);
            btnPets.TabIndex = 2;
            btnPets.Text = "Mascotas";
            btnPets.UseVisualStyleBackColor = true;
            btnPets.Click += btnPets_Click;
            // 
            // btnRegister
            // 
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 102, 140);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.Image = (Image)resources.GetObject("btnRegister.Image");
            btnRegister.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegister.Location = new Point(0, 250);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(215, 54);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Registrar";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnExit
            // 
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 102, 140);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(0, 580);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(215, 46);
            btnExit.TabIndex = 5;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // panelFormContent
            // 
            panelFormContent.BackColor = Color.FromArgb(255, 254, 251);
            panelFormContent.Location = new Point(235, 61);
            panelFormContent.Name = "panelFormContent";
            panelFormContent.Size = new Size(896, 565);
            panelFormContent.TabIndex = 6;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(36, 94);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(143, 86);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 102, 140);
            label1.Location = new Point(58, 67);
            label1.Name = "label1";
            label1.Size = new Size(99, 24);
            label1.TabIndex = 8;
            label1.Text = "Vet Salud";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 254, 251);
            ClientSize = new Size(1149, 642);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(panelFormContent);
            Controls.Add(btnExit);
            Controls.Add(btnRegister);
            Controls.Add(btnPets);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FormMain_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnPets;
        private Button btnRegister;
        private Button btnExit;
        private Panel panelFormContent;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
    }
}
