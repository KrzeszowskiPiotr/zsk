using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.clasess
{
    internal class dzwig : maszyna
    {
        public dzwig(string name) : base(name)
        {
        }
        public override void Start()
        {
            base.Start();
            Console.WriteLine($"{Name} zaczyna podnoszenie ładunku");

        }
        public void Lift()
        {
            Console.WriteLine($"{Name} podnosi ładunek");
        }
        public void Work()
        {
            Lift();
        }
    }
}
