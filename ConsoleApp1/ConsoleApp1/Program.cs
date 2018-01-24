using System;
namespace Calculator.App
{
    class Program
    {
        static IWriter _writer = new ConsoleWriter();
        static Communicator communicator = new Communicator(_writer);
        static Calculator calculator = new Calculator();
        static Formater connector = new Formater();

        static void Main(string[] args)
        {
            //Strings
            string wastun = null;
            string username = Environment.UserName;
            communicator.Tell($"Willkommen { username}!",false,true);
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
                try
                {
                    int zahl1 = communicator.AskForNumber("Bitte geben Sie die erste Zahl ein:");
                    int zahl2 = communicator.AskForNumber("Bitte geben Sie die zweite zahl ein");


                    int result = 0;

                    if (wastun == "a")
                    {
                        result = calculator.Addition(zahl1, zahl2);
                        communicator.Tell(connector.Formatadd(zahl1, zahl2, result));
                    }

                    if (wastun == "s")
                    {
                        result = calculator.Subtraktion(zahl1, zahl2);
                        communicator.Tell(connector.Formatremove(zahl1, zahl2, result));
                    }

                    if (wastun == "m")
                    {
                        result = calculator.Multiplikation(zahl1, zahl2);
                        communicator.Tell(connector.Formatmultiplikation(zahl1, zahl2, result));
                    }

                    if (wastun == "d")
                    {
                        try
                        {
                            result = calculator.Division(zahl1, zahl2);
                            communicator.Tell(connector.Formatdivision(zahl1, zahl2, result));
                        }
                        catch (System.DivideByZeroException)
                        {
                            communicator.Tell("Es kann nicht durch 0 geteilt werden");
                        }
                    }
                }
                catch 
                {
                    communicator.Tell("Es kann nur mit Zahlen gerechnet werden");

                }

            }
            
        }
        
    }
        
}





