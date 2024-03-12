using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Models;

namespace Entidades.Presentation
{

    public class Vet
    {
        private List<Pet> pets;


        public Vet()
        {
            this.pets = new List<Pet>();
        }

        public Vet(List<Pet> pets)
        {
            this.pets = pets;
        }

        public List<Pet> Pets { get => pets; set => pets = value; }

        public static string GetUrlImage(string name)
        {
            
            string rutaBase = AppDomain.CurrentDomain.BaseDirectory;

            string rutaRelativa = @$"img\mascotas\{name}.jpg"; // Ajusta según sea necesario


            rutaRelativa = Path.GetFullPath(rutaRelativa, rutaBase);

            return rutaRelativa;

            
        }

        public static string GenerateClinicHistory(string message)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(new string('-',30));
            sb.AppendLine("");

            sb.AppendLine($"Fecha {DateTime.Now.ToString("dd/mm/yyyy")}");
            sb.AppendLine("");

            sb.AppendLine(message);

            sb.AppendLine("");

            return sb.ToString();
        }


    }
}
