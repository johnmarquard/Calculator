using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Forms.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        static Calculator calculator = new Calculator();
        [TestMethod()]
        public void If_addition_result_is_correct()
        {
            var actual = calculator.Addition(1, 2);
            var expected = 3;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void If_subtraktion_result_is_correct()
        {
            var actual = calculator.Subtraktion(100, 20);
            var expected = 80;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void If_multiplikation_result_is_correct()
        {
            var actual = calculator.Multiplikation(2, 2);
            var expected = 4;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void If_Division_result_is_correct()
        {
            var actual = calculator.Division(100, 20);
            var expected = 5;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void If_Potenz_result_is_correct()
        {
            var actual = calculator.Potenz(5, 5);
            var expected = 125;
            Assert.AreEqual(expected, actual);
        }
    }
}