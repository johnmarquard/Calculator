using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using NSubstitute;

namespace Calculator.App.Test
{ [TestClass]
    public class Communicator_When_communicating
    {
        [TestMethod]
        public void If_communicator_tell_Then_result_is_message()
        {
            var fake = Substitute.For<IWriter>();
            Communicator communicator = new Communicator(fake);
            string message = "istrue";

            communicator.Tell(message);

            fake.Received().WriteLine(message);
        }
    }
}
