using Entidades.Models;
using Entidades.Presentation;
using Entidades.Sql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetApp
{
    public partial class RegisterHistoryForm : Form
    {
        private Pet pet;
        
        public RegisterHistoryForm(Pet pet)
        {
            InitializeComponent();
            this.pet = pet;
        }

        private void RegisterHistoryForm_Load(object sender, EventArgs e)
        {
            this.lblName.Text = pet.Name;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (this.rtbClinicHistory.Text.Length > 0)
            {
                pet.ClinicHistory = Vet.GenerateClinicHistory(this.rtbClinicHistory.Text);
                ADOpet.Update(pet);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /// <summary>
        /// Estos dos metodos los cree para poder mover el formulario, ya que no contiene FormBorder
        /// </summary>
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
    }
}
