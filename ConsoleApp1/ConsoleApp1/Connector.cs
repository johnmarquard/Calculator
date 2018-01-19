using System;

namespace ConsoleApp2
{
    class Connector
    {
        static Calculator calculator = new Calculator();

        public string Verbindungplus(int zahl1,int zahl2)
        {
            string build = $"{zahl1}+{zahl2}={calculator.Addition(zahl1, zahl2)}";
            return build;
        }

        public string Verbindungminus(int zahl1, int zahl2)
        {
            string build = $"{zahl1}-{zahl2}={calculator.Subtraktion(zahl1, zahl2)}";
            return build;
        }

        public string Verbindungmultiplikation(int zahl1, int zahl2)
        {
            string build = $"{zahl1}*{zahl2}={calculator.Multiplikation(zahl1, zahl2)}";
            return build;
        }

        public string Verbindungdivision(int zahl1, int zahl2)
        {
            string build = $"{zahl1}/{zahl2}={calculator.Division(zahl1, zahl2)}";
            return build;
        }


    }
}
