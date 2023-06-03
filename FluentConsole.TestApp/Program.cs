using FluentConsoleNet.ConsoleExtension;
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

                FluentConsole.Console
                    .WithTitle("This is the Fluent Console For .Net")
                    .WithFontColor(ConsoleColor.Yellow)
                    .AddLine(LineWidth: 20)
                    .Write("Who wants to live forever ?!")
                    .Beep()
                    .PrintAndLog();



            }




            Console.WriteLine("Finished.");

            Console.ReadLine();
        }
    }



}