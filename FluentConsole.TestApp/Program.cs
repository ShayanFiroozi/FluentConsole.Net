using FluentConsoleNet.ConsoleExtension;
using FluentConsoleNet.Helpers.Style;
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
            // Symbolic Stylish Text

            FluentConsole.Console.AddLineBreak(3).Print();

            Builder.FastConsole.PrintSymbolicText("Fluent Console For .Net", FontStyle.StyleA, ConsoleColor.DarkCyan);

            FluentConsole.Console.AddLineBreak(3).Print();

            Builder.FastConsole.PrintSymbolicText("I AM A STYLISH TEXT", FontStyle.StyleA, ConsoleColor.Yellow);

            FluentConsole.Console.AddLineBreak().Print();

            Builder.FastConsole.PrintText("Press any key to test the \"Fast Console !\"\n", false);
            FluentConsole.Console.ReadKey();


            Builder.FastConsole.PrintText("This is a Normal text !\n");
            Builder.FastConsole.PrintInfo("This is an Info text !\n");
            Builder.FastConsole.PrintNote("This is a Note text !\n");
            Builder.FastConsole.PrintTodo("This is a Todo text !\n");
            Builder.FastConsole.PrintWarning("This is an Warning message !\n");
            Builder.FastConsole.PrintAlert("This is an Alert message !\n");
            Builder.FastConsole.PrintDebug("This is a Debug message !\n");
            Builder.FastConsole.PrintError("This is an Error message !\n");
            Builder.FastConsole.PrintException(new InvalidCastException("This is a test Exception from \"FluentConsole.Net\"\n"));
            Builder.FastConsole.PrintSystem("This is a System message!\n");
            Builder.FastConsole.PrintSecurity("This is a Security message!\n");

            Builder.FastConsole.PrintText("Press any key to start the crazy test of \"FluentConsole.Net\" !");

            FluentConsole.Console.ReadKey();

            FluentConsole.AttachLogger(fastLogger);


            while (true)
            {
                await Task.Run(() =>
                 {

                     Builder.FastConsole.PrintText("This is a Fast Simple Text !", false);

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
                     Builder.FastConsole.PrintWarning("This is a Fast Warning Text !");


                     FluentConsole.Console
                     .AddLineBreak(2)
                     .WithFontColor(ConsoleColor.Yellow)
                     .WriteLine("This is a List<string> example : ")
                     .Print();


                     List<string> greatest = new List<string>() { "David Gilmour", "Joe Satriani", "Stevie Ray Vaughan", "Slash !", "Paul Mccartney" };

                     greatest.WriteLineOnConsole();

                     Builder.FastConsole.PrintException(new InvalidTimeZoneException("This is my test exception"), false);

                 });

                await Task.Run(() =>
                 {
                     Builder.FastConsole.PrintError("This is a Fast Error Text !");

                     FluentConsole.Console
                     .AddLineBreak(2)
                     .WithFontColor(ConsoleColor.Yellow)
                     .WriteLine("This is a List<int> example ( formatted ): ")
                     .Print();


                     List<int> numbers = new List<int>() { 1364, 1368, 1998, 1985, 1989 };

                     numbers.WriteLineOnConsole(true);

                     Builder.FastConsole.PrintException(new InvalidTimeZoneException("This is my test exception"), false);

                 });

                await Task.Run(() =>
                  {

                      Builder.FastConsole.PrintDebug("This is a Fast Debug Text !");
                      Builder.FastConsole.PrintInfo("This is a Fast Info Text !");

                      FluentConsole.Console
                      .AddLineBreak(2)
                      .WithFontColor(ConsoleColor.Yellow)
                      .WriteLine("This is a List<int> example ( unformatted ): ")
                      .Print();


                      List<int> numbers = new List<int>() { 1364, 1368, 1998, 1985, 1989 };

                      numbers.WriteLineOnConsole(false);

                      Builder.FastConsole.PrintException(new InvalidTimeZoneException("This is my test exception"), false);

                  });





                Task.Delay(2).GetAwaiter().GetResult();


                if (Console.KeyAvailable)
                {
                    return;
                }

            }

        }
    }



}