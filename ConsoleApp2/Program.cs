using System;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;

namespace project1_dziedzicenie
{
    class Program
    {
        class shape
        {
           
            public virtual float CalculateArea()
            {
                return 0;
            }
            public virtual float CalculatePerimeter()
            {
                return 0;
            }
        }
        class rectangle : shape
        {
            private float width;
            private float height;

            public void setDimensions(float w, float h)
            {
                width = w;
                height = h;
            }
            public override float CalculateArea()
            {
                return width * height;
            }
        }
        class Circle : shape
        {
            private float radius;
            private object circRadius;

            public Circle(float radius)
            {
                this.radius = radius;
            }

            public void setRadius(float r)
            {
                radius = r;
            }

            public override float CalculateArea()
            {
                //return base.CalculateArea();
                return (float)Math.PI * radius * radius;
            }

        }
        static void Main(string[] args)
        {
           /* rectangle rect = new rectangle();

            rect.setHeight(2.5f);
            rect.setWidth(3f);

            Console.WriteLine("Pole prostokatat wynosi: " + rect.CalculateArea());

            Circle circ = new Circle();
            circ.setRadius(2.4f);
            Console.WriteLine("pole kola wynosi: " + circ.CalculateArea());

            */

            while (true)
            {
                Console.WriteLine("wybierz ksztalt do obliczenia");
                Console.WriteLine("1. prostokat");
                Console.WriteLine("2. kolo");
                Console.WriteLine("3.");
                Console.WriteLine("4.");
                Console.WriteLine("5.");
                Console.WriteLine("6. wyjscie");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: 
                        rectangle rect = new rectangle();
                        Console.Write("Podaj szerokosc: ");
                        float rectWidth = float.Parse(Console.ReadLine());
                        Console.Write("Podaj wysokosc ");
                        float rectHeight = float.Parse(Console.ReadLine());
                        rect.setDimensions(rectWidth, rectHeight);
                        Console.WriteLine("Powierzchnia prostokata: {0}", rect.CalculateArea());
                        Console.WriteLine("obwod prostokata {0}", rect.CalculatePerimeter());

                        break;
                    case 2:
                        float circleRadius = GetValidInput("podaj promien");
                        Circle circ = new Circle(circleRadius);
                        Console.WriteLine("Powierzchnia kola wynosi: " + circ.CalculateArea());
                        Console.WriteLine("obwod kola wynosi: " + circ.CalculatePerimeter());

                    case 6:
                        return;
                    default :
                        Console.WriteLine("Nieprawidlowy wybor wybierz ponownie ");
                        break;
                }

            }
            Console.ReadKey();

        }
        private static float GetValidInput(string prompt)
        {
            int result;
            while(true)
            {
                Console.WriteLine(prompt);
                if(float.TryParse(Console.ReadLine(), out result) && result > 0)
                {
                    return result;
                }else 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nieprawidlowe dane, sprobuj ponownie ");
                    Console.ResetColor();
                }
            }
        }
    }
}
