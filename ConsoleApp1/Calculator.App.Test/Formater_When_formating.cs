using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Calculator.App.Test
{
    [TestClass]
    public class Connector_When_connecting
    {
        Formater connector = new Formater();

        [TestMethod]
        public void If_formater_addition_Then_format_is_correct()
        {
            int zahl1 = 10;
            int zahl2 = 20;
            int result = 30;
            var actual = connector.Formatadd(zahl1, zahl2, result);
            var expected = $"{zahl1}+{zahl2}={result}";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void If_formater_remove_Then_format_is_correct()
        {
            int zahl1 = 20;
            int zahl2 = 10;
            int result = 10;
            var actual = connector.Formatremove(zahl1, zahl2, result);
            var expected = $"{zahl1}-{zahl2}={result}";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void If_formater_multiplication_Then_format_is_correct()
        {
            int zahl1 = 10;
            int zahl2 = 20;
            int result = 200;
            var actual = connector.Formatmultiplikation(zahl1, zahl2, result);
            var expected = $"{zahl1}*{zahl2}={result}";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void If_formater_division_Then_format_is_correct()
        {
            int zahl1 = 20;
            int zahl2 = 10;
            int result = 2;
            var actual = connector.Formatdivision(zahl1, zahl2, result);
            var expected = $"{zahl1}/{zahl2}={result}";
            Assert.AreEqual(expected, actual);
        }
    }
}
