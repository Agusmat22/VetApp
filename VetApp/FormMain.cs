using Entidades.Models;
using Entidades.Presentation;

namespace VetApp
{
    public partial class FormMain : Form
    {
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

        }

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
            this.ShowPanel(new PetsForm());

        }
    }
}
