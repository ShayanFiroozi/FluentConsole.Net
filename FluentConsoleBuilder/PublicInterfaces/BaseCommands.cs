/*---------------------------------------------------------------------------------------------

            ► FluentConsole.Net , Working With .Net Console In Elegant Way ! ◄



 → Copyright (c) 2020-2023 Shayan Firoozi , Bandar Abbas , Iran , Under MIT License.

 → Contact : <shayan.firoozi@gmail.com>

 → GitHub repository : https://github.com/ShayanFiroozi/FluentConsole.Net

---------------------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;

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
            MessageList.Add(text + Environment.NewLine);

            return this;
        }





        public FluentConsoleBuilder ClearScreen()
        {
            MessageList.Add(ClearScreenSign);
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
            MessageList.Add(BeepSign);
            return this;
        }


        public FluentConsoleBuilder ResetColor()
        {
            MessageList.Add(ResetColorsSign);
            return this;
        }



        public FluentConsoleBuilder WithFontColor(ConsoleColor color)
        {

            MessageList.Add($"{FontColorSign}{color}{CommandSign}");

            return this;
        }


        public FluentConsoleBuilder WithBackColor(ConsoleColor color)
        {

            MessageList.Add($"{BackColorSign}{color}{CommandSign}");


            return this;
        }


        public FluentConsoleBuilder WithTitle(string title)
        {

            MessageList.Add($"{ConsoleTitleSign}{title}{CommandSign}");


            return this;
        }

    }


}


