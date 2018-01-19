using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.App.Test
{
    [TestClass]
    public class Calculator_When_calculating
    {
        Calculator calculator = new Calculator();

        [TestMethod]
        public void If_adding_Then_result_is_correct()
        {
            var actual = calculator.Addition(1, 2);
            var expected = 3;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void If_removing_Then_result_is_correct()
        {
            var actual = calculator.Subtraktion(10, 5);
            var expected = 5;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void If_multiplication_Then_result_is_correct()
        {
            var actual = calculator.Multiplikation(10, 5);
            var expected = 50;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void If_divide_Then_result_is_correct()
        {
            var actual = calculator.Division(10, 5);
            var expected = 2;
            Assert.AreEqual(expected, actual);
        }
    }
}
