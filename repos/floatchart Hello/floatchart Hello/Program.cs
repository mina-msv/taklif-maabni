using System;

namespace floatchart_Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            String name;
            Console.WriteLine("Plz enter ur name:");
            name = Console.ReadLine();
            Console.WriteLine("Hello" + name);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
