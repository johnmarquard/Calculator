﻿using System;
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
            TextBox1.Text = ft.Textbox(_zahl1, _zahl2, _operator);
        }

        private void OperatorUpdate(string operator_, bool _isOperatorset)
        {
            _operator = operator_;
            _isOperatorSet = true;
            TextBox1.Text = ft.Textbox(_zahl1, _zahl2, _operator);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_one(object sender, EventArgs e)
        {
            NumberButtonPressed("1");
        }

        private void Button_two(object sender, EventArgs e)
        {
            NumberButtonPressed("2");
        }

        private void Button_three(object sender, EventArgs e)
        {
            NumberButtonPressed("3");
        }

        private void Button_four(object sender, EventArgs e)
        {
            NumberButtonPressed("4");
        }

        private void Button_five(object sender, EventArgs e)
        {
            NumberButtonPressed("5");
        }

        private void Button_six(object sender, EventArgs e)
        {
            NumberButtonPressed("6");
        }

        private void Button_seven(object sender, EventArgs e)
        {
            NumberButtonPressed("7");
        }

        private void Button_eight(object sender, EventArgs e)
        {
            NumberButtonPressed("8");
        }

        private void Button_nine(object sender, EventArgs e)
        {
            NumberButtonPressed("9");
        }

        private void Button_zero(object sender, EventArgs e)
        {
            NumberButtonPressed("0");
        }

        private void Button_doit(object sender, EventArgs e)
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
                    TextBox1.Text = ft.Textboxr(_zahl1, _zahl2, _operator, ergebnis);

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

        private void Button_add(object sender, EventArgs e)
        {
            OperatorUpdate("+", false);
        }

        private void Button_multi(object sender, EventArgs e)
        {
            OperatorUpdate("*", false);
        }

        private void Button_divide(object sender, EventArgs e)
        {
            OperatorUpdate("/", false);
        }

        private void Button_subtract(object sender, EventArgs e)
        {
            OperatorUpdate("-", false);
        }

        private void Button_ec(object sender, EventArgs e)
        {
            _zahl1 = string.Empty; 
            _zahl2 = string.Empty;
            _operator = string.Empty;
            _isOperatorSet = false;
            TextBox1.Text = ft.Textbox(_zahl1, _zahl2, _operator);
        }

        private void Button_Potenz(object sender, EventArgs e)
        {
            OperatorUpdate("^", false);
        }

        private void Button_wurzel(object sender, EventArgs e)
        {
            _zahl2 = "0";
            OperatorUpdate("√", false);
            Button_doit(button10,null);
        }
    }
}
