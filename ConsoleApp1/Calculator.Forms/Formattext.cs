
namespace Calculator.Forms
{
    public class FormatText
    {
        public string Textbox(string _zahl1, string _zahl2, string _operator)
        {
            string Text = $"{_zahl1} {_operator} {_zahl2}";

            return Text;
        }

        public string Textboxr(string _zahl1, string _zahl2, string _operator, int ergebnis)
        {
            string Text = $"{_zahl1} {_operator} {_zahl2}  = {ergebnis}";

            return Text;
        }
    }
}
