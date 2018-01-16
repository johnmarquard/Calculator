using System;

namespace ConsoleApp1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Willkommen!");
            Console.WriteLine("Bitte geben Sie die erste Zahl ein:");
            int zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie die zweite Zahl ein:");
            int zahl2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(zahl1+zahl2);



            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }
}
