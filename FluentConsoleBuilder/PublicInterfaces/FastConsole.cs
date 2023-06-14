/*---------------------------------------------------------------------------------------------

            ► FluentConsole.Net , Working With .Net Console In Elegant Way ! ◄



 → Copyright (c) 2020-2023 Shayan Firoozi , Bandar Abbas , Iran , Under MIT License.

 → Contact : <shayan.firoozi@gmail.com>

 → GitHub repository : https://github.com/ShayanFiroozi/FluentConsole.Net

---------------------------------------------------------------------------------------------*/

using FluentConsoleNet.Helpers.Style;
using System;

namespace FluentConsoleNet.Builder
{
    public sealed class FastConsole
    {
        private const ConsoleColor DateTimeColor = ConsoleColor.Green;
        private const string DateTimeFormat = "yyyy-MM-dd HH:mm:ss :";

        public void PrintText(string text, bool IncludeDateTime = true)
        {

            if (IncludeDateTime)
            {
                FluentConsole.Console
                             .WithFontColor(DateTimeColor)
                             .Write(DateTime.Now.ToString(DateTimeFormat))
                             .ResetColor()
                             .AddSpace(1)
                             .WriteLine(text)
                             .PrintAndLog();
            }

            else
            {
                FluentConsole.Console
                            .WriteLine(text)
                            .PrintAndLog();
            }


        }


        public void PrintInfo(string info, bool IncludeDateTime = true)
        {

            if (IncludeDateTime)
            {
                FluentConsole.Console
                             .WithFontColor(DateTimeColor)
                             .Write(DateTime.Now.ToString(DateTimeFormat))
                             .ResetColor()
                             .AddSpace(1)
                             .WithBackColor(ConsoleColor.DarkGreen)
                             .Write("INFO →")
                             .ResetColor()
                             .AddSpace(1)
                             .WithFontColor(ConsoleColor.Cyan)
                             .WriteLine(info)
                             .PrintAndLog();
            }

            else
            {
                FluentConsole.Console
                             .WithBackColor(ConsoleColor.DarkGreen)
                             .Write("INFO →")
                             .ResetColor()
                             .AddSpace(1)
                             .WithFontColor(ConsoleColor.Cyan)
                             .WriteLine(info)
                             .PrintAndLog();
            }


        }


        public void PrintWarning(string warning, bool IncludeDateTime = true)
        {

            if (IncludeDateTime)
            {
                FluentConsole.Console
                             .WithFontColor(DateTimeColor)
                             .Write(DateTime.Now.ToString(DateTimeFormat))
                             .ResetColor()
                             .AddSpace(1)
                             .WithBackColor(ConsoleColor.DarkRed)
                             .Write("WARNING →")
                             .ResetColor()
                             .AddSpace(1)
                             .WithFontColor(ConsoleColor.Yellow)
                             .WriteLine(warning)
                             .PrintAndLog();
            }

            else
            {
                FluentConsole.Console
                             .WithBackColor(ConsoleColor.DarkRed)
                             .Write("WARNING →")
                             .ResetColor()
                             .AddSpace(1)
                             .WithFontColor(ConsoleColor.Yellow)
                             .WriteLine(warning)
                             .PrintAndLog();
            }


        }


        public void PrintError(string error, bool IncludeDateTime = true)
        {

            if (IncludeDateTime)
            {
                FluentConsole.Console
                             .WithFontColor(DateTimeColor)
                             .Write(DateTime.Now.ToString(DateTimeFormat))
                             .ResetColor()
                             .AddSpace(1)
                             .WithBackColor(ConsoleColor.DarkRed)
                             .Write("ERROR →")
                             .ResetColor()
                             .AddSpace(1)
                             .WithFontColor(ConsoleColor.Red)
                             .WriteLine(error)
                             .PrintAndLog();
            }

            else
            {
                FluentConsole.Console
                             .WithBackColor(ConsoleColor.DarkRed)
                             .Write("ERROR →")
                             .ResetColor()
                             .AddSpace(1)
                             .WithFontColor(ConsoleColor.Red)
                             .WriteLine(error)
                             .PrintAndLog();
            }


        }


        public void PrintDebug(string debug, bool IncludeDateTime = true)
        {

            if (IncludeDateTime)
            {
                FluentConsole.Console
                             .WithFontColor(DateTimeColor)
                             .Write(DateTime.Now.ToString(DateTimeFormat))
                             .ResetColor()
                             .AddSpace(1)
                             .WithBackColor(ConsoleColor.DarkMagenta)
                             .Write("DEBUG →")
                             .ResetColor()
                             .AddSpace(1)
                             .WithFontColor(ConsoleColor.DarkGray)
                             .WriteLine(debug)
                             .PrintAndLog();
            }

            else
            {
                FluentConsole.Console
                             .WithBackColor(ConsoleColor.DarkMagenta)
                             .Write("DEBUG →")
                             .ResetColor()
                             .AddSpace(1)
                             .WithFontColor(ConsoleColor.DarkGray)
                             .WriteLine(debug)
                             .PrintAndLog();
            }


        }


        public void PrintException(Exception exception, bool IncludeDateTime = true, bool JsonFormat = true)
        {

            if (IncludeDateTime)
            {
                FluentConsole.Console
                             .WithFontColor(DateTimeColor)
                             .Write(DateTime.Now.ToString(DateTimeFormat))
                             .ResetColor()
                             .AddSpace(1)
                             .WithBackColor(ConsoleColor.Red)
                             .Write("EXCEPTION →")
                             .ResetColor()
                             .AddLineBreak(1)
                              .WithFontColor(ConsoleColor.Red)
                             .WriteLine(exception, JsonFormat)
                             .PrintAndLog();
            }

            else
            {
                FluentConsole.Console
                             .WithBackColor(ConsoleColor.Red)
                             .Write("EXCEPTION →")
                             .ResetColor()
                             .AddLineBreak(1)
                             .WithFontColor(ConsoleColor.Red)
                             .WriteLine(exception, JsonFormat)
                             .PrintAndLog();
            }


        }


        public void PrintSymbolicText(string text, FontStyle fontStyle, ConsoleColor color)

        {
            FluentConsole.Console
                         .WithFontColor(color)
                         .WriteLine(StyleHelper.GetSymbolicText(fontStyle, text))
                         .Print();
        }

    }


}


