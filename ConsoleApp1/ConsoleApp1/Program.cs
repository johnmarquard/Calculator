using System;
namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {
            //Strings
            string wastun = null;
            string username = Environment.UserName;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Wilkommen {username}!");
            int unendlich = 0;
            while (unendlich == 0)
            {
                Console.Clear();
                Console.WriteLine("Bitte wählen Sie aus was sie machen möchten: (a)ddieren (s)ubstrahieren (m)ultiplizieren (d)ividieren (q)uit");
                wastun = Console.ReadLine();
                if (wastun != "a" && wastun != "s" && wastun != "m" && wastun != "d" && wastun != "q")
                {
                    Console.WriteLine("Dies ist keine Gültige Eingabe");
                    System.Threading.Thread.Sleep(500);
                    continue;
                }
                if (wastun == "q")
                {
                    Console.WriteLine($"Goodbye,{username}!");
                    System.Threading.Thread.Sleep(2000);
                    return;
                }
                int zahl1 = Zahl1Eingeben();
                int zahl2 = Zahl2Eingeben();
                if (wastun == "a")
                {
                    FuehreAdditionAus(zahl1, zahl2);
                }
                if (wastun == "s")
                {
                    FuerhreSubtracktionAus(zahl1, zahl2);
                }
                if (wastun == "m")
                {
                    FuerhreMultiAus(zahl1, zahl2);
                }
                if (wastun == "d")
                {
                    FuerhreDivisionAus(zahl1, zahl2);
                }
            }
            

        }
        private static void FuehreAdditionAus(int zahl1,int zahl2)
        {
            int ergebnis = zahl1 + zahl2;
            var fertig2 = $"{zahl1}+{zahl2}={ergebnis}";
            Ausgabe(fertig2);
        }
        private static void FuerhreSubtracktionAus(int zahl1, int zahl2)
        {
            int ergebnis1 = zahl1 - zahl2;
            var fertig2 = $"{zahl1}-{zahl2}={ergebnis1}";
            Ausgabe(fertig2);
        }
        private static void FuerhreMultiAus(int zahl1, int zahl2)
        {
            int ergebnis1 = zahl1 * zahl2;
            var fertig2 = $"{zahl1}*{zahl2}={ergebnis1}";
            Ausgabe(fertig2);
        }
        private static void FuerhreDivisionAus(int zahl1, int zahl2)
        {
            int ergebnis1 = zahl1 / zahl2;
            var fertig2 = $"{zahl1}/{zahl2}={ergebnis1}";
            Ausgabe(fertig2);
        }
        private static int Zahl1Eingeben()
        {
            Console.WriteLine("Bitte geben Sie die erste Zahl ein:");
            int zahl1 = Convert.ToInt32(Console.ReadLine());
            return zahl1;
        }
        private static int Zahl2Eingeben()
        {
            Console.WriteLine("Bitte geben Sie die zweite Zahl ein:");
            int zahl2 = Convert.ToInt32(Console.ReadLine());
            return zahl2;
        }
        private static void Ausgabe(string fertig2)
        {
            Console.WriteLine(fertig2);
            Console.ReadKey();
        }
    }
}



