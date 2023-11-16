using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] tabA = CreateArray("takA");
            if(tabA != null)
            {
                SetArray = (takA, "takA");
                DisplayAraay(takA, "takA");
            }
       


            public static int[] CreateArray(string name)
            {
                do
                {
                    bool IsCorrect = false;
                    Console.WriteLine($"Podaj rozmiar tablicy <0;{int.MaxValue}: ");
                    int rozmiar
                 try
                    {
                        int rozmiar = int.Parse(Console.ReadLine());
                        if (rozmiar <= 0)
                        {
                            throw new ArgumentException("rozmiar tablicy musi byc wiekszy od zera")
                        }
                        IsCorrect = true;
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"wystapil blad: {ex.Message}");
                        return null;
                    }
                    int[] array = new int[rozmiar];
                    return array;
                } while (!IsCorrect);
            }

            public static void SetArray(int[] array, string name);
            {
                Console.WriteLine($"podaj elementy tablicy {name}");
                for (int i = 0; i < args.Length; i++)
                {
                    Console.WriteLine($"podaj element tablicy {i + 1}: ");
                    try
                    {
                        array[i] = int.Parse(Console.ReadLine());
                    }catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        i--;
                    }
                }
            }
            public static void DisplayAraay(int[] array, string name)
            {
                Console.WriteLine($"Wyświetlanie zawartości tablicy {name}")
                int i = 0;
                foreach (int element in array)
                {
                    Console.WriteLine($"{name}[{i}]:  {element}");
                    i++;
                }
            }






/* funkcja statyczna, która pozwala wprowadzić rozmiar tablicy i nazwę CreateArray()
funkcja statyczna, która ustawia elementy tablicy SetArray()
funkcja statyczna, która wyświetla zawartość tablicy DisplayArray() */
