using System;

namespace ConsoleApp2
{
    class Calculator
    {

        public int Addition(int zahl1,int zahl2)
        {
            int ergebnis = zahl1 + zahl2;
            return ergebnis;
        }

        public int Subtraktion(int zahl1,int zahl2)
        {
            int ergebnis = zahl1 - zahl2;
            return ergebnis;
        }

        public int Multiplikation(int zahl1,int zahl2)
        {
            int ergebnis = zahl1 * zahl2;
            return ergebnis;
        }

        public int Division(int zahl1,int zahl2)
        {
            int ergebnis = zahl1 / zahl2;
            return ergebnis;
        }
    }
}
