using System;

namespace Calculator.App
{
    public class Formater
    {
        public string Formatadd(int zahl1,int zahl2, int result)
        {
            string build = $"{zahl1}+{zahl2}={result}";
            return build;
        }

        public string Formatremove(int zahl1, int zahl2, int result)
        {
            string build = $"{zahl1}-{zahl2}={result}";
            return build;
        }

        public string Formatmultiplikation(int zahl1, int zahl2, int result)
        {
            string build = $"{zahl1}*{zahl2}={result}";
            return build;
        }

        public string Formatdivision(int zahl1, int zahl2, int result)
        {
                string build = $"{zahl1}/{zahl2}={result}";
                return build;
            
            
        }


    }
}
