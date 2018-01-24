using System;

namespace Calculator.Forms
{
    public class Calculator
    {

        public int Addition(int zahl1, int zahl2)
        {
            int ergebnis = zahl1 + zahl2;
            return ergebnis;
        }

        public int Subtraktion(int zahl1, int zahl2)
        {
            int ergebnis = zahl1 - zahl2;
            return ergebnis;
        }

        public int Multiplikation(int zahl1, int zahl2)
        {
            int ergebnis = zahl1 * zahl2;
            return ergebnis;
        }

        public int Division(int zahl1, int zahl2)
        {
            int ergebnis = zahl1 / zahl2;
            return ergebnis;
        }

        public int Potenz(int zahl1, int zahl2)
        {
            int ergebnis = zahl1;
            for (int i = 1; i < zahl2; i++)
            {
                ergebnis = ergebnis * zahl1;
            }

            return ergebnis;

        }

        public int Wurzel(int zahl1)
        {
            double x = Convert.ToDouble(zahl1);
            double ergebnis1 = Math.Sqrt(x);
            int ergebnis = Convert.ToInt32(ergebnis1);
            return ergebnis;
        }
        

    }
}
