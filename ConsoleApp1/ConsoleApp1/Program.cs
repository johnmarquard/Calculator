using System;
using System.IO;
namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {
            //Strings
            string isad = null;
            string wastun = null;
            string username = Environment.UserName;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Wilkommen {username}!");
            Console.WriteLine("Bitte wählen Sie aus was sie machen möchten: (a)ddieren (s)ubstrahieren (m)ultiplizieren (d)ividieren (q)uit");
            wastun = Console.ReadLine();
            if (wastun == "a")
            {
                FuehreAdditionAus();
                return;
            }
            if (wastun == "s")
            {
                FuerhreSubtracktionAus();
                return;
            }
            if (wastun == "m")
            {
                FuerhreMultiAus();
                return;
            }
            if (wastun == "d")
            {
                FuerhreDivisionAus();
                return;
            }
            if (wastun == "q")
            {
                Console.WriteLine($"Goodbye,{username}!");
                System.Threading.Thread.Sleep(2000);
                return;
            }
            else
            {
                Console.WriteLine("Dies ist keine Gültige Eingabe");
                System.Threading.Thread.Sleep(500);
                return;
            }
        } 
    private static void FuehreAdditionAus()
    {
        Console.WriteLine("Bitte geben Sie die erste Zahl ein:");
        int zahl1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Bitte geben Sie die zweite Zahl ein:");
        int zahl2 = Convert.ToInt32(Console.ReadLine());
        int ergebnis = zahl1 + zahl2;
        var fertig = $"{zahl1}+{zahl2}={ergebnis}";
        Console.WriteLine(fertig);
        Console.ReadKey();
    }
    private static void FuerhreSubtracktionAus()
    {
        Console.WriteLine("Bitte geben Sie die erste Zahl ein:");
        int zahl3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Bitte geben Sie die zweite Zahl ein:");
        int zahl4 = Convert.ToInt32(Console.ReadLine());
        int ergebnis1 = zahl3 - zahl4;
        var fertig2 = $"{zahl3}-{zahl4}={ergebnis1}";
        Console.WriteLine(fertig2);
        Console.ReadKey();
    }
    private static void FuerhreMultiAus()
    {
        Console.WriteLine("Bitte geben Sie die erste Zahl ein:");
        int zahl3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Bitte geben Sie die zweite Zahl ein:");
        int zahl4 = Convert.ToInt32(Console.ReadLine());
        int ergebnis1 = zahl3 * zahl4;
        var fertig2 = $"{zahl3}*{zahl4}={ergebnis1}";
        Console.WriteLine(fertig2);
        Console.ReadKey();
    }
    private static void FuerhreDivisionAus()
    {
        Console.WriteLine("Bitte geben Sie die erste Zahl ein:");
        int zahl3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Bitte geben Sie die zweite Zahl ein:");
        int zahl4 = Convert.ToInt32(Console.ReadLine());
        int ergebnis1 = zahl3 / zahl4;
        var fertig2 = $"{zahl3}/{zahl4}={ergebnis1}";
        Console.WriteLine(fertig2);
        Console.ReadKey();
    }
}

}