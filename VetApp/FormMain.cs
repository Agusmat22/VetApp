using Entidades.Models;
using Entidades.Presentation;
using Entidades.Sql;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace VetApp
{
    public partial class FormMain : Form
    {
        private Vet vet;

        public FormMain()
        {
            InitializeComponent();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {

                List<Pet> pets = ADOpet.GetAll();

                this.vet = new Vet(pets);



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Show a form insade of content
        /// </summary>
        /// <param name="form"></param>
        private void ShowPanel(Form form)
        {
            // Eliminar cualquier control existente en el panel
            this.panelFormContent.Controls.Clear();

            // Configurar el formulario a mostrar
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            // Agregar el formulario al panel
            this.panelFormContent.Controls.Add(form);

            // Mostrar el formulario dentro del panel
            form.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.ShowPanel(new RegisterForm(new Vet(new List<Pet>())));
        }

        private void btnPets_Click(object sender, EventArgs e)
        {
            this.ShowPanel(new PetsFor(vet));

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
