using Entidades.Models;
using Entidades.Presentation;
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
    public partial class PetsFor : Form
    {


        private Vet vet;
        private Pet pet;

        public PetsFor(Vet vet)
        {
            InitializeComponent();
            this.vet = vet;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PetsForm_Load(object sender, EventArgs e)
        {
            this.ChargerPetsDGV();
        }


        private void ChargerPetsDGV()
        {
            // Limpiar cualquier dato existente en el DataGridView
            dgvPets.Rows.Clear();

            // Iterar sobre la lista de objetos Pet y agregarlos como filas al DataGridView
            foreach (Pet pet in vet.Pets)
            {
                dgvPets.Rows.Add(pet.Name, pet.Birth.ToString("dd/mm/yyyy"), pet.Tipo);
            }

        }

        private void dgvPets_SelectionChanged(object sender, EventArgs e)
        {
            this.GetSelectPetDVG();
        }

        private void GetSelectPetDVG()
        {
            if (dgvPets.SelectedRows.Count > 0)
            {
                // Obtener el índice de la fila seleccionada
                int rowIndex = dgvPets.SelectedRows[0].Index;

                // Obtener el objeto Pet correspondiente a la fila seleccionada
                this.pet = vet.Pets[rowIndex];

            }
        }

        private void btnSeeMore_Click(object sender, EventArgs e)
        {

            if (this.pet is not null)
            {
                InfoForm infoForm = new InfoForm(this.pet);
                infoForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error, debe seleccionar una mascota de la fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.pet is not null)
            {
                RegisterHistoryForm registerHistoryForm = new RegisterHistoryForm(this.pet);
                registerHistoryForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error, debe seleccionar una mascota de la fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
