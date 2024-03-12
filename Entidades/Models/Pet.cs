using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{

    public enum EPet
    {
        Perro,
        Gato,
        Hamster,
        Otros
    }

    public class Pet: IOwner
    {
        private int id;
        private string name;
        private string clinicHistory;
        private DateTime birth;
        private EPet tipo;

        public Pet(string name,EPet tipo ,DateTime birth, int dni, int phone)
        {
            this.name = name;
            this.tipo = tipo;
            this.birth = birth;
            this.Dni = dni;
            this.Phone = phone;
        }


        public Pet(int id, string name, EPet tipo, DateTime birth, int dni, int phone, string clinicHistory) : this(name,tipo,birth,dni,phone)
        {
            this.id = id;
            this.clinicHistory = clinicHistory;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string ClinicHistory { get => clinicHistory; set => clinicHistory = value; }
        public DateTime Birth { get => birth; set => birth = value; }
        public EPet Tipo { get => tipo; set => tipo = value; }

        //CONTRACT
        public int Dni { get ; set; }
        public int Phone { get; set; }
    }
}
