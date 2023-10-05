using System;

namespace projekt4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine(int.MinValue); //-2147483648
            Console.WriteLine(int.MaxValue); 

            Console.WriteLine(char.MaxValue);

            string firstName = "Janusz";

            Console.WriteLine(firstName.Length);

            Console.WriteLine(firstName[0]);

            string lastName = "Nowak";
            Console.WriteLine(firstName.Equals(lastName));
            Console.WriteLine("Janusz".Equals("Janusz"));
            Console.WriteLine("Janusz".Equals("janusz"));

            //#############################################

            Console.WriteLine("Podaj imię: ");
            string name = Console.ReadLine();

            while ( name.Length == 0)
            {
                Console.Clear();
                Console.WriteLine("Podaj imię: ");
                name = Console.ReadLine();
            }
            Console.WriteLine($"imię: {name}");
 
            //###########################################

            float x;
            do
            {
                Console.Clear();
                Console.WriteLine("Podaj bok a: ");
                x = float.Parse(Console.ReadLine());
            } while ( x <= 0 );

            Console.WriteLine($"Pole kwadratu o boku {x} wynosi {x*x}2f"); //f2 - 2 miejsca po przecinku

            //########################################### pole trójkąta wzór Herona

            double a, b, c;

            do
            {
                Console.Clear();
                Console.WriteLine("Podaj bok a: ");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj bok b: ");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj bok c: ");
                c = double.Parse(Console.ReadLine());
            } while(a + b > c &&  b + c > a && c + a > b);
            double p = (a + b + c) / 2;
            Console.WriteLine($"Pole trójkąta o boku {a,b,c} wynosi {Math.Sqrt(p(p - a)(p - b)(p - c))}");

        }
    }
}
