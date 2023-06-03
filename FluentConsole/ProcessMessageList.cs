using System;
using FluentConsoleNet.Helpers;

namespace FluentConsoleNet
{
    public partial class ConsoleBuilder
    {
        private const string FontColorSign = "[/]";
        private const string BackColorSign = "bg[/]";

        private void ProcessMessageList()
        {
            try
            {
                foreach (string message in messageList)
                {

                    if (message.Length == 0)
                    {
                        continue; // Skip an empty message
                    }


                    if (message == Environment.NewLine)
                    {
                        Console.WriteLine();
                        continue;
                    }


                    // Font Color
                    if (message.Substring(0, FontColorSign.Length) == FontColorSign &&
                        message.Substring(message.Length - FontColorSign.Length, FontColorSign.Length) == FontColorSign)
                    {

                        string colorName = message.Substring(FontColorSign.Length, message.Length - (FontColorSign.Length * 2));

                        if (string.IsNullOrEmpty(colorName))
                        {
                            continue;
                        }

                        Console.ForegroundColor = ColorHelper.GetConsoleColor(colorName);
                        continue;
                    }



                    // Back Color
                    if (message.Substring(0, BackColorSign.Length) == BackColorSign &&
                        message.Substring(message.Length - BackColorSign.Length, BackColorSign.Length) == BackColorSign)
                    {

                        string colorName = message.Substring(BackColorSign.Length, message.Length - BackColorSign.Length * 2);

                        if (string.IsNullOrEmpty(colorName))
                        {
                            continue;
                        }

                        Console.BackgroundColor = ColorHelper.GetConsoleColor(colorName);
                        continue;
                    }



                    Console.Write(message);
                    Console.ResetColor();



                }
            }
            catch
            {
                Console.ResetColor();
            }

        }

    }


}


