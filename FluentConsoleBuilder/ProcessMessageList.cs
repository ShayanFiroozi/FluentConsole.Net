using System;
using FluentConsoleNet.Helpers;

namespace FluentConsoleNet
{
    public sealed partial class FluentConsoleBuilder
    {


        private void ProcessMessageList()
        {
            try
            {
                foreach (string message in MessageList)
                {

                    if (message.Length == 0)
                    {
                        continue; // Skip an empty message
                    }


                    if (message == ClearScreenSign)
                    {
                        Console.Clear();
                        continue;
                    }


                    if (message == BeepSign)
                    {
                        Console.Beep();
                        continue;
                    }

                    if (message == Environment.NewLine)
                    {
                        Console.WriteLine();
                        continue;
                    }

                    // Process Fore and Back Colors
                    if (message.Length > (FontColorSign.Length + CommandSign.Length))
                    {

                        // Font Color
                        if (message.Substring(0, FontColorSign.Length) == FontColorSign &&
                            message.Substring(message.Length - CommandSign.Length, CommandSign.Length) == CommandSign)
                        {

                            string colorName = message.Substring(FontColorSign.Length, message.Length - (FontColorSign.Length + CommandSign.Length));

                            if (string.IsNullOrEmpty(colorName))
                            {
                                continue;
                            }

                            Console.ForegroundColor = ColorHelper.GetConsoleColor(colorName);
                            continue;
                        }


                        // Back Color
                        if (message.Substring(0, BackColorSign.Length) == BackColorSign &&
                            message.Substring(message.Length - CommandSign.Length, CommandSign.Length) == CommandSign)
                        {

                            string colorName = message.Substring(BackColorSign.Length, message.Length - (BackColorSign.Length + CommandSign.Length));

                            if (string.IsNullOrEmpty(colorName))
                            {
                                continue;
                            }

                            Console.BackgroundColor = ColorHelper.GetConsoleColor(colorName);
                            continue;
                        }

                    }



                    //Process Console Title

                    if (message.Length > (ConsoleTitleSign.Length + CommandSign.Length))
                    {

                        if (message.Substring(0, ConsoleTitleSign.Length) == ConsoleTitleSign &&
                           message.Substring(message.Length - CommandSign.Length, CommandSign.Length) == CommandSign)
                        {

                            string title = message.Substring(ConsoleTitleSign.Length, message.Length - (ConsoleTitleSign.Length + CommandSign.Length));

                            if (string.IsNullOrEmpty(title))
                            {
                                continue;
                            }

                            Console.Title = title;
                            continue;

                        }
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


