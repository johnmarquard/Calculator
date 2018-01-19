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
                    communicator.Tell("Dies ist keine Gültige Eingabe",false,true);
                    continue;
                }

                if (wastun == "q")
                {
                    communicator.Tell($"Goodbye {username}!",false,true);
                    return;
                }

                int zahl1 = communicator.AskForNumber("Bitte geben Sie die erste Zahl ein:");
                int zahl2 = communicator.AskForNumber("Bitte geben Sie die zweite zahl ein");

                if (wastun == "a")
                {
                    communicator.Tell(connector.Verbindungplus(zahl1, zahl2));
                }

                if (wastun == "s")
                {
                    communicator.Tell(connector.Verbindungminus(zahl1,zahl2));
                }

                if (wastun == "m")
                {
                    communicator.Tell(connector.Verbindungmultiplikation(zahl1, zahl2));
                }

                if (wastun == "d")
                {
                    communicator.Tell(connector.Verbindungdivision(zahl1,zahl2));
                }
            }
            
        }
        
    }
        
}





