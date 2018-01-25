using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Forms.Tests
{
    [TestClass()]
    public class FormattextTests
    {
        FormatText ft = new FormatText();
        [TestMethod()]
        public void If_CreateCalculationText_text_is_correct()
        {
            string zahl1 = "56";
            string @operator = "+";
            string zahl2 = "66";
            string Text = ft.CreateCalculationText(zahl1, zahl2, @operator);
            string expected = "56 + 66";
            Assert.AreEqual(expected, Text);
        }

        [TestMethod()]
        public void If_CreateEquationText_text_is_correct()
        {
            string zahl1 = "5";
            string @operator = "*";
            string zahl2 = "5";
            int ergebnis = 25;
            string Text = ft.CreateEquationText(zahl1, zahl2, @operator, ergebnis);
            string expected = "5 * 5  = 25";
            Assert.AreEqual(expected, Text);
        }
    }
}