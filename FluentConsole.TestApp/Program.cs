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

            FastConsole.PrintSymbolicText("Fluent Console For .Net", FontStyle.StyleA, ConsoleColor.DarkCyan);

            FluentConsole.Console.AddLineBreak(3).Print();

            FastConsole.PrintSymbolicText("I AM A STYLISH TEXT", FontStyle.StyleA, ConsoleColor.Yellow);

            FluentConsole.Console.AddLineBreak().Print();

            FastConsole.PrintText("Press any key to test the \"Fast Console !\"\n", false);
            Console.ReadKey();

            FastConsole.PrintText("This is a Normal text !\n");
            FastConsole.PrintInfo("This is an Info text !\n");
            FastConsole.PrintNote("This is a Note text !\n");
            FastConsole.PrintTodo("This is a Todo text !\n");
            FastConsole.PrintWarning("This is a Warning message !\n");
            FastConsole.PrintAlert("This is an Alert message !\n");
            FastConsole.PrintDebug("This is a Debug message !\n");
            FastConsole.PrintError("This is an Error message !\n");
            FastConsole.PrintException(new InvalidCastException("This is a test Exception from \"FluentConsole.Net\"\n"));
            FastConsole.PrintSystem("This is a System message!\n");
            FastConsole.PrintSecurity("This is a Security message!\n");

            FastConsole.PrintText("Press any key to start the crazy test of \"FluentConsole.Net\" !");

            Console.ReadKey();

            FluentConsole.AttachLogger(fastLogger);


            while (true)
            {
                _ = Task.Run(() =>
                 {

                     FastConsole.PrintText("This is a Fast Simple Text !", false);

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

                _ = Task.Run(() =>
                 {
                     FastConsole.PrintWarning("This is a Fast Warning Text !");


                     FluentConsole.Console
                     .AddLineBreak(2)
                     .WithFontColor(ConsoleColor.Yellow)
                     .WriteLine("This is a List<string> example : ")
                     .Print();


                     List<string> greatest = new List<string>() { "David Gilmour", "Joe Satriani", "Stevie Ray Vaughan", "Slash !", "Paul Mccartney" };

                     greatest.WriteLineOnConsole();

                     FastConsole.PrintException(new InvalidTimeZoneException("This is my test exception"), false);

                 });

                _ = Task.Run(() =>
                 {
                     FastConsole.PrintText("This is a Normal text !\n");
                     FastConsole.PrintInfo("This is an Info text !\n");
                     FastConsole.PrintNote("This is a Note text !\n");
                     FastConsole.PrintTodo("This is a Todo text !\n");
                     FastConsole.PrintWarning("This is an Warning message !\n");
                     FastConsole.PrintAlert("This is an Alert message !\n");
                     FastConsole.PrintDebug("This is a Debug message !\n");
                     FastConsole.PrintError("This is an Error message !\n");
                     FastConsole.PrintException(new InvalidCastException("This is a test Exception from \"FluentConsole.Net\"\n"));
                     FastConsole.PrintSystem("This is a System message!\n");
                     FastConsole.PrintSecurity("This is a Security message!\n");

                     FluentConsole.Console
                     .AddLineBreak(2)
                     .WithFontColor(ConsoleColor.Yellow)
                     .WriteLine("This is a List<int> example ( formatted ): ")
                     .Print();


                     List<int> numbers = new List<int>() { 1364, 1368, 1998, 1985, 1989 };

                     numbers.WriteLineOnConsole(true);

                     FastConsole.PrintException(new InvalidTimeZoneException("This is my test exception"), false);

                 });

                _ = Task.Run(() =>
                  {

                      FastConsole.PrintDebug("This is a Fast Debug Text !");
                      FastConsole.PrintInfo("This is a Fast Info Text !");

                      FluentConsole.Console
                      .AddLineBreak(2)
                      .WithFontColor(ConsoleColor.Yellow)
                      .WriteLine("This is a List<int> example ( unformatted ): ")
                      .Print();


                      List<int> numbers = new List<int>() { 1364, 1368, 1998, 1985, 1989 };

                      numbers.WriteLineOnConsole(false);

                      FastConsole.PrintException(new InvalidTimeZoneException("This is my test exception"), false);

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