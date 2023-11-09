// Napisz program w C#, który wczytuje od użytkownika 5 liczb całkowitych i zapisuje je w tablicy.
// Następnie program prosi użytkownika o podanie indeksu tablicy i wyświetla liczbę znajdującą się pod tym indeksem.
// Jeśli użytkownik wprowadzi indeks spoza zakresu tablicy, program powinien zgłosić wyjątek ArgumentOutOfRangeException i wyświetlić odpowiedni komunikat.
// Jeśli użytkownik wprowadzi nieprawidłowe dane, program powinien zgłosić wyjątek FormatException i poprosić o ponowne wprowadzenie danych.
// Program powinien działać w pętli, dopóki użytkownik nie wpisze q.
// Użyj instrukcji try-catch do obsługi wyjątkówJeśli liczba jest ujemna, program powinien zgłosić wyjątek ArgumentOutOfRangeException i wyświetlić odpowiedni komunikat. 
// Jeśli użytkownik wprowadzi nieprawidłowe dane, program powinien zgłosić wyjątek FormatException i poprosić o ponowne wprowadzenie liczby. 
int[] array = new int[5];
bool isCorrect = false;
do
{
    Console.WriteLine("Podaj piec liczb calkowitych: ");
    try
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"podaj liczbe całkowitą {i+1}");
            //array[i] = int.Parse(Console.ReadLine());
            if (!int.TryParse(Console.ReadLine(), out array[i]))

            {
                i--;
            }
        }
        isCorrect = true;
    }catch(OverflowException ex)
    {
        Console.WriteLine($"błąd: podano liczbe z poza zakresu<{int.MinValue} ; {int.MaxValue}>");
    }
    catch(FormatException ex)
    {
        Console.WriteLine("Podano zły format danych");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.ToString());
    }
    finally
    {
        Console.WriteLine("nara geju");
    }
}while (!isCorrect);

int index = 0;
string input;
bool isCorrect2 = false;

do
{
    Console.WriteLine("Wprowadź index lub q jesli chcesz przerwac program");
    input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    index = int.Parse(input);
    try
    {        
            if(index > array.Length-1 || index < 0)
            {
                Console.WriteLine("Podana liczba jest mniejsz od 0 lub wieksza od ostatnigo indeksu");
            }
            Console.WriteLine($"Liczba pod indeksem {index} wynosi {array[index]}");
            isCorrect2 = true;
    }catch(FormatException ex)
    {
        Console.WriteLine("zły format danych");
    }
    catch(IndexOutOfRangeException ex)
    {
        Console.WriteLine($"nieprawidlowe dane, index musi byc miedzy 0 a {array.Length-1}");
    }
    catch(OverflowException ex)
    {
        Console.WriteLine("Podane dane wychodza poza zakres");
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}while (!isCorrect2);
