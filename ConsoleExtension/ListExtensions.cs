/*---------------------------------------------------------------------------------------------

            ► FluentConsole.Net , Working With .Net Console In Elegant Way ! ◄



 → Copyright (c) 2020-2023 Shayan Firoozi , Bandar Abbas , Iran , Under MIT License.

 → Contact : <shayan.firoozi@gmail.com>

 → GitHub repository : https://github.com/ShayanFiroozi/FluentConsole.Net

---------------------------------------------------------------------------------------------*/

using System.Collections.Generic;

namespace FluentConsoleNet.ConsoleExtension
{
    public static partial class ExtensionMethods
    {


        public static void WriteOnConsole(this List<string> message)
        {
            FluentConsole.Console.Write(message).Print();

        }


        public static void WriteLineOnConsole(this List<string> message)
        {
            FluentConsole.Console.WriteLine(message).Print();

        }


        public static void WriteOnConsole(this List<int> message , bool Formatted = false)
        {
            FluentConsole.Console.Write(message, Formatted).Print();


        }


        public static void WriteLineOnConsole(this List<int> message, bool Formatted = false)
        {
            FluentConsole.Console.WriteLine(message,Formatted).Print();

        }



    }
}
