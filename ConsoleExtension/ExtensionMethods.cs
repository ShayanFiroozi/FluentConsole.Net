using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentConsoleNet.ConsoleExtension
{
    public static partial class ExtensionMethods
    {

        public static void PrintOnConsole(this string text)
        {
            FluentConsole.Console.WriteLine(text).Print();
        }


       
        public static void WriteOnConsole(this List<string> message)
        {
            FluentConsole.Console.Write(message).Print();

        }


        public static void WriteLineOnConsole(this List<string> message)
        {
            FluentConsole.Console.WriteLine(message).Print();

        }


        public static void WriteOnConsole(this List<int> message)
        {
            FluentConsole.Console.Write(message).Print();

         
        }


        public static void WriteLineOnConsole(this List<int> message)
        {
            FluentConsole.Console.WriteLine(message).Print();

        }



    }
}
