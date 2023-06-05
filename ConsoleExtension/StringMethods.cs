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

        public static void PrintOnConsole(this string text)
        {
            FluentConsole.Console.WriteLine(text).Print();
        }


    }
}
