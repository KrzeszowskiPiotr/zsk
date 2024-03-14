﻿using _14._03._2024.classes;

namespace _14._03._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region animalObjects
            Animal a1 = new Animal("Burek");
            Console.WriteLine(a1.Describe());
            a1.BirthDate = new DateTime(2000, 2, 3);
            a1.Showage();

            Animal a2 = new Animal("Mruczek", new DateTime(2020,1,10));
            Console.WriteLine(a2.Describe());
            a2.BirthDate = new DateTime(2020, 1, 10);
            a2.Showage();

            Animal a3 = new Animal("Mruczek", new DateTime(2020, 1, 10), true);
            Console.WriteLine(a3.Describe());
            a3.BirthDate = new DateTime(2020, 1, 10);
            a3.Showage();

            Animal a4 = new Animal("Mruczek", new DateTime(2020, 1, 10), true, Kind.Ssak);
            Console.WriteLine(a4.Describe());
            a4.BirthDate = new DateTime(2020, 1, 10);
            a4.Showage();

            #endregion

            List<Animal> animals = new List<Animal>();

            ShowMainMenu(animals);

            Console.ReadKey();
        }

        private static void ShowMainMenu(List<Animal> animals)
        {
            Console.Clear();
            Console.WriteLine("Witaj w programie do zarządzania zwierzętami");
            Console.WriteLine("1. Dodaj zwierze");
            Console.WriteLine("2. Pokaż listę zwierząt: ");
            Console.WriteLine("3. Pokaż szczegóły zwierzęcia");
            Console.WriteLine("4. Usuń zwierze");
            Console.WriteLine("5. Zakończ program\n");
            Console.WriteLine("Wybierz jedną z opcji: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                   AddNewAnimal(animals);
                   break;
                case "2":
                    ShowAnimalList(animals); 
                    break;
                case "3":
                    ShowAnimalDetails(animals); 
                    break;
                case "4":
                    RemoveAnimal(animals);
                    break;
                case "5":
                    Console.WriteLine("Dziękujemy za skorzystanie z programu")
                    return;
                default:
                    Console.WriteLine("nie poprawna obca nacisnij dowolny klawisz aby sprobowac ponownie");
                    Console.ReadKey();
                    ShowMainMenu(animals);
                    break;
            }
        }

        private static void AddNewAnimal(List<Animal> animals)
        {
            throw new NotImplementedException();
        }

        private static void ShowAnimalList(List<Animal> animals)
        {
            throw new NotImplementedException();
        }

        private static void ShowAnimalDetails(List<Animal> animals)
        {
            throw new NotImplementedException();
        }

        private static void RemoveAnimal(List<Animal> animals)
        {
            throw new NotImplementedException();
        }
    }
}
