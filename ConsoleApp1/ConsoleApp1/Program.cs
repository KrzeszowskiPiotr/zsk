namespace ConsoleApp1
{
    enum Color
    {
        Czarny,
        Bialy,
        Czerwony
    }
    enum interiorColor
    {
        Czrny,
        Bialy,
        Czerwony
    }
    class Car
    {
        //pola
        public string brand;
        public string model; //wgl nie bezpieczne pola publiczne, nie pownnismy ich tak definiowac


        //pola prywatne
        private int _productionYear;
        private decimal _price;
        private string _color;
        private string _interiorColor;

        //wlasciwosci
        public int ProductionYear
        {
            get { return _productionYear; }
            set
            {
                if (value >= 1886 && value <= DateTime.Now.Year)
                    _productionYear = value;
                else
                    throw new ArgumentException("Rok produkcj musi byc miedzy 1886 a obecnym rokiem");
            }
        }

        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value >= 0)
                    _price = value;
                else
                    throw new ArgumentException("Cena nie moze byc ujemna");
            }
        }

        public string Color
        {
            get { return _color; }
            set
            {
                string[] allowedColor = { "czarny", "bialy", "czerwony" };
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Kolor nie moze byc pusty");

                if (Array.IndexOf(allowedColor, value.ToLower()) == -1)
                {
                    string allowedColorsList = string.Join(", ", allowedColor);
                    throw new ArgumentException($"Kolor musi byc jednym z {allowedColorsList}");
                }
                _color = value;
            }
        }

        public string InteriorColor
        {
            get { return _interiorColor; }

            set
            {
                string[] allowedColor = { "czarny", "bialy", "czerwony" };
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Kolor nie moze byc pusty");

                if (Array.IndexOf(allowedColor, value.ToLower()) == -1)
                {
                    string allowedColorsList = string.Join(", ", allowedColor);
                    throw new ArgumentException($"Kolor musi byc jednym z {allowedColorsList}");
                }
                _interiorColor = value;
            }
        }

        //kosntruktor domyslny
        public Car()
        {
            brand = "nieznana";
            model = "nieznany";
            _productionYear = 2000;
            _price = 0m;
        }

        //konstruktor parametryczny
        public Car(string brand, string model, int productionYear, decimal price, string color, string interiorColor)
        {
            this.brand = brand;
            this.model = model;
            _productionYear = ProductionYear;
            _price = Price;
            _color = Color;
            _interiorColor = InteriorColor;
        }

        public void DisplayCar()
        {
            Console.WriteLine($"auto {brand} {model} wyprodukowane {ProductionYear}r kosztuje {Price:C} ma kolor {Color} i {InteriorColor} srodek ");
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Car car = new Car("Toyota", "Yaris", 89, 2000.99M, "czarny", "czarny");
                car.DisplayCar();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Błąd: " + e.Message);
            }
        }
    }
}
