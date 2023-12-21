using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._12._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wczytaj liczbe n: ");
            int n = int.Parse(Console.ReadLine());

            string[] names = new string[n];
            int[] ages = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"podaj imie osoby {i+1}: ");
                names[i] = Console.ReadLine();
                Console.Write($"podaj wiek osoby {i+1}: ");
                ages[i] = int.Parse(Console.ReadLine());
            }
            List<string> namesWithStartsA = new List<string>();
            for(int i = 0; i < n; i++) 
            {
                if(names[i].StartsWith("A"))
                {
                    namesWithStartsA.Add(names[i]);
                }
            }

            Dictionary<string, int> Adults = new Dictionary<string, int>();
            for(int i = 0; i < n; i++)
            {
                if(ages[i]>=18)
                {
                    Adults.Add(names[i],ages[i]);
                }
            }

            Console.WriteLine($"Tablica imion i wikow: ");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"{names[i]} - {ages[i]}");
            }

            Console.WriteLine("imiona ktore zaczynaja sie na litere A: ");
            foreach(string name in namesWithStartsA)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("imiona osob ktore sa pelnoletnie: ");

            foreach(var name in Adults)
            {
                Console.WriteLine($"{name.Key} - {name.Value}");
            }
            Console.ReadKey();
        }
    }
}
