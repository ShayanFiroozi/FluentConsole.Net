/*---------------------------------------------------------------------------------------------

            ► FluentConsole.Net , Working With .Net Console In Elegant Way ! ◄



 → Copyright (c) 2020-2023 Shayan Firoozi , Bandar Abbas , Iran , Under MIT License.

 → Contact : <shayan.firoozi@gmail.com>

 → GitHub repository : https://github.com/ShayanFiroozi/FluentConsole.Net

---------------------------------------------------------------------------------------------*/

using System;
using System.Text;

namespace FluentConsoleNet.ConsoleExtension
{
    public static partial class ExtensionMethods
    {

        public static string ToJsonFormat(this Exception exception, int SpaceLevel = 1)
        {
            if (exception is null)
            {
                return "N/A";
            }

            int spaceCount = SpaceLevel * 4;

            StringBuilder finalMessage = new StringBuilder();

            _ = finalMessage.Append($"{new string(' ', spaceCount)}{{").Append('\n')

                            .Append($"{new string(' ', spaceCount + 2)}\"Id\": \"{exception.HResult}\"")
                             .Append(',').Append('\n')

                            .Append($"{new string(' ', spaceCount + 2)}\"Message\": \"{exception.Message}\"")
                            .Append(',').Append('\n')

                            .Append($"{new string(' ', spaceCount + 2)}\"Inner Exception\": {(exception.InnerException == null ? "\"N/A\"" : $"\n{exception.InnerException.ToJsonFormat(SpaceLevel + 1)}")}")
                            .Append(',').Append('\n')

                            .Append($"{new string(' ', spaceCount + 2)}\"Source\": \"{(string.IsNullOrWhiteSpace(exception.Source) ? "N/A" : exception.Source)}\"")
                            .Append(',').Append('\n')

                            .Append($"{new string(' ', spaceCount + 2)}\"StackTrace\": \"{(string.IsNullOrWhiteSpace(exception.StackTrace) ? "N/A" : exception.StackTrace)}\"")
                            .Append(',').Append('\n')

                            .Append($"{new string(' ', spaceCount + 2)}\"Target Site\": \"{(exception.TargetSite == null ? "N/A" : exception.TargetSite.Name)}\"")
                            .Append($"\n{new string(' ', spaceCount)}}}");


            return finalMessage.ToString();

        }


        public static string ToStringFormat(this Exception exception)
        {
            if (exception is null)
            {
                return "N/A";
            }

            StringBuilder finalMessage = new StringBuilder();

            finalMessage.AppendLine($"Id : {exception?.HResult}");

            finalMessage.AppendLine($"Message : {exception?.Message ?? "N/A"}");

            finalMessage.AppendLine($"InnerException : {exception?.InnerException?.Message ?? "N/A"}");

            finalMessage.AppendLine($"StackTrace : {exception?.StackTrace ?? "N/A"}");

            finalMessage.AppendLine($"Source : {exception?.Source ?? "N/A"}");

            finalMessage.AppendLine($"Target Site : {(exception?.TargetSite != null ? exception?.TargetSite?.Name : "N/A")}");

            return finalMessage.ToString();

        }


        public static void WriteOnConsole(this Exception exception)
        {
            FluentConsole.Console.Write(ToStringFormat(exception)).Print();
        }


        public static void WriteLineOnConsole(this Exception exception)
        {
            FluentConsole.Console.WriteLine(ToStringFormat(exception)).Print();
        }


        public static void WriteOnConsoleWithJSON(this Exception exception)
        {
            FluentConsole.Console.Write(ToJsonFormat(exception)).Print();
        }


        public static void WriteLineOnConsoleWithJSON(this Exception exception)
        {
            FluentConsole.Console.WriteLine(ToJsonFormat(exception)).Print();
        }


    }
}
