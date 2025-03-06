using System.Xml.Linq;

namespace ConsoleApp3
{
    internal class Program
    {
        public enum AnimalSpecies
        {
            Cat,
            Dog,
            Lion,
            Tiger
        }
        public class Animal
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public AnimalSpecies Species { get; set; }
            public bool IsWild { get; set; }
            public List<string> Traits { get; set; }
            public Dictionary<string,string> Attributes { get; set; }

            public event Action<string> AnimalTraitAdded;
            public event Action<string> AnimalAttributeAdded;
            public event Action<string> AnimalCreated;
            public event Action<string> AnimalStatusChanged;
            public Animal()
            {

            }
            public Animal(string name, int age, AnimalSpecies species, bool isWild)
            {
                Name = name;
                Age = age;
                Species = species;
                IsWild = isWild;
                Traits = new List<string>();
                Attributes = new Dictionary<string,string>();

                AnimalCreated?.Invoke($"{Name} został stworzony");
            }
            public void AddTraits(string trait)
            {
                Traits.Add(trait);
                AnimalTraitAdded?.Invoke($"cecha {trait} zostala dodana do zwierzecia {Name}");
            }
            public void AddAttributes(string key, string value)
            {
                Attributes.Add(key, value);
                AnimalAttributeAdded?.Invoke($"Atrybut {key}: {value} został dodany do zwierzecia {Name}");
            }
            public void ChangeStatus(bool isWild)
            {
                IsWild = isWild;
                if (IsWild)
                {
                    AnimalStatusChanged?.Invoke($"Status zwierzecia {Name} zostalo zmienione na: Dzikie");
                }
                else
                {
                    AnimalStatusChanged?.Invoke($"Status zwierzecia {Name} zostalo zmienione na: nie Dzikie");
                }   
            }
            public void ToString()
            {
                Console.Write($"{Name}, {Age} years old, {Species}, Wild: {IsWild}, ");
                foreach (var trait in Traits)
                {
                    Console.Write($"{trait} ");
                }
            }
        }
        static void Main(string[] args)
        {
            Animal cwel = new Animal();
            cwel.AnimalCreated += Console.WriteLine;
            cwel = new Animal("cwel", 5, AnimalSpecies.Dog, false);

            // Przypisujemy pozostałe zdarzenia
            cwel.AnimalTraitAdded += Console.WriteLine;
            cwel.AnimalAttributeAdded += messge => Console.WriteLine(messge);
            cwel.AnimalStatusChanged += Console.WriteLine;

            cwel.AddTraits("jest cwelem");
            cwel.ToString();
        }
    }
}
