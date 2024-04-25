using System.Security.Cryptography;
using sprawdzian.classes;

namespace sprawdzian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            Dictionary<int, Animal> animalsDictionary = new Dictionary<int, Animal>();

            Animal a2 = new Animal("Dawid", HealthStatus.Ranny, Species.Pies);
            Animal a1 = new Animal("Stachu", HealthStatus.Zdrowy);
            Animal a3 = new Animal();

            while (true)
            {
                DisplayAnimals();

                switch (GetUserInput())
                {
                    case 1:
                        AddAnimal(animals, animalsDictionary);
                        break;
                    case 2:
                        DisplayAnimals(animals);
                        break;
                    case 3:
                        HealAnimal(animals,animalsDictionary);
                        break;
                    case 4:
                        GetSickl(animals,animalsDictionary);
                        break;
                    case 5:
                        AdoptAnimal(animals,animalsDictionary);
                        break;
                    case 6:
                        return;
                    default:
                        break;
                }
            }
        }
        public static void DisplayMenu()
        {
            Console.WriteLine("MENU");
            Console.WriteLine("1. Dodaj zwierze");
            Console.WriteLine("2. Wyświetl wszystkie zwierzęta");
            Console.WriteLine("3. Ulecz zwierze");
            Console.WriteLine("4. Symuluj zachorowanie zwirzęcia");
            Console.WriteLine("5. Adoptuj zwierze");
            Console.WriteLine("6. Zakończ program");
            Console.WriteLine();
            Console.WriteLine("Podaj cyfre zdarzenia które chcesz wykonać");

        }

        public static void AddAnimal(List<Animal> lista, Dictionary<int, Animal> slownik)
        {
            Console.WriteLine("Podaj imie zwierzęcia: ");
            string name = Console.ReadLine();
            Console.WriteLine("Podaj stan zdrowia zwierzecia: ");
            HealthStatus status = new HealthStatus();
            Animal animal = new Animal(name, status);
            lista.Add(animal);
            slownik[lista.Count - 1] = animal;
        }

        public static void DisplayAnimals(List<Animal> lista)
        {
            Console.WriteLine("Lista zwirzat");
            if (lista.Count > 0)
            {
                foreach (Animal animal in lista)
                {
                    Console.WriteLine($"{animal.Name} {animal.Status}");
                }
            }
            else
            {
                Console.WriteLine("Nie ma jeszcze dodanych zwierzat");
            }
        }

        public static void HealAnimal(List<Animal> lista, Dictionary<int, Animal> slownik)
        {
            Console.WriteLine("Podaj numer zwierzęcia które chcesz uleczyć");
            int numerZwierzecia = int.Parse(Console.ReadLine());
            if (slownik.TryGetValue(numerZwierzecia, out Animal animal))
            {
                animal.Status = HealthStatus.Zdrowy;
                Console.WriteLine($"Zwierze nr {numerZwierzecia} zostało wyleczone");
            }
            else
            {
                Console.WriteLine("Nie ma takiego zwierzecia");
            }
        }

        public static void GetSickl(List<Animal> lista, Dictionary<int, Animal> slownik)
        {
            Console.WriteLine("Podaj numer zwierzęcia które ma zachorowac");
            int numerZwierzecia = int.Parse(Console.ReadLine());
            if (slownik.TryGetValue(numerZwierzecia, out Animal animal))
            {
                animal.Status = HealthStatus.Chory;
                Console.WriteLine($"Zwierze nr {numerZwierzecia} zachorowało");

            }
            else
            {
                Console.WriteLine("Nie ma takiego zwierzecia");
            }
        }

        public static void AdoptAnimal(List<Animal> lista, Dictionary<int, Animal> slownik)
        {
            Console.WriteLine("Podaj numer zwierzęcia które ma zostać adoptowane");
            int numerZwierzecia = int.Parse(Console.ReadLine());
            if (slownik.TryGetValue(numerZwierzecia, out Animal animal))
            {
                slownik[numerZwierzecia] = null;
                lista[numerZwierzecia] = null;
                GC.Collect();
                Console.WriteLine("Zwierze zostało adoptowane");

            }
            else
            {
                Console.WriteLine("Nie ma takiego zwierzecia");
            }
        }

        public static int GetUserInput()
        {
            Console.WriteLine("Podaj nr działania które chcesz wykonać: ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}
