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
                          .Write(DateTime.Now.ToString()).WithColor(ConsoleColor.Green)
                          .Write(" Shayan")
                          .WriteLine(" Firoozi").WithColor(ConsoleColor.Blue)
                          .WriteLine("1402")
                          .WithColor(ConsoleColor.Red)
                          .Print();

            Console.WriteLine("Finished.");
        }
    }



}