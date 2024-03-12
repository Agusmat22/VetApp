namespace VetApp
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            label1 = new Label();
            btnBack = new PictureBox();
            pcbMascota = new PictureBox();
            cmbTipo = new ComboBox();
            txtName = new TextBox();
            txtDni = new TextBox();
            txtPhone = new TextBox();
            dtpBirth = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnRegister = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)btnBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbMascota).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 19F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 102, 140);
            label1.Location = new Point(320, 33);
            label1.Name = "label1";
            label1.Size = new Size(238, 30);
            label1.TabIndex = 9;
            label1.Text = "Registrar Mascota";
            // 
            // btnBack
            // 
            btnBack.Cursor = Cursors.Hand;
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.Location = new Point(9, 7);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(42, 39);
            btnBack.SizeMode = PictureBoxSizeMode.Zoom;
            btnBack.TabIndex = 10;
            btnBack.TabStop = false;
            btnBack.Click += btnBack_Click;
            // 
            // pcbMascota
            // 
            pcbMascota.Location = new Point(95, 121);
            pcbMascota.Name = "pcbMascota";
            pcbMascota.Size = new Size(282, 352);
            pcbMascota.SizeMode = PictureBoxSizeMode.Zoom;
            pcbMascota.TabIndex = 11;
            pcbMascota.TabStop = false;
            // 
            // cmbTipo
            // 
            cmbTipo.Cursor = Cursors.Hand;
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(527, 141);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(236, 25);
            cmbTipo.TabIndex = 12;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(527, 201);
            txtName.MaxLength = 99999999;
            txtName.Name = "txtName";
            txtName.Size = new Size(236, 25);
            txtName.TabIndex = 13;
            txtName.TextChanged += txtName_TextChanged;
            txtName.KeyPress += txtName_KeyPress;
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDni.Location = new Point(527, 262);
            txtDni.MaxLength = 99999999;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(236, 25);
            txtDni.TabIndex = 14;
            txtDni.TextChanged += txtDni_TextChanged;
            txtDni.KeyPress += txtDni_KeyPress;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(527, 324);
            txtPhone.MaxLength = 99999999;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(236, 25);
            txtPhone.TabIndex = 15;
            txtPhone.TextChanged += txtPhone_TextChanged;
            txtPhone.KeyPress += txtPhone_KeyPress;
            // 
            // dtpBirth
            // 
            dtpBirth.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtpBirth.Location = new Point(527, 385);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(236, 25);
            dtpBirth.TabIndex = 16;
            dtpBirth.ValueChanged += dtpBirth_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 102, 140);
            label2.Location = new Point(624, 121);
            label2.Name = "label2";
            label2.Size = new Size(35, 17);
            label2.TabIndex = 17;
            label2.Text = "Tipo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 102, 140);
            label3.Location = new Point(614, 181);
            label3.Name = "label3";
            label3.Size = new Size(60, 17);
            label3.TabIndex = 18;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 102, 140);
            label4.Location = new Point(629, 242);
            label4.Name = "label4";
            label4.Size = new Size(30, 17);
            label4.TabIndex = 19;
            label4.Text = "Dni";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 102, 140);
            label5.Location = new Point(614, 304);
            label5.Name = "label5";
            label5.Size = new Size(62, 17);
            label5.TabIndex = 20;
            label5.Text = "Telefono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 102, 140);
            label6.Location = new Point(604, 365);
            label6.Name = "label6";
            label6.Size = new Size(81, 17);
            label6.TabIndex = 21;
            label6.Text = "Nacimiento";
            // 
            // btnRegister
            // 
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderColor = Color.FromArgb(0, 102, 140);
            btnRegister.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 102, 140);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Location = new Point(527, 438);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(103, 35);
            btnRegister.TabIndex = 22;
            btnRegister.Text = "Registrar";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(0, 102, 140);
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 102, 140);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(660, 438);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(103, 35);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 254, 251);
            ClientSize = new Size(896, 565);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegister);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtpBirth);
            Controls.Add(txtPhone);
            Controls.Add(txtDni);
            Controls.Add(txtName);
            Controls.Add(cmbTipo);
            Controls.Add(pcbMascota);
            Controls.Add(btnBack);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ((System.ComponentModel.ISupportInitialize)btnBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbMascota).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox btnBack;
        private PictureBox pcbMascota;
        private ComboBox cmbTipo;
        private TextBox txtName;
        private TextBox txtDni;
        private TextBox txtPhone;
        private DateTimePicker dtpBirth;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnRegister;
        private Button btnCancelar;
    }
}