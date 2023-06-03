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
            if (boolean)
            {
                FluentConsole.Console.WriteLine(YesNoFormat ? ("Yes") : boolean.ToString()).Print();
            }
            else
            {
                FluentConsole.Console.WriteLine(YesNoFormat ? ("No") : boolean.ToString()).Print();
            }

        }


    }
}
