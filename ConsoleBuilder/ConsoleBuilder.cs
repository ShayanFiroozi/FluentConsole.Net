using System;
using System.Collections.Generic;

namespace FluentConsoleNet
{
    public sealed partial class ConsoleBuilder
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


        public ConsoleBuilder ClearScreen()
        {
            messageList.Add(ClearScreenSign);
            return this;
        }


        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey();
        }


        public ConsoleBuilder Beep()
        {
            messageList.Add(BeepSign);
            return this;
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



        public ConsoleBuilder AddSpace(int SpaceCount)
        {
            messageList.Add(new string(' ', SpaceCount));

            return this;
        }


        public ConsoleBuilder AddCharacter(char character ,  int CharacterCount)
        {
            messageList.Add(new string(character, CharacterCount));

            return this;
        }

        public ConsoleBuilder AddBreakLine(int BreakLineCount)
        {

            for (int i = 0; i < BreakLineCount; i++)
            {
                messageList.Add(Environment.NewLine);
            }

            

            return this;
        }




        public ConsoleBuilder WithFontColor(ConsoleColor color)
        {

            messageList.Add($"{FontColorSign}{color}{CommandSign}");

            return this;
        }


        public ConsoleBuilder WithBackColor(ConsoleColor color)
        {

            messageList.Add($"{BackColorSign}{color}{CommandSign}");


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


