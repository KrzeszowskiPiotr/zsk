using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    enum Color
    {
        czerwony,
        zielony,
        niebieski
    }

    internal class Car
    {
        


        public string Brand { get;set; }
        public string Model { get;set; }
        public ushort Year { get;set; }
        public Color Color { get;set; }

        public void ShowInformation()
        {
            Console.WriteLine($"To jest {this.Brand} {this.Model} z {this.Year}, kolor: {this.Color}");
        }
    }
}
