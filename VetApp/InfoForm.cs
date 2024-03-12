using Entidades.Models;
using Entidades.Presentation;
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
    public partial class InfoForm : Form
    {
        private Pet pet;

        public InfoForm(Pet pet)
        {
            InitializeComponent();
            this.pet = pet;
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            this.txtName.Text = pet.Name;
            this.txtTipo.Text = pet.Tipo.ToString();
            this.txtBirth.Text = pet.Birth.ToString("MM/dd/YYYY");
            this.txtDni.Text = pet.Dni.ToString();
            this.txtYears.Text = (DateTime.Now.Year - pet.Birth.Year).ToString();
            this.txtPhone.Text = pet.Phone.ToString();

            this.pcbMascota.Image = Image.FromFile(Vet.GetUrlImage(pet.Tipo.ToString().ToLower()));
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        
    }
}
