using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Calculator.App.Test
{
    [TestClass]
    public class Connector_When_connecting
    {
        Connector connector = new Connector();
        Calculator calculator = new Calculator();

        [TestMethod]
        public void If_connecting_addition_Then_connetion_is_correct()
        {
            int zahl1 = 10;
            int zahl2 = 20;                                        
            var actual = connector.Verbindungplus(zahl1, zahl2);
            var expected = $"{ zahl1 }+{ zahl2}={ calculator.Addition(zahl1, zahl2)}";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void If_connecting_remove_Then_connetion_is_correct()
        {
            int zahl1 = 10;
            int zahl2 = 20;
            var actual = connector.Verbindungminus(zahl1, zahl2);
            var expected = $"{ zahl1 }-{ zahl2}={ calculator.Subtraktion(zahl1, zahl2)}";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void If_connecting_multiplication_Then_connetion_is_correct()
        {
            int zahl1 = 10;
            int zahl2 = 20;
            var actual = connector.Verbindungmultiplikation(zahl1, zahl2);
            var expected = $"{ zahl1 }*{ zahl2}={ calculator.Multiplikation(zahl1, zahl2)}";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void If_connecting_division_Then_connetion_is_correct()
        {
            int zahl1 = 10;
            int zahl2 = 20;
            var actual = connector.Verbindungdivision(zahl1, zahl2);
            var expected = $"{ zahl1 }/{ zahl2}={ calculator.Division(zahl1, zahl2)}";
            Assert.AreEqual(expected, actual);
        }
    }
}
