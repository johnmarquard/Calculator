using System;
using System.Windows.Forms;

namespace Calculator.Forms
{
    public partial class Form1 : Form
    {
        static Calculator calculator = new Calculator();
        static FormatText ft = new FormatText();
        string _zahl1 = string.Empty;
        string _zahl2 = string.Empty;
        string _operator = string.Empty;
        bool _isOperatorSet = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void NumberButtonPressed(string number)
        {
            if (_isOperatorSet)
            {
                _zahl2 = $"{_zahl2}{number}";
            }

            else
            {
                _zahl1 = $"{_zahl1}{number}";
            }
            TextBox1.Text = ft.CreateCalculationText(_zahl1, _zahl2, _operator);
        }

        private void OperatorUpdate(string operator_)
        {
            _operator = operator_;
            _isOperatorSet = true;
            TextBox1.Text = ft.CreateCalculationText(_zahl1, _zahl2, _operator);
        }

        private void ButtonNumberPressed(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                NumberButtonPressed(((Button)sender).Text);
            }           
        }

        private void Button_doit(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Calculate()
        {
            try
            {

                int zahl1 = Convert.ToInt32(_zahl1);
                int zahl2 = Convert.ToInt32(_zahl2);

                int ergebnis = 0;

                if (_operator == "+")
                {
                    ergebnis = calculator.Addition(zahl1, zahl2);
                }

                if (_operator == "-")
                {
                    ergebnis = calculator.Subtraktion(zahl1, zahl2);
                }

                if (_operator == "*")
                {
                    ergebnis = calculator.Multiplikation(zahl1, zahl2);
                }

                if (_operator == "^")
                {
                    ergebnis = calculator.Potenz(zahl1, zahl2);
                }

                if (_operator == "/")
                {
                    ergebnis = calculator.Division(zahl1, zahl2);
                }

                if (_operator == "√")
                {
                    _zahl2 = String.Empty;
                    ergebnis = calculator.Wurzel(zahl1);
                }
                TextBox1.Text = ft.CreateEquationText(_zahl1, _zahl2, _operator, ergebnis);

            }

            catch (OverflowException)
            {
                TextBox1.Text = "INVALID INPUT";
            }

            catch (FormatException)
            {
                TextBox1.Text = "The Format was wrong";
            }

            catch (DivideByZeroException)
            {
                TextBox1.Text = "Cannot divide by zero";
            }
        }

        private void ButtonOperatorPressed(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                OperatorUpdate(((Button)sender).Text);
            }
        }

        private void Button_ec(object sender, EventArgs e)
        {
            ResetCalculator();
        }

        private void ResetCalculator()
        {
            _zahl1 = string.Empty;
            _zahl2 = string.Empty;
            _operator = string.Empty;
            _isOperatorSet = false;
            TextBox1.Text = ft.CreateCalculationText(_zahl1, _zahl2, _operator);
        }

        private void Button_wurzel(object sender, EventArgs e)
        {
            CalculateSquareRoot();
        }

        private void CalculateSquareRoot()
        {
            _zahl2 = "0";
            OperatorUpdate("√");
            Calculate();
        }
    }
}
