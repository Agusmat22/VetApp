using Entidades.Models;
using Entidades.Presentation;
using Entidades.Sql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetApp
{
    public partial class RegisterForm : Form
    {
        private Vet vet;

        private EPet tipo;
        private string name;
        private int dni;
        private int phone;
        private DateTime birth;


        public RegisterForm(Vet vet)
        {
            InitializeComponent();
            this.vet = vet;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void RegisterForm_Load(object sender, EventArgs e)
        {
            this.cmbTipo.DataSource = Enum.GetValues(typeof(EPet));
            this.cmbTipo.SelectedIndex = 0;


        }

        /// <summary>
        /// Save the type of pet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tipo = (EPet)this.cmbTipo.SelectedItem;

            string rutaImg;
            switch (tipo)
            {
                case EPet.Perro:

                    rutaImg = SelectPicture("perro");

                    break;

                case EPet.Gato:

                    rutaImg = SelectPicture("gato");

                    break;

                case EPet.Hamster:

                    rutaImg = SelectPicture("hamster");

                    break;

                default:

                    rutaImg = SelectPicture("otros");


                    break;
            }

            this.pcbMascota.Image = Image.FromFile(rutaImg);

        }


        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; //ignoro la letra
            }

        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; //ignoro la letra
            }

        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; //ignoro la letra
            }

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            this.name = this.txtName.Text;
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            if (this.txtDni.Text != "")
            {
                
                this.dni = int.Parse(this.txtDni.Text);
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (this.txtPhone.Text != "")
            {
                this.phone = int.Parse(this.txtPhone.Text);
                
            }
        }

        private void dtpBirth_ValueChanged(object sender, EventArgs e)
        {
            this.birth = this.dtpBirth.Value;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (name != "" && dni != 0 && phone != 0)
            {
                try
                {
                    ADOpet.Add(new Pet(name, tipo, birth, dni, phone));

                    this.UpdateFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private string SelectPicture(string name)
        {
            string rutaBase = AppDomain.CurrentDomain.BaseDirectory;

            string rutaRelativa = @$"img\mascotas\{name}.jpg"; // Ajusta según sea necesario


            rutaRelativa = Path.GetFullPath(rutaRelativa, rutaBase);

            return rutaRelativa;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateFields()
        {
            this.txtName.Text = "";
            this.txtDni.Text = "";
            this.txtPhone.Text = "";
            this.cmbTipo.SelectedIndex = 0;

        }
    }
}
