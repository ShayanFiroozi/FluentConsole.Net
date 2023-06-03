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



    internal class Program
    {

        private static FastLogger fastLogger = new FastLogger();

        static void Main(string[] args)
        {
            FluentConsole.AttachLogger(fastLogger);


            FluentConsole.Console
                           .WithFontColor(ConsoleColor.Yellow)
                           .WithBackColor(ConsoleColor.DarkGray)
                             .Write(DateTime.Now.ToString())
                             .AddSpace(1)

                           .WriteLine("Shayan Firoozi")
                           .AddCharacter('*', 20)
                           .AddBreakLine(5).PrintAndLog();

            return;
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
                              .AddBreakLine(5).Print();




                    1364.PrintOnConsole(true);
                    true.PrintOnConsole();

                });


                FluentConsole.Console
                 .WithFontColor(ConsoleColor.Yellow)
                 .WithBackColor(ConsoleColor.DarkGray)
                   .Write(DateTime.Now.ToString())
                   .AddSpace(1)

                 .WriteLine("Ajibe !!!")
                 .PrintAndLog();

                1364.PrintOnConsole(true);
                true.PrintOnConsole();

                Task.Delay(1).GetAwaiter().GetResult();



            }




            Console.WriteLine("Finished.");

            Console.ReadLine();
        }
    }



}