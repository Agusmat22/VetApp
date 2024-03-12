namespace VetApp
{
    partial class RegisterHistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterHistoryForm));
            label8 = new Label();
            rtbClinicHistory = new RichTextBox();
            label1 = new Label();
            lblName = new Label();
            label2 = new Label();
            btnCancelar = new Button();
            btnRegister = new Button();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(0, 102, 140);
            label8.Location = new Point(153, 179);
            label8.Name = "label8";
            label8.Size = new Size(114, 18);
            label8.TabIndex = 38;
            label8.Text = "Historia Clinica";
            // 
            // rtbClinicHistory
            // 
            rtbClinicHistory.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rtbClinicHistory.Location = new Point(43, 210);
            rtbClinicHistory.Name = "rtbClinicHistory";
            rtbClinicHistory.Size = new Size(335, 214);
            rtbClinicHistory.TabIndex = 37;
            rtbClinicHistory.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(43, 119);
            label1.Name = "label1";
            label1.Size = new Size(75, 18);
            label1.TabIndex = 39;
            label1.Text = "Mascota: ";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ForeColor = Color.FromArgb(0, 102, 140);
            lblName.Location = new Point(115, 120);
            lblName.Name = "lblName";
            lblName.Size = new Size(43, 16);
            lblName.TabIndex = 40;
            lblName.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 102, 140);
            label2.Location = new Point(166, 56);
            label2.Name = "label2";
            label2.Size = new Size(91, 24);
            label2.TabIndex = 41;
            label2.Text = "Agregar ";
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(0, 102, 140);
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(166, 35, 25);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(223, 445);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(103, 35);
            btnCancelar.TabIndex = 43;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnRegister
            // 
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderColor = Color.FromArgb(0, 102, 140);
            btnRegister.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 102, 140);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Location = new Point(90, 445);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(103, 35);
            btnRegister.TabIndex = 42;
            btnRegister.Text = "Registrar";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(204, 203, 200);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(417, 42);
            panel1.TabIndex = 44;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(376, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
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
            // RegisterHistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 505);
            Controls.Add(panel1);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegister);
            Controls.Add(label2);
            Controls.Add(lblName);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(rtbClinicHistory);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterHistoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterHistoryForm";
            Load += RegisterHistoryForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private RichTextBox rtbClinicHistory;
        private Label label1;
        private Label lblName;
        private Label label2;
        private Button btnCancelar;
        private Button btnRegister;
        private Panel panel1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
    }
}