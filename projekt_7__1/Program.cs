
bool check = false;
do
{
    Console.WriteLine("podaj dwie liczby \n");
    try
    {
        Console.WriteLine("podaj x ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("podaj y ");
        int y = int.Parse(Console.ReadLine());
        if (y != 0)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Iloraz {x} / {y} = {x / y}");
            Console.ResetColor();
        }
        check = true;
    }
    catch (FormatException)
    {
        ErrorColor("podaj liczbe całkowitą ");
    }
    catch (OverflowException)
    {
        ErrorColor($"niger <{int.MinValue} ; {int.MaxValue}>");
    }
    catch (DivideByZeroException)
    {
        ErrorColor("dzielenie przez zero");
    }
    catch (Exception ex)
    {
        ///  Console.WriteLine(ex.ToString());
        Console.WriteLine(ex.ToString());
    }
    finally
    {
        Console.WriteLine("dziekujemy za skorzystanie z programu");
    }
} while (check == false);

Console.ReadKey();


static void ErrorColor(string correct)
{ 
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"błąd: {correct} ");
    Console.ResetColor();
}
    
