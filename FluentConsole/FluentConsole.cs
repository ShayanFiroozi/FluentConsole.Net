using System;
using System.Collections.Generic;

namespace FluentConsoleNet
{
    public partial class ConsoleBuilder
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
            messageList.Add(text + Environment.NewLine);

            return this;
        }



        public ConsoleBuilder WithFontColor(ConsoleColor color)
        {

            messageList.Add($"[/]{color}[/]");

            return this;
        }


        public ConsoleBuilder WithBackColor(ConsoleColor color)
        {

            messageList.Add($"bg[/]{color}bg[/]");


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






    }


}


