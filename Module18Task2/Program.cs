using System;

namespace Module18Task2
{
    class Program
    {
        static ILogger Logger { get; set; }
        static void Main(string[] args)
        {
            Logger = new Logger1();
            var calc = new Calculator(Logger);
            try
            {
                calc.Addition(Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()));
            }
            catch(FormatException message)
            {
                Logger.Error(message.Message);
            }

            string cringe = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Red;           
            Console.ReadKey();
        }
              
        public interface ILogger
        {
            void Event(string message);
            void Error(string message);
        }
        public class Logger1 : ILogger
        {
            public void Error(string message)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
            }

            public void Event(string message)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(message);
            }
        }
        public interface ICalculator
        {
            void Addition(int a, int b);
        }
    }
    
}
