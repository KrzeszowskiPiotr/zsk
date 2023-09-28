using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("programowanie");
            Console.WriteLine(" w języku c#");

            /*
             komentarz w wielu liniach
             */
            //typy danych
            /*
             * byte 0-255 (8 bitów => 1 bajt)
             * sbyte -128-127 (8 bitów => 1 bajt)
             * 
             * short -32768 - 32767 (16 bitów => 2 bajty) Int16 == short
             * ushort 0-65535 (16 bitów => 2 bajty)
             * 
             * int -2 147 483 648 do 2 146 483 647 (32 bity = 4 bajty)
             * uint 4 294 967 295 (int bez znaku, u jak unsigned)
             * 
             * Int64 => System.Int64 => long
             * 
             * long (64bity => 8 bajtów) -9 223 372 036 854 775 808 - 9 223 372 036 854 775 808
             * ulong (64 bity => 8 bajtów) 0 - 18 446 744 073 709 551 615
             * 
             * float -3,4 * 10^38 -3,4 * 10^38 (32 bity, bajty)
             * double (64 bity, 8 bajtów)
             * decinal(9128 bitów, 1141 bajtów)
             * 
             * char U+0000 do U+FFFF (16 bitowy znak z tablicy Unicode)
             * string
             * 
             * bool(8 bitów, 1 bajt)
             */
            byte b = 0;
            Console.WriteLine("Zmienna b wynosi: " + b);

            sbyte sb = 127;
            Console.WriteLine($"Znuebba sb wynosi: {sb}");

            ushort us = 10000;
            short s = -20000;
            Console.WriteLine("Zmienna s wynosi: {0}, zmienna us wynosi {1}", s, us);

            Int16 i = 32767; // short
            Int16 i2 = -32768; // short

            System.Int64 i3 = 200000000000;

            int i4 = 10;
            Int32 i4 = 10;
            System.Int32 i4 = 10;

            Console.WriteLine("Rozmiar typu bool: "+sizeof(bool)); //bajt

            float f = 10.5F;
            Console.WriteLine(f);

            float f1 = 10;
            Console.WriteLine("f1 wynosi: " + f1);
            Console.WriteLine("wielkość: "sizeof(float));

            long L = 10;
            Console.WriteLine(L);

            ulong ul = 10;
            Console.WriteLine(ul);

            Console.WriteLine("float:" + sizeof(float));//4 bajty 32 bity
            Console.WriteLine("double:" + sizeof(double));//8 bajtów 64 bity
            Console.WriteLine("decimal:" + sizeof(deciaml));//16 bajtów 128 bity


            Console.ReadKey();
        }
    }
}
