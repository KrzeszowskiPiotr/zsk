namespace ConsoleApp2;
using System;
using System.Collections.Generic;

// Enum definiujący gatunki zwierząt


// Program główny
internal class Program
{
    public enum AnimalSpecies
    {
        Cat,
        Dog,
        Lion,
        Tiger
    }

    // Klasa Animal
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public AnimalSpecies Species { get; set; }
        public bool IsWild { get; set; }
        public List<string> Traits { get; set; }
        public Dictionary<string, string> Attributes { get; set; }

        // Wydarzenia
        public event Action<string> AnimalTraitAdded;
        public event Action<string> AnimalAttributeAdded;
        public event Action<string> AnimalCreated;
        public event Action<string> AnimalStatusChanged;

        public Animal(string name, int age, AnimalSpecies species, bool isWild)
        {
            Name = name;
            Age = age;
            Species = species;
            IsWild = isWild;
            Traits = new List<string>();
            Attributes = new Dictionary<string, string>();

            // Wywołanie zdarzenia utworzenia zwierzęcia
            AnimalCreated?.Invoke($"{name} został stworzony.");
        }

        // Metoda do dodawania cech
        public void AddTrait(string trait)
        {
            Traits.Add(trait);
            AnimalTraitAdded?.Invoke($"Cecha '{trait}' została dodana do zwierzęcia {Name}.");
        }

        // Metoda do przypisywania atrybutów
        public void AddAttribute(string key, string value)
        {
            Attributes.Add(key, value);
            AnimalAttributeAdded?.Invoke($"Atrybut '{key}: {value}' został dodany do zwierzęcia {Name}.");
        }

        // Metoda do zmiany statusu dzikości
        public void ChangeWildStatus(bool isWild)
        {
            IsWild = isWild;
            string status = isWild ? "Dzikie" : "Nie dzikie";
            AnimalStatusChanged?.Invoke($"Status zwierzęcia {Name} zmieniony na: {status}.");
        }

        // Metoda do wyświetlania informacji o zwierzęciu
        public override string ToString()
        {
            return $"{Name}, {Age} years old, {Species}, Wild: {IsWild}, Traits: {string.Join(", ", Traits)}";
        }
    }
    static void Main(string[] args)
    {
        // Subskrypcja zdarzeń
        Animal leo = new Animal("Leo", 5, AnimalSpecies.Lion, true);
        leo.AnimalTraitAdded += Console.WriteLine;
        leo.AnimalAttributeAdded += message => Console.WriteLine(message);
        leo.AnimalCreated += message => Console.WriteLine(message);  // Subskrypcja zdarzenia
        leo.AnimalStatusChanged += message => Console.WriteLine(message);

        leo.AddTrait("Strong");
        leo.AddTrait("Fierce");
        leo.AddAttribute("Color", "Golden");
        leo.ChangeWildStatus(false);

        Animal milo = new Animal("Milo", 3, AnimalSpecies.Cat, false);
        milo.AnimalTraitAdded += Console.WriteLine;
        milo.AnimalAttributeAdded += Console.WriteLine;
        milo.AnimalCreated += message => Console.WriteLine(message);  // Subskrypcja zdarzenia
        milo.AnimalStatusChanged += Console.WriteLine;

        milo.AddTrait("Playful");
        milo.AddAttribute("Color", "Gray");
        milo.ChangeWildStatus(true);

        Console.WriteLine(leo);
        Console.WriteLine(milo);
    }
}