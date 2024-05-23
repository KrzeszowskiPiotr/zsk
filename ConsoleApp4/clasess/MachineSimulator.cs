using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.clasess
{
    internal class MachineSimulator
    {
        private List<maszyna> maszyny = new List<maszyna>();

        public void AddMachine(maszyna maszyna)
        {
            maszyny.Add(maszyna);
        }

        public void StartAll()
        {
            if(maszyny.Count != 0)
            {
                foreach (var maszyna in maszyny)
                {
                    maszyna.Start();
                }
            }
            else
            {
                Console.WriteLine($"Brak maszyn");
            }
        }
        public void WorkAll()
        {
            if (maszyny.Count != 0)
            {
                foreach (var maszyna in maszyny)
                {
                    maszyna.Work();
                }
            }
            else
            {
                Console.WriteLine($"Brak maszyn");
            }
        }
        public void StopAll()
        {
            if (maszyny.Count != 0)
            {
                foreach (var maszyna in maszyny)
                {
                    maszyna.Stop();
                }
            }
            else
            {
                Console.WriteLine($"Brak maszyn");
            }
        }

    }
}
