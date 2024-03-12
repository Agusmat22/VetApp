﻿namespace VetApp
{
    partial class PetsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PetsForm));
            dgvPets = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            Birth = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtName = new TextBox();
            grpSearch = new GroupBox();
            cmbTipo = new ComboBox();
            btnSearch = new Button();
            btnSeeMore = new Button();
            btnDelete = new Button();
            btnBack = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvPets).BeginInit();
            grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnBack).BeginInit();
            SuspendLayout();
            // 
            // dgvPets
            // 
            dgvPets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPets.Columns.AddRange(new DataGridViewColumn[] { Name, Birth, Tipo });
            dgvPets.Location = new Point(419, 127);
            dgvPets.Name = "dgvPets";
            dgvPets.RowTemplate.Height = 25;
            dgvPets.Size = new Size(448, 374);
            dgvPets.TabIndex = 0;
            // 
            // Name
            // 
            Name.HeaderText = "Nombre";
            Name.Name = "Name";
            Name.Width = 135;
            // 
            // Birth
            // 
            Birth.HeaderText = "Nacimiento";
            Birth.Name = "Birth";
            Birth.Width = 135;
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            Tipo.Width = 135;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 19F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 102, 140);
            label1.Location = new Point(382, 39);
            label1.Name = "label1";
            label1.Size = new Size(131, 30);
            label1.TabIndex = 10;
            label1.Text = "Mascotas";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtName.Location = new Point(35, 80);
            txtName.Name = "txtName";
            txtName.Size = new Size(231, 25);
            txtName.TabIndex = 11;
            // 
            // grpSearch
            // 
            grpSearch.Controls.Add(cmbTipo);
            grpSearch.Controls.Add(btnSearch);
            grpSearch.Controls.Add(txtName);
            grpSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grpSearch.ForeColor = Color.FromArgb(0, 102, 140);
            grpSearch.Location = new Point(33, 117);
            grpSearch.Name = "grpSearch";
            grpSearch.Size = new Size(353, 127);
            grpSearch.TabIndex = 12;
            grpSearch.TabStop = false;
            grpSearch.Text = "Buscar";
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(35, 39);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(231, 25);
            cmbTipo.TabIndex = 13;
            // 
            // btnSearch
            // 
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(282, 80);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(42, 25);
            btnSearch.TabIndex = 12;
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnSeeMore
            // 
            btnSeeMore.Cursor = Cursors.Hand;
            btnSeeMore.FlatAppearance.BorderColor = Color.FromArgb(0, 102, 140);
            btnSeeMore.FlatAppearance.MouseOverBackColor = Color.FromArgb(181, 215, 228);
            btnSeeMore.FlatStyle = FlatStyle.Flat;
            btnSeeMore.ForeColor = Color.Black;
            btnSeeMore.Image = (Image)resources.GetObject("btnSeeMore.Image");
            btnSeeMore.Location = new Point(337, 275);
            btnSeeMore.Name = "btnSeeMore";
            btnSeeMore.Size = new Size(49, 48);
            btnSeeMore.TabIndex = 13;
            btnSeeMore.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.FromArgb(0, 102, 140);
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.Location = new Point(337, 329);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(49, 52);
            btnDelete.TabIndex = 15;
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Cursor = Cursors.Hand;
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.Location = new Point(9, 9);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(42, 39);
            btnBack.SizeMode = PictureBoxSizeMode.Zoom;
            btnBack.TabIndex = 16;
            btnBack.TabStop = false;
            btnBack.Click += btnBack_Click;
            // 
            // PetsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 254, 251);
            ClientSize = new Size(896, 565);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(btnSeeMore);
            Controls.Add(grpSearch);
            Controls.Add(label1);
            Controls.Add(dgvPets);
            FormBorderStyle = FormBorderStyle.None;
            //Name = "PetsForm";
            Text = "PetsForm";
            ((System.ComponentModel.ISupportInitialize)dgvPets).EndInit();
            grpSearch.ResumeLayout(false);
            grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPets;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Birth;
        private DataGridViewTextBoxColumn Tipo;
        private Label label1;
        private TextBox txtName;
        private GroupBox grpSearch;
        private ComboBox cmbTipo;
        private Button btnSearch;
        private Button btnSeeMore;
        private Button btnClinicHistory;
        private Button btnDelete;
        private PictureBox btnBack;
    }
}