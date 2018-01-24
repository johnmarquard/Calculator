using System;

namespace Calculator.Forms
{
    public class Calculator
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

        public int Potenz(int zahl1,int zahl2)
        {
            double x = Convert.ToDouble(zahl1);
            double y = Convert.ToDouble(zahl2);
            double ergebnis1 = x * y * x;
            int ergebnis = Convert.ToInt32(ergebnis1);
            return ergebnis;

        }

    }
}
