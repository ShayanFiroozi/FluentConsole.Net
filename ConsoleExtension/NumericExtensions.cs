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

        #region Integral numeric types

        //sbyte
        public static void WriteOnConsole(this sbyte number)
        {
            FluentConsole.Console.Write(number.ToString()).Print();
        }
        public static void WriteLineOnConsole(this sbyte number)
        {
            FluentConsole.Console.WriteLine(number.ToString()).Print();
        }



        // byte
        public static void WriteOnConsole(this byte number)
        {
            FluentConsole.Console.Write(number.ToString()).Print();

        }
        public static void WriteLineOnConsole(this byte number)
        {
            FluentConsole.Console.WriteLine(number.ToString()).Print();

        }


        // short
        public static void WriteOnConsole(this short number, bool Formatted = false)
        {
            if (Formatted)
            {
                FluentConsole.Console.Write($"{number:N0}").Print();
            }
            else
            {
                FluentConsole.Console.Write(number.ToString()).Print();
            }
        }
        public static void WriteLineOnConsole(this short number, bool Formatted = false)
        {
            if (Formatted)
            {
                FluentConsole.Console.WriteLine($"{number:N0}").Print();
            }
            else
            {
                FluentConsole.Console.WriteLine(number.ToString()).Print();
            }
        }


        // ushort
        public static void WriteOnConsole(this ushort number, bool Formatted = false)
        {
            if (Formatted)
            {
                FluentConsole.Console.Write($"{number:N0}").Print();
            }
            else
            {
                FluentConsole.Console.Write(number.ToString()).Print();
            }
        }
        public static void WriteLineOnConsole(this ushort number, bool Formatted = false)
        {
            if (Formatted)
            {
                FluentConsole.Console.WriteLine($"{number:N0}").Print();
            }
            else
            {
                FluentConsole.Console.WriteLine(number.ToString()).Print();
            }
        }



        // int
        public static void WriteOnConsole(this int number, bool Formatted = false)
        {
            if (Formatted)
            {
                FluentConsole.Console.Write($"{number:N0}").Print();
            }
            else
            {
                FluentConsole.Console.Write(number.ToString()).Print();
            }
        }
        public static void WriteLineOnConsole(this int number, bool Formatted = false)
        {
            if (Formatted)
            {
                FluentConsole.Console.WriteLine($"{number:N0}").Print();
            }
            else
            {
                FluentConsole.Console.WriteLine(number.ToString()).Print();
            }
        }


        // uint
        public static void WriteOnConsole(this uint number, bool Formatted = false)
        {
            if (Formatted)
            {
                FluentConsole.Console.Write($"{number:N0}").Print();
            }
            else
            {
                FluentConsole.Console.Write(number.ToString()).Print();
            }
        }
        public static void WriteLineOnConsole(this long number, bool Formatted = false)
        {
            if (Formatted)
            {
                FluentConsole.Console.WriteLine($"{number:N0}").Print();
            }
            else
            {
                FluentConsole.Console.WriteLine(number.ToString()).Print();
            }

        }


        // ulong
        public static void WriteOnConsole(this ulong number, bool Formatted = false)
        {
            if (Formatted)
            {
                FluentConsole.Console.Write($"{number:N0}").Print();
            }
            else
            {
                FluentConsole.Console.Write(number.ToString()).Print();
            }

        }
        public static void WriteLineOnConsole(this ulong number, bool Formatted = false)
        {
            if (Formatted)
            {
                FluentConsole.Console.WriteLine($"{number:N0}").Print();
            }
            else
            {
                FluentConsole.Console.WriteLine(number.ToString()).Print();
            }

        }

        #endregion


        #region Floating-point numeric types


        // float
        public static void WriteOnConsole(this float number, bool Formatted = false)
        {
            if (Formatted)
            {
                FluentConsole.Console.Write($"{number:N6}").Print();
            }
            else
            {
                FluentConsole.Console.Write(number.ToString()).Print();
            }

        }
        public static void WriteLineOnConsole(this float number, bool Formatted = false)
        {
            if (Formatted)
            {
                FluentConsole.Console.WriteLine($"{number:N6}").Print();
            }
            else
            {
                FluentConsole.Console.WriteLine(number.ToString()).Print();
            }

        }



        // double
        public static void WriteOnConsole(this double number, bool Formatted = false)
        {
            if (Formatted)
            {
                FluentConsole.Console.Write($"{number:N6}").Print();
            }
            else
            {
                FluentConsole.Console.Write(number.ToString()).Print();
            }

        }
        public static void WriteLineOnConsole(this double number, bool Formatted = false)
        {
            if (Formatted)
            {
                FluentConsole.Console.WriteLine($"{number:N6}").Print();
            }
            else
            {
                FluentConsole.Console.WriteLine(number.ToString()).Print();
            }

        }


        // decimal
        public static void WriteOnConsole(this decimal number, bool Formatted = false)
        {
            if (Formatted)
            {
                FluentConsole.Console.Write($"{number:N6}").Print();
            }
            else
            {
                FluentConsole.Console.Write(number.ToString()).Print();
            }
        }
        public static void WriteLineOnConsole(this decimal number, bool Formatted = false)
        {
            if (Formatted)
            {
                FluentConsole.Console.WriteLine($"{number:N6}").Print();
            }
            else
            {
                FluentConsole.Console.WriteLine(number.ToString()).Print();
            }
        }


        #endregion



    }
}
