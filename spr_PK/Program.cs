namespace spr_PK
{
    // grupa_2_zwierzęta

    // czesc 1:Zwierzeta
    interface IAnimal
    {
        void MakeSound();
        void Eat();
    }
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public string Owner { get; set; }

        public Animal(string name, string species, int age, string owner)
        {
            Name = name;
            Species = species;
            Age = age;
            Owner = owner;
        }
        public void Eat()
        {
            Console.WriteLine($"{Name} je");
        }
        public abstract void MakeSound();
        public string ToString()
        {
            return $"{Name} {Species} {Age} {Owner}";
        }
    }
    public class Dog : Animal
    {
        public Dog(string name, string species, int age, string owner) : base(name,species,age,owner)
        {

        }
        public override void MakeSound()
        {
           Console.WriteLine("Hau!");
        }
    }
    public class Cat : Animal
    {
        public Cat(string name, string species, int age, string owner) : base(name, species, age, owner)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine("Miau!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Burek", "Pies", 6, "Tomasz Nowak");
            Cat cat = new Cat("Mruczek", "Kot", 8, "Jakub Grzeskowiak");
            dog.Eat();
            dog.MakeSound();
            cat.Eat();
            cat.MakeSound();

            List<Animal> animals = new List<Animal>()
            {
                new Dog("Azor", "Pies", 2, "Jan Kowalski"),
                new Cat("Filemon", "Kot", 3, "Anna Nowak"),
                new Dog("Reksio", "Pies", 4, "Piotr Wiśniewski"),
                new Cat("Mruczek", "Kot", 1, "Katarzyna Zielińska"),
                dog,
                cat
            };
            Console.WriteLine();
            foreach (var animal in animals)
            {
                animal.Eat();
                animal.MakeSound();
            }

            //czesc 2: sortowanie zwierzat

            // sortowanie po wlascicielu
            Console.WriteLine("\nSortowanie po Właścicielu:  ");
            animals.Sort((a,b) => a.Owner.CompareTo(b.Owner));
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
            // sortowanie po gatunku
            Console.WriteLine("\nSortowanie po Gatunku:  ");
            animals.Sort((a, b) => a.Species.CompareTo(b.Species));
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
            //sortowanie po wieku
            Console.WriteLine("\nSortowanie po Wieku:  ");
            animals.Sort((a, b) => a.Age.CompareTo(b.Age));
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
            //sortowanie po Imieniu
            Console.WriteLine("\nSortowanie po Imieniu:  ");
            animals.Sort((a, b) => a.Name.CompareTo(b.Name));
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
            Console.WriteLine();

            //czesc 3: Menu

            string choice;
            bool t = true;
            while(t)
            {
                Console.WriteLine("\n1.Sortowanie według właściciela: \n2.Sortowanie według gatunku: \n3.Sortowanie według wieku: \n4.Sortowanie według imienia: \n5.Wyjście");
                Console.WriteLine("Podaj numer działania które chcesz wykonać");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("\nSortowanie po Właścicielu:  ");
                        animals.Sort((a, b) => a.Owner.CompareTo(b.Owner));
                        foreach (var animal in animals)
                        {
                            Console.WriteLine(animal.ToString());
                        }
                        break;
                    case "2":
                        Console.WriteLine("\nSortowanie po Gatunku:  ");
                        animals.Sort((a, b) => a.Species.CompareTo(b.Species));
                        foreach (var animal in animals)
                        {
                            Console.WriteLine(animal.ToString());
                        }
                        break;
                    case "3":
                        Console.WriteLine("\nSortowanie po Wieku:  ");
                        animals.Sort((a, b) => a.Age.CompareTo(b.Age));
                        foreach (var animal in animals)
                        {
                            Console.WriteLine(animal.ToString());
                        }
                        break;
                    case "4":
                        Console.WriteLine("\nSortowanie po Imieniu:  ");
                        animals.Sort((a, b) => a.Name.CompareTo(b.Name));
                        foreach (var animal in animals)
                        {
                            Console.WriteLine(animal.ToString());
                        }
                        break;
                    case "5":
                        t = false;
                        break;
                    default:
                        Console.WriteLine("Podano złe dane!!!!");
                        break;
                }
            }

        }
    }
}
