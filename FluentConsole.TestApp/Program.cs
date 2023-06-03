using System;
using System.Threading.Tasks;

namespace FluentConsoleNet.TestApp
{


    public class FastLogger
    {

        public Task LogConsole(string LogText, string Details = "", int EventId = 0)
        {

            Console.WriteLine($"Logged -> {LogText}");
            return Task.CompletedTask;
        }
    }



    internal class Program
    {

        private static FastLogger fastLogger = new FastLogger();

        static void Main(string[] args)
        {
            ConsoleHelper.AttachLogger(fastLogger);

            ConsoleHelper.Console
                          .WithFontColor(ConsoleColor.Yellow)
                          .WithBackColor(ConsoleColor.DarkGray)
                            .WriteLine(DateTime.Now.ToString())

                          .WriteLine("Shayan Firoozi")

                          .Print();

            Console.WriteLine("Finished.");

            Console.ReadLine();
        }
    }



}