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
        private const string DateTimeFormat = "yyyy-MM-dd HH:mm:ss ";


        public static void PrintText(string text, bool IncludeDateTime = true)
        {

            if (IncludeDateTime)
            {
                FluentConsole.Console
                             .WithFontColor(DateTimeColor)
                             .Write(DateTime.Now.ToString(DateTimeFormat))
                             .ResetColor()
                             .AddSpace(1)
                             .WriteLine(text)
                             .Print();
            }

            else
            {
                FluentConsole.Console
                             .WriteLine(text)
                             .Print();
            }


        }


        public static void PrintNote(string note, bool IncludeDateTime = true)
        {

            if (IncludeDateTime)
            {
                FluentConsole.Console
                             .WithFontColor(DateTimeColor)
                             .Write(DateTime.Now.ToString(DateTimeFormat))
                             .ResetColor()
                             .AddSpace(1)
                             .WithBackColor(ConsoleColor.White)
                             .WithFontColor(ConsoleColor.DarkGreen)
                             .Write("NOTE →")
                             .ResetColor()
                             .AddSpace(1)
                             .WithFontColor(ConsoleColor.White)
                             .WriteLine(note)
                             .Print();
            }

            else
            {
                FluentConsole.Console
                             .WithBackColor(ConsoleColor.White)
                             .WithFontColor(ConsoleColor.DarkGreen)
                             .Write("NOTE →")
                             .ResetColor()
                             .AddSpace(1)
                             .WithFontColor(ConsoleColor.White)
                             .WriteLine(note)
                             .Print();
            }


        }


        public static void PrintTodo(string todo, bool IncludeDateTime = true)
        {

            if (IncludeDateTime)
            {
                FluentConsole.Console
                             .WithFontColor(DateTimeColor)
                             .Write(DateTime.Now.ToString(DateTimeFormat))
                             .ResetColor()
                             .AddSpace(1)
                             .WithBackColor(ConsoleColor.White)
                             .WithFontColor(ConsoleColor.DarkCyan)
                             .Write("TODO →")
                             .ResetColor()
                             .AddSpace(1)
                             .WithFontColor(ConsoleColor.White)
                             .WriteLine(todo)
                             .Print();
            }

            else
            {
                FluentConsole.Console
                             .WithBackColor(ConsoleColor.White)
                             .WithFontColor(ConsoleColor.DarkMagenta)
                             .Write("TODO →")
                             .ResetColor()
                             .AddSpace(1)
                             .WithFontColor(ConsoleColor.White)
                             .WriteLine(todo)
                             .Print();
            }


        }


        public static void PrintInfo(string info, bool IncludeDateTime = true)
        {

            if (IncludeDateTime)
            {
                FluentConsole.Console
                             .WithFontColor(DateTimeColor)
                             .Write(DateTime.Now.ToString(DateTimeFormat))
                             .ResetColor()
                             .AddSpace(1)
                             .WithBackColor(ConsoleColor.White)
                             .WithFontColor(ConsoleColor.DarkMagenta)
                             .Write("INFO →")
                             .ResetColor()
                             .AddSpace(1)
                             .WithFontColor(ConsoleColor.White)
                             .WriteLine(info)
                             .Print();
            }

            else
            {
                FluentConsole.Console
                             .WithBackColor(ConsoleColor.White)
                             .WithFontColor(ConsoleColor.DarkCyan)
                             .Write("INFO →")
                             .ResetColor()
                             .AddSpace(1)
                             .WithFontColor(ConsoleColor.White)
                             .WriteLine(info)
                             .Print();
            }


        }


        public static void PrintWarning(string warning, bool IncludeDateTime = true)
        {

            if (IncludeDateTime)
            {
                FluentConsole.Console
                             .WithFontColor(DateTimeColor)
                             .Write(DateTime.Now.ToString(DateTimeFormat))
                             .ResetColor()
                             .AddSpace(1)
                             .WithBackColor(ConsoleColor.Yellow)
                             .WithFontColor(ConsoleColor.DarkRed)
                             .Write("WARNING →")
                             .ResetColor()
                             .AddSpace(1)
                             .WithFontColor(ConsoleColor.Yellow)
                             .WriteLine(warning)
                             .Print();
            }

            else
            {
                FluentConsole.Console
                             .WithBackColor(ConsoleColor.Yellow)
                             .WithFontColor(ConsoleColor.DarkRed)
                             .Write("WARNING →")
                             .ResetColor()
                             .AddSpace(1)
                             .WithFontColor(ConsoleColor.Yellow)
                             .WriteLine(warning)
                             .Print();
            }


        }


        public static void PrintAlert(string alert, bool IncludeDateTime = true)
        {

            if (IncludeDateTime)
            {
                FluentConsole.Console
                             .WithFontColor(DateTimeColor)
                             .Write(DateTime.Now.ToString(DateTimeFormat))
                             .ResetColor()
                             .AddSpace(1)
                             .WithBackColor(ConsoleColor.DarkRed)
                             .Write("ALERT →")
                             .ResetColor()
                             .AddSpace(1)
                             .WithFontColor(ConsoleColor.Yellow)
                             .WriteLine(alert)
                             .Print();
            }

            else
            {
                FluentConsole.Console
                             .WithBackColor(ConsoleColor.DarkRed)
                             .Write("ALERT →")
                             .ResetColor()
                             .AddSpace(1)
                             .WithFontColor(ConsoleColor.Yellow)
                             .WriteLine(alert)
                             .Print();
            }


        }


        public static void PrintError(string error, bool IncludeDateTime = true)
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
                             .Print();
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
                             .Print();
            }


        }


        public static void PrintDebug(string debug, bool IncludeDateTime = true)
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
                             .Print();
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
                             .Print();
            }


        }


        public static void PrintException(Exception exception,
                                          bool IncludeDateTime = true,
                                          bool JsonFormat = true,
                                          bool BriefMode = true)
        {

            if (IncludeDateTime)
            {

                if (BriefMode)
                {
                    FluentConsole.Console
                                 .WithFontColor(DateTimeColor)
                                 .Write(DateTime.Now.ToString(DateTimeFormat))
                                 .ResetColor()
                                 .AddSpace(1)
                                 .WithBackColor(ConsoleColor.Red)
                                 .Write("EXCEPTION →")
                                 .ResetColor()
                                 .AddSpace()
                                 .WithFontColor(ConsoleColor.Red)
                                 .WriteLine(exception.Message)
                                 .Print();
                }
                else
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
                                 .Print();
                }
            }

            else
            {
                if (BriefMode)
                {
                    FluentConsole.Console
                             .WithBackColor(ConsoleColor.Red)
                             .Write("EXCEPTION →")
                             .ResetColor()
                             .AddSpace()
                             .WithFontColor(ConsoleColor.Red)
                             .WriteLine(exception.Message)
                             .Print();
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
                             .Print();
                }
            }


        }


        public static void PrintSystem(string system, bool IncludeDateTime = true)
        {

            if (IncludeDateTime)
            {
                FluentConsole.Console
                             .WithFontColor(DateTimeColor)
                             .Write(DateTime.Now.ToString(DateTimeFormat))
                             .ResetColor()
                             .AddSpace(1)
                             .WithBackColor(ConsoleColor.DarkGray)
                             .WithFontColor(ConsoleColor.Yellow)
                             .Write("SYSTEM →")
                             .ResetColor()
                             .AddSpace(1)
                             .WithFontColor(ConsoleColor.DarkCyan)
                             .WriteLine(system)
                             .Print();
            }

            else
            {
                FluentConsole.Console
                             .WithBackColor(ConsoleColor.Gray)
                             .WithFontColor(ConsoleColor.Magenta)
                             .Write("SYSTEM →")
                             .ResetColor()
                             .AddSpace(1)
                             .WithFontColor(ConsoleColor.Blue)
                             .WriteLine(system)
                             .Print();
            }


        }

        public static void PrintSecurity(string security, bool IncludeDateTime = true)
        {

            if (IncludeDateTime)
            {
                FluentConsole.Console
                             .WithFontColor(DateTimeColor)
                             .Write(DateTime.Now.ToString(DateTimeFormat))
                             .ResetColor()
                             .AddSpace(1)
                             .WithBackColor(ConsoleColor.White)
                             .WithFontColor(ConsoleColor.DarkRed)
                             .Write("SECURITY →")
                             .ResetColor()
                             .AddSpace(1)
                             .WithFontColor(ConsoleColor.Cyan)
                             .WriteLine(security)
                             .Print();
            }

            else
            {
                FluentConsole.Console
                             .WithBackColor(ConsoleColor.Gray)
                             .WithFontColor(ConsoleColor.DarkRed)
                             .Write("SECURITY →")
                             .ResetColor()
                             .AddSpace(1)
                             .WithFontColor(ConsoleColor.Red)
                             .WriteLine(security)
                             .Print();
            }


        }


        public static void PrintSymbolicText(string text, FontStyle fontStyle, ConsoleColor color)

        {
            FluentConsole.Console
                         .WithFontColor(color)
                         .WriteLine(StyleHelper.GetSymbolicText(fontStyle, text))
                         .Print();
        }

    }


}


