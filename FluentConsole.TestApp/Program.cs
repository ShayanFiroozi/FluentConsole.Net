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

        static async Task Main(string[] args)
        {

            FluentConsole.AttachLogger(fastLogger);


            while (true)
            {
               await Task.Run(() =>
                {

                    FluentConsole.Console
                                 .AddLineBreak(2)
                                 .WithFontColor(ConsoleColor.Yellow)
                                 .WriteLine("This is a multi color example : ")
                                 .Print();

                    FluentConsole.Console
                                 .WithFontColor(ConsoleColor.Green)
                                 .Write(DateTime.Now.ToString())
                                 .ResetColor()
                                 .AddSpace(1)
                                 .WriteLine("Shayan Firoozi")
                                 .Print();

                });

               await Task.Run(() =>
                {


                    FluentConsole.Console
                    .AddLineBreak(2)
                    .WithFontColor(ConsoleColor.Yellow)
                    .WriteLine("This is a List<string> example : ")
                    .Print();


                    List<string> greatest = new List<string>() { "David Gilmour", "Joe Satriani", "Stevie Ray Vaughan", "Slash !", "Paul Mccartney" };

                    greatest.WriteLineOnConsole();

                });

               await Task.Run(() =>
                {


                    FluentConsole.Console
                    .AddLineBreak(2)
                    .WithFontColor(ConsoleColor.Yellow)
                    .WriteLine("This is a List<int> example ( formatted ): ")
                    .Print();


                    List<int> numbers = new List<int>() { 1364, 1368, 1998, 1985, 1989 };

                    numbers.WriteLineOnConsole(true);

                });

              await  Task.Run(() =>
                {


                    FluentConsole.Console
                    .AddLineBreak(2)
                    .WithFontColor(ConsoleColor.Yellow)
                    .WriteLine("This is a List<int> example ( unformatted ): ")
                    .Print();


                    List<int> numbers = new List<int>() { 1364, 1368, 1998, 1985, 1989 };

                    numbers.WriteLineOnConsole(false);

                });



                Task.Delay(2_000).GetAwaiter().GetResult();


                if (Console.KeyAvailable)
                {
                    return;
                }

            }

        }
    }



}