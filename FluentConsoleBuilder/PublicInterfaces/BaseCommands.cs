/*---------------------------------------------------------------------------------------------

            ► FluentConsole.Net , Working With .Net Console In Elegant Way ! ◄



 → Copyright (c) 2020-2023 Shayan Firoozi , Bandar Abbas , Iran , Under MIT License.

 → Contact : <shayan.firoozi@gmail.com>

 → GitHub repository : https://github.com/ShayanFiroozi/FluentConsole.Net

---------------------------------------------------------------------------------------------*/

using System;

namespace FluentConsoleNet.Builder
{
    public sealed partial class FluentConsoleBuilder
    {

        // Base Write and WriteLine
        public FluentConsoleBuilder Write(string text)
        {

            MessageList.Add(text);
            return this;
        }

        public FluentConsoleBuilder WriteLine(string text)
        {
            Write(text + Environment.NewLine);
            return this;
        }





        public FluentConsoleBuilder ClearScreen()
        {
            Write(ClearScreenSign);
            return this;
        }


        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey();
        }


        public FluentConsoleBuilder Beep()
        {
            Write(BeepSign);
            return this;
        }


        public FluentConsoleBuilder ResetColor()
        {
            Write(ResetColorsSign);
            return this;
        }



        public FluentConsoleBuilder WithFontColor(ConsoleColor color)
        {

            Write($"{FontColorSign}{color}{CommandSign}");

            return this;
        }


        public FluentConsoleBuilder WithBackColor(ConsoleColor color)
        {

            Write($"{BackColorSign}{color}{CommandSign}");


            return this;
        }


        public FluentConsoleBuilder WithTitle(string title)
        {

            Write($"{ConsoleTitleSign}{title}{CommandSign}");


            return this;
        }

    }


}


