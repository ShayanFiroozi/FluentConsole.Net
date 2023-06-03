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

        public static void PrintOnConsole(this bool boolean, bool YesNoFormat = false)
        {
            FluentConsole.Console.WriteLine(YesNoFormat ? (boolean ? "Yes" : "No") : boolean.ToString()).Print();

        }


    }
}
