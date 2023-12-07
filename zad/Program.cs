/* List<int> ints = new List<int>();
ints.Add(1);
ints.Add(-1);
ints.Add(100);

Console.WriteLine("Dlugosc listy: {0} ", ints.Count);
ints.Add(-50);
Console.WriteLine("dlugosc listy: {0}", ints.Count);

foreach (int i in ints)
{
    Console.WriteLine($"{i} ");
}
Console.WriteLine();

ints.Remove(1);

foreach (int i in ints)
{
    Console.WriteLine($"{i} ");

}
Console.WriteLine();

ints.Remove(1);

foreach (int i in ints)
{
    Console.WriteLine($"{i} ");

}
Console.WriteLine();

Console.ReadLine(); */

List<int> list = new List<int>();
for(int i = 0; i < 10; i++)
{
    Random random = new Random();
    list.Add(random.Next(1, 101));
}
foreach(int i in list)
{
    Console.WriteLine(i);
}



Console.WriteLine("-----------------------------------");





List<int> list2 = Dzielenie35(list);
foreach(int i in list2)
{
    Console.WriteLine($"{i}");
}
Console.ReadLine();



static List<int> Dzielenie35(List<int> lista)
{
    List<int> podzielne = new List<int>();
    foreach(int i in lista)
    {
        if(i%3==0 || i%5==0)
        {
            podzielne.Add(i);
        }
    }
    return podzielne;
}