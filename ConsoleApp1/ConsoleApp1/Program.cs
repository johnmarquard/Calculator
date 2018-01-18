using System;
namespace ConsoleApp2
{
    class Program
    {
        static Communicator communicator = new Communicator();
        static Calculator calculator = new Calculator();
        static Connector connector = new Connector();

        static void Main(string[] args)
        {
            //Strings
            string wastun = null;
            string username = Environment.UserName;
            communicator.Tell($"Willkommen { username}!",false);
            int unendlich = 0;
            while (unendlich == 0)
            {
                wastun = communicator.Ask("Bitte wählen Sie aus was sie machen möchten: (a)ddieren (s)ubstrahieren (m)ultiplizieren (d)ividieren (q)uit");
                if (wastun != "a" && wastun != "s" && wastun != "m" && wastun != "d" && wastun != "q")
                {
                    communicator.Tell("Dies ist keine Gültige Eingabe",false);
                    System.Threading.Thread.Sleep(500);
                    continue;
                }
                if (wastun == "q")
                {
                    communicator.Tell($"Goodbye {username}!",false);
                    System.Threading.Thread.Sleep(2000);
                    return;
                }
                int zahl1 = communicator.AskForNumber("Bitte geben Sie die erste Zahl ein:");
                int zahl2 = communicator.AskForNumber("Bitte geben Sie die zweite zahl ein");
                if (wastun == "a")
                {
                    int ergebnis = calculator.Addition(zahl1, zahl2);
                    string build = connector.Verbindungplus(ergebnis,zahl1,zahl2);
                    communicator.Tell(build);

                }
                if (wastun == "s")
                {
                    int ergebnis = calculator.Subtraktion(zahl1, zahl2);
                    string build = connector.Verbindungminus(ergebnis, zahl1, zahl2);
                    communicator.Tell(build);

                }
                if (wastun == "m")
                {
                    int ergebnis = calculator.Multiplikation(zahl1, zahl2);
                    string build = connector.Verbindungmultiplikation(ergebnis, zahl1, zahl2);
                    communicator.Tell(build);

                }
                if (wastun == "d")
                {
                    int ergebnis = calculator.Division(zahl1, zahl2);
                    string build = connector.Verbindungdivision(ergebnis, zahl1, zahl2);
                    communicator.Tell(build);

                }
            }
            

        }
        
    }
        
}





