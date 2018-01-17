using System;
using System.IO;
namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {

                string str = Path.GetRandomFileName();
                str = str.Replace(".", "");
            string strraw = Convert.ToString(str);
                string key = null;
            string isad = null;
            string wastun = null;
            string username = Environment.UserName;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string pathkey = $"C:/Users/{username}/Desktop/key.txt";
            Console.WriteLine($"Wilkommen {username}!");
            Console.WriteLine("Sollen Addons Aktiviert werden y/n?");
            isad = Console.ReadLine();
            if (isad == "y")
            { 
                System.IO.File.WriteAllText(pathkey, str);
            Console.WriteLine("Bitte geben sie einen Aktivierungs-Key ein");
            key = Console.ReadLine();
                if (key == strraw)
                {
                    Console.Clear();


                    Console.WriteLine("Bitte wählen Sie eine Rechenart: (a)ddieren (s)ubstrahieren (m)ultiplizieren (d)ividieren (q)uit");
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
                        return;
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
                        return;
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
                        return;
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

                        Console.Clear();
                    }
                }
            }
            if (isad == "n")
                
            {
                Console.WriteLine("Bitte wählen Sie eine Rechenart: (a)ddieren (s)ubstrahieren (q)uit");
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
                    return;
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
                    return;
                }
                
                }

                if (wastun == "q")
            {   Console.WriteLine($"Goodbye, {username}!");
                System.Threading.Thread.Sleep(2000);
                return;
            }

            else
                {
                    Console.WriteLine("Dies ist keine gültige Eingabe");
                Console.WriteLine($"Goodbye, {username}!");
                System.Threading.Thread.Sleep(2000);
                return;
            }
            }
        }
    }