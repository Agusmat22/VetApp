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

        public Vet(List<Pet> pets)
        {
            this.pets = pets;
        }

        public List<Pet> Pets { get => pets; set => pets = value; }
    }
}
