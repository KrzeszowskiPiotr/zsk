

using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using ConsoleApp1.Classes;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car
            {
                Brand = "Fiat",
                Model = "126p",
                Year = 1900,
                Color = Classes.Color.czerwony

            };
            Car car2 = new Car
            {
                Brand = "Ferrari",
                Model = "F430",
                Year = 2023,
                Color = Classes.Color.czerwony

            };
            Car car3 = new Car
            {
                Brand = "Audi",
                Model = "RS3",
                Year = 2024,
                Color = Classes.Color.niebieski

            };

            Parking parking1 = new Parking { Name = "center", Cars = new Car[5] };
            parking1.AddCar(car1);
            parking1.AddCar(car2);
            parking1.RemoveCar(0);
            parking1.ShowCars();




            Console.ReadLine();
        }
    }
}
