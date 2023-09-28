using System;

namespace project_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "imIę I nAzwiskO";
            Console.WriteLine(message);
            

            string messageUppercase = message.ToUpper();
            Console.WriteLine(messageUppercase);

            string messageLowercase = message.ToLower();
            Console.WriteLine(messageLowercase);

            string name = message.Substring(1);
            Console.WriteLine(name);

            string name1 = message.Substring(0, 4);
            Console.WriteLine(name1);

            Console.WriteLine(name1[0]);

            Console.WriteLine(message.Substring(0,1).ToUpper() + message.Substring(1).ToLower());
            Console.Write(message[0].ToString().ToUpper() + message.Substring(1).ToLower();
        }
    }
}