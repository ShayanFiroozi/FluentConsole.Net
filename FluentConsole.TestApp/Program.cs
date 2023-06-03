using FluentConsoleNet.ConsoleExtension;
using System;
using System.Collections.Generic;
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



    internal static class Program
    {

        private static readonly FastLogger fastLogger = new FastLogger();

        static void Main(string[] args)
        {
            FluentConsole.AttachLogger(fastLogger);


            while (true)
            {
                Task.Run(() =>
                {
                    FluentConsole.Console
                              .WithFontColor(ConsoleColor.Yellow)
                              .WithBackColor(ConsoleColor.DarkGray)
                                .Write(DateTime.Now.ToString())
                                .AddSpace(1)

                              .WriteLine("Shayan Firoozi")
                              .AddCharacter('*', 20)
                              .AddLineBreak(5).Print();

                    FluentConsole.Console.AddLineBreak(5).Print();

                    FluentConsole.Console
                             .WithFontColor(ConsoleColor.Yellow)
                             .WithBackColor(ConsoleColor.DarkGray)
                               .Write(DateTime.Now.ToString())
                               .AddSpace(1)

                             .WriteLine("Shayan Firoozi")
                             .AddCharacter('*', 20)
                             .AddLineBreak(5).PrintAndLog();

                    // Bugs here ... seems to be not thread-safe !!!
                    List<string> greatest = new List<string>() { "David Gilmour", "Soe Satriani", "Stevie Ray Vaughan", "Slash !", "Paul Mccartney" };

                    greatest.PrintLineOnConsole();



                });

                Task.Delay(1).GetAwaiter().GetResult();

                if (Console.KeyAvailable)
                {
                    return;
                }
            }




            Console.WriteLine("Finished.");

            Console.ReadLine();
        }
    }



}