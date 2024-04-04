using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._03._2024.classes
{
    enum Kind
    {
        Ptak,
        Ryba,
        Gad,
        Płaz,
        Ssak
    }
    internal class Animal
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsMammal { get; set; }
        public Kind Kind { get; set; }
      


        public Animal(string name)
        {
            Name = name;
        }
        public Animal(string name, DateTime birthDate) : this(name)
        {
            Name = name;
            BirthDate = birthDate;
        }
        public Animal(string name, DateTime birthDate,bool isMammal) : this(name)
        {
            Name = name;
            BirthDate = birthDate;
            IsMammal = isMammal;
        }
        public Animal(string name, DateTime birthDate, bool isMammal, Kind kind ) : this(name, birthDate, isMammal) 
        {
            Name = name;
            BirthDate = birthDate;
            IsMammal = isMammal;
            Kind = kind;
        }



        public string Describe()
        {
            string description = "nazwa zwierzecia " + Name + "data urodzenia" +
                BirthDate.ToShortDateString() + "r,\n";
            if(IsMammal) 
            {
                description += "\nZwierze jest ssakiem. ";
            }
            else
            {
                description += "\n Zwierze nie jest ssakiem. ";
            }

            description += "\nrodzaj zwierzęcia: " + Kind;
            return description;
        }

        public void Showage()
        {
            int age = DateTime.Now.Year - BirthDate.Year;
            Console.WriteLine($"Wiek {Name} wynosi {age}");
        }

    }
}
