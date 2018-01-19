using System;
namespace Calculator.App
{
    public class Communicator
    {
        IWriter _writer;
        public Communicator(IWriter writer)
        {
            _writer = writer;

            Console.ForegroundColor = ConsoleColor.Red;
        }

        public void Tell(string message)
        {
            Tell(message, false);
        }

        public void Tell(string message, bool waitForInput)
        {
         _writer.WriteLine(message);
        if (waitForInput)
            {
                Console.ReadLine();
            }
        }

        public void Tell(string message, bool waitForInput, bool waitForTime)
        {
            _writer.WriteLine(message);
            if (waitForInput)
            {
                Console.ReadLine();
            }
            if (waitForTime)
            {
                System.Threading.Thread.Sleep(500);
            }


        }

        public string Ask(string question)
        {
            _writer.WriteLine(question);
            string answer = Console.ReadLine();
            return answer;
        }

        public int AskForNumber(string question)
        {
            int answer = Convert.ToInt32(Ask(question));
            return answer;
        }
    }
        
}





