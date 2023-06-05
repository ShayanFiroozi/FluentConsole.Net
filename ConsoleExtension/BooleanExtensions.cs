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

        public static void WriteOnConsole(this bool boolean, bool YesNoFormat = false)
        {
            if (boolean)
            {
                if (YesNoFormat)
                {
                    FluentConsole.Console.Write("Yes").Print();
                }
                else
                {
                    FluentConsole.Console.Write(boolean.ToString()).Print();
                }
            }
            else
            {
                if (YesNoFormat)
                {
                    FluentConsole.Console.Write("No").Print();
                }
                else
                {
                    FluentConsole.Console.Write(boolean.ToString()).Print();
                }
            }

        }



        public static void WriteLineOnConsole(this bool boolean, bool YesNoFormat = false)
        {
            if (boolean)
            {
                if (YesNoFormat)
                {
                    FluentConsole.Console.WriteLine("Yes").Print();
                }
                else
                {
                    FluentConsole.Console.WriteLine(boolean.ToString()).Print();
                }
            }
            else
            {
                if (YesNoFormat)
                {
                    FluentConsole.Console.WriteLine("No").Print();
                }
                else
                {
                    FluentConsole.Console.WriteLine(boolean.ToString()).Print();
                }
            }

        }

    }
}
