using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprawdzian.classes
{
    enum Species
    {
        Pies,
        Kot,
        Królik
    }

    enum HealthStatus
    {
        Zdrowy,
        Chory,
        Ranny
    }
    internal class Animal
    {
       
        public string Name { get; set; }
        public HealthStatus Status { get; set; }
        public Species Species { get; set; }
     
        public Animal()
        {
           Status = HealthStatus.Zdrowy;
        }

        public Animal(string name, HealthStatus status)
        {
            Name = name;
            Status = status;
        }

        public Animal(string name, HealthStatus status, Species species) : this(name, status)
        {
            name = "Azor";
            status = HealthStatus.Zdrowy;
            species = Species.Pies;
        }

        ~Animal()
        {
            Console.WriteLine("Usunięto zwierzaka z pamięci");
        }


        

    }
}
