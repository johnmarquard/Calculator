using System;
namespace ConsoleApp2
{
    class Communicator
    {
        public Communicator()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }

        public void Tell(string message)
        {
            Tell(message,true);
        }

        public void Tell(string message,bool waitForInput)
        {
            Console.WriteLine(message);
            if (waitForInput)
            {
                Console.ReadLine();
            }
            

        }

        public string Ask(string question)
        {
            Console.WriteLine(question);
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





