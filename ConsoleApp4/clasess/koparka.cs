using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.clasess
{
    internal class koparka : maszyna
    {
        public koparka(string name) : base(name)
        {
            
        }
        public override void Start()
        {
            base.Start();
            Console.WriteLine($"{Name} rozpoczyna kopanie");
        }

        public void Stop(string reason)
        {
            Console.WriteLine($"{Name} została zatrzymana z powodu: {reason}");
        }
        public void Dig()
        {
            Console.WriteLine($"{Name} kopie");
        }
        public override void Work()
        {
            Dig();
        }
    }
}
