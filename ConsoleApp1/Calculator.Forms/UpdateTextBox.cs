using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Forms
{
    public class Formattext
    {
        public string Textbox(string _zahl1, string _zahl2, string _operator)
        {
            string Text = $"{_zahl1} {_operator} {_zahl2}";

            return Text;
        }

        public string Textbox(string _zahl1, string _zahl2, string _operator, int ergebnis)
        {
            string Text = $"{_zahl1} {_operator} {_zahl2}  = {ergebnis}";

            return Text;
        }
    }
}
