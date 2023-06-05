/*---------------------------------------------------------------------------------------------

            ► FluentConsole.Net , Working With .Net Console In Elegant Way ! ◄



 → Copyright (c) 2020-2023 Shayan Firoozi , Bandar Abbas , Iran , Under MIT License.

 → Contact : <shayan.firoozi@gmail.com>

 → GitHub repository : https://github.com/ShayanFiroozi/FluentConsole.Net

---------------------------------------------------------------------------------------------*/

namespace FluentConsoleNet.ConsoleExtension
{
    public static partial class ExtensionMethods
    {

        public static void WriteOnConsole(this string text)
        {
            FluentConsole.Console.Write(text).Print();
        }


        public static void WriteLineOnConsole(this string text)
        {
            FluentConsole.Console.WriteLine(text).Print();
        }


    }
}
