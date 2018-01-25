using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Forms.Tests
{
    [TestClass()]
    public class FormattextTests
    {
        [TestMethod()]
        public void TextboxTest()
        {
            string _zahl1 = "56";
            string _operator = "+";
            string _zahl2 = "66";
            string Text = $"{_zahl1} {_operator} {_zahl2}";
            string expected = "56 + 66";
            Assert.AreEqual(expected, Text);
        }

        [TestMethod()]
        public void TextboxTestr()
        {
            string _zahl1 = "5";
            string _operator = "*";
            string _zahl2 = "5";
            string ergebnis = "25";
            string Text = $"{_zahl1} {_operator} {_zahl2}  = {ergebnis}";
            string expected = "5 * 5  = 25";
            Assert.AreEqual(expected, Text);
        }
    }
}