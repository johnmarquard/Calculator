using System;

namespace ConsoleApp2
{
    class Connector
    {
        public string Verbindungplus(int ergebnis,int zahl1,int zahl2)
        {
            string build = $"{zahl1}+{zahl2}={ergebnis}";
            return build;
        }

        public string Verbindungminus(int ergebnis, int zahl1, int zahl2)
        {
            string build = $"{zahl1}-{zahl2}={ergebnis}";
            return build;
        }

        public string Verbindungmultiplikation(int ergebnis, int zahl1, int zahl2)
        {
            string build = $"{zahl1}*{zahl2}={ergebnis}";
            return build;
        }

        public string Verbindungdivision(int ergebnis, int zahl1, int zahl2)
        {
            string build = $"{zahl1}/{zahl2}={ergebnis}";
            return build;
        }


    }
}
