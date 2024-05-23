using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.clasess
{
    internal class buldozer : maszyna
    {
        public buldozer(string name) : base(name)
        {
        }

        public override void Start()
        {
            base.Start();
            Console.WriteLine($"{Name} rozpoczyna równanie terenu");

        }
        //symulacja rownania terenu

        public void Flatten()
        {
            Console.WriteLine($"{Name} równa teren");
        }

        public override void Work()
        {
            Flatten();
        }
    }
}
