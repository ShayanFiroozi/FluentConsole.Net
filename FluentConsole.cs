using System;
using System.Collections.Generic;
using FluentConsole.Net.Helpers;

namespace FluentConsoleNet
{
    public class ConsoleBuilder
    {

        private dynamic Logger = null;
        private readonly List<string> messageList = new List<string>();

        internal void AttachLogger(dynamic logger)
        {
            Logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        private ConsoleBuilder() { }


        public static ConsoleBuilder Create()
        {
            return new ConsoleBuilder();
        }

        public ConsoleBuilder Write(string text)
        {
            messageList.Add(text);
            return this;
        }

        public ConsoleBuilder WriteLine(string text)
        {
            messageList.Add(text  + Environment.NewLine);
            
            return this;
        }

        public ConsoleBuilder WithColor(ConsoleColor color)
        {
            if (messageList.Count == 1)
            {
                messageList.Insert(0, $"[{color}]");
                messageList.Add($"[/{color}]");
            }
            else if (messageList.Count > 1)
            {
                messageList.Insert(GetLastIndex(), $"[{color}]");
                messageList.Add($"[/{color}]");
            }

            return this;
        }


        public ConsoleBuilder Print()
        {
            try
            {

                ProcessMessageList();

            }
            finally
            {
                messageList.Clear();
                Console.ResetColor();
            }
            return this;
        }

        public ConsoleBuilder PrintAndLog()
        {

            string finalMessage = ConvertListToString();

            Print();

            Logger?.LogConsole(finalMessage);

            return this;
        }

      
        private int GetLastIndex()
        {
            return messageList.Count - 1;
        }

        private string ConvertListToString()
        {
            string result = string.Empty;

            for (int i = 0; i < messageList.Count; i++)
            {
                result += messageList[i];
            }

            return result;
        }

        private void ProcessMessageList()
        {
            foreach (string message in messageList)
            {
                if (message.Length == 0)
                {
                    continue; // Skip this message
                }

                if (message == Environment.NewLine)
                {
                    Console.WriteLine();
                    continue;
                }

                if (message.Substring(0, 1) == "[")
                {
                    if (message.Substring(1, 1) == "/")
                    {
                        Console.ResetColor();
                        continue;
                    }
                    else
                    {
                        int leftBracket = message.LastIndexOf('[');
                        int rightBracket = message.LastIndexOf(']');

                        if (leftBracket == -1 || rightBracket == -1) continue;

                        string colorName = message.Substring(leftBracket + 1, (rightBracket - leftBracket) - 1);

                        if (string.IsNullOrEmpty(colorName))
                        {
                            continue;
                        }

                        Console.ForegroundColor = ColorHelper.GetConsoleColor(colorName);
                        continue;
                    }
                }

                Console.Write(message);

            }



        }


    }

}
