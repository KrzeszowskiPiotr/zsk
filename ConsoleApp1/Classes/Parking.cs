using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    internal class Parking
    {
        public string Name { get; set; }
        public Car[] Cars { get; set; }

        public void AddCar(Car car)
        {
            for (int i = 0; i < Cars.Length; i++)
            {
                if (Cars[i] == null)
                {
                    Cars[i] = new Car();
                    Console.WriteLine($"dodano samochód na miejsce o numerze {i}");
                    return;
                }

            }
            Console.WriteLine("brak miejsc parkingowych");
        }
        public void RemoveCar(int i)
        {
            if (i >= 0 && i < Cars.Length)
            {
                if (Cars[i] != null)
                {
                    Cars[i] = null;
                    Console.WriteLine($"Samochód został usunięty z miejsca numer {i}");
                }
                else
                {
                    Console.WriteLine("W podanym mijescu parkingowym nie ma samochodu");
                }
            }
            else
            {
                Console.WriteLine("podany indeks jest nieprawidlowy lub miejsce jest puste");
            }
        }
        public void ShowCars()
        {
            Console.WriteLine($"Parking {Name} ma {Cars.Length} miejsc parkingowych");
            for(int i = 0;i < Cars.Length;i++)
            {
                if (Cars[i] != null)
                {
                    Console.WriteLine($"Miejsce parkingowe numer {i} jest zajęte");
                    Cars[i].ShowInformation();
                }
                else
                {
                    Console.WriteLine($"Miejsce parkingowe numer {i} jest wolne");
                }
            }
        }
    }
}
