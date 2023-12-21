using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj n: ");
            int n = int.Parse(Console.ReadLine());

            string[] names = new string[n];
            int[] ages = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"podaj imie osoby {i + 1} ");
                names[i] = Console.ReadLine();
                Console.WriteLine($"podaj wiek osoby {i + 1}");
                ages[i] = int.Parse(Console.ReadLine());
            }
            IEnumerable<string> namesA =
                from name in names
                where name.StartsWith("A")
                select name;
        }
    }
}
/*
 * Zadanie: Napisz program w języku C#, który:
 Wczytuje liczbę n, oznaczającą ilość osób, których dane chcesz wprowadzić.
 Tworzy tablicę imion i wieków tych osób, wczytując je z konsoli.
 Tworzy listę imion zaczynających się na literę A, używając wyrażeń LINQ.
 Tworzy słownik par (imie, wiek) dla osób pełnoletnich, używając wyrażeń LINQ.
 Wypisuje zawartość tablicy, listy i słownika na konsoli, używając funkcji pomocniczych.
Wskazówki:
 Użyj funkcji int.Parse lub int.TryParse, aby zamienić ciąg znaków na liczbę całkowitą.
 Użyj metody StartsWith z parametrem StringComparison, aby sprawdzić, czy ciąg
znaków zaczyna się od określonego znaku lub ciągu znaków, niezależnie od wielkości
liter.
 Użyj metody Zip, aby połączyć dwie sekwencje w jedną sekwencję par.
 Użyj metod Where, ToList i ToDictionary, aby filtrować, sortować i transformować
dane za pomocą wyrażeń LINQ.
 Użyj pętli for lub foreach, aby iterować po elementach kolekcji.
 Użyj znaku $, aby tworzyć łańcuchy znaków interpolowanych, które mogą zawierać
wartości zmiennych lub wyrażeń.
*/
