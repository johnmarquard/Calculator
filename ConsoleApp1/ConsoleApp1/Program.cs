using System;

namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {
            string wastun = null;
            string username = Environment.UserName;

            Console.WriteLine($"Wilkommen {username}!");
            Console.WriteLine("Bitte wählen Sie eine Rechenart: (a)ddieren (s)ubstrahieren (m)ultiplizieren (d)ividieren");
            wastun = Console.ReadLine();

            if (wastun == "a")
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
            if (wastun == "s")

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
            if (wastun == "m")

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
            if (wastun == "d")
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

            else
                Console.WriteLine("Dies ist keine gültige Eingabe");
            Console.ReadKey();

        }
    }
}

