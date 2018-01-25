
namespace Calculator.Forms
{
    public class FormatText
    {
        public string CreateCalculationText(string zahl1, string zahl2, string @operator)
        {
            string Text = $"{zahl1} {@operator} {zahl2}";

            return Text;
        }

        public string CreateEquationText(string zahl1, string zahl2, string @operator, int ergebnis)
        {
            string Text = $"{zahl1} {@operator} {zahl2}  = {ergebnis}";

            return Text;
        }
    }
}
