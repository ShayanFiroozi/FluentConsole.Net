/*---------------------------------------------------------------------------------------------

            ► FluentConsole.Net , Working With .Net Console In Elegant Way ! ◄



 → Copyright (c) 2020-2023 Shayan Firoozi , Bandar Abbas , Iran , Under MIT License.

 → Contact : <shayan.firoozi@gmail.com>

 → GitHub repository : https://github.com/ShayanFiroozi/FluentConsole.Net

---------------------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;

namespace FluentConsoleNet
{
    public sealed partial class FluentConsoleBuilder
    {


       

        public FluentConsoleBuilder ClearScreen()
        {
            MessageList.Add(ClearScreenSign);
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


        public FluentConsoleBuilder Beep()
        {
            MessageList.Add(BeepSign);
            return this;
        }

        public FluentConsoleBuilder Write(string text)
        {
            MessageList.Add(text);
            return this;
        }


        public FluentConsoleBuilder Write(List<string> StringList)
        {
            for (int i = 0; i < StringList.Count; i++)
            {
                if (i < StringList.Count -1)
                {
                    MessageList.Add(StringList[i] + ",");
                }
                else
                {
                    MessageList.Add(StringList[i]);
                }
            }

            return this;
        }


        public FluentConsoleBuilder WriteLine(List<string> StringList)
        {
            foreach (string stringValue in StringList)
            {
                MessageList.Add(stringValue + Environment.NewLine);
            }

            return this;
        }


        public FluentConsoleBuilder Write(List<int> IntegerList)
        {
            for (int i = 0; i < IntegerList.Count; i++)
            {
                if (i < IntegerList.Count - 1)
                {
                    MessageList.Add(IntegerList[i].ToString() + ",");
                }
                else
                {
                    MessageList.Add(IntegerList[i].ToString());
                }
            }

            return this;
        }


        public FluentConsoleBuilder WriteLine(List<int> IntegerList)
        {
            foreach (int stringValue in IntegerList)
            {
                MessageList.Add(stringValue.ToString() + Environment.NewLine);
            }

            return this;
        }



        public FluentConsoleBuilder WriteLine(string text)
        {
            MessageList.Add(text + Environment.NewLine);

            return this;
        }



        public FluentConsoleBuilder AddSpace(int SpaceCount)
        {
            MessageList.Add(new string(' ', SpaceCount));

            return this;
        }


        public FluentConsoleBuilder AddLine(int LineWidth)
        {
            MessageList.Add(new string('_', LineWidth));

            return this;
        }


        public FluentConsoleBuilder AddCharacter(char character, int CharacterCount)
        {
            MessageList.Add(new string(character, CharacterCount));

            return this;
        }

        public FluentConsoleBuilder AddBreakLine(int BreakLineCount)
        {

            for (int i = 0; i < BreakLineCount; i++)
            {
                MessageList.Add(Environment.NewLine);
            }



            return this;
        }






        public FluentConsoleBuilder WithFontColor(ConsoleColor color)
        {

            MessageList.Add($"{FontColorSign}{color}{CommandSign}");

            return this;
        }


        public FluentConsoleBuilder WithBackColor(ConsoleColor color)
        {

            MessageList.Add($"{BackColorSign}{color}{CommandSign}");


            return this;
        }



        public FluentConsoleBuilder WithTitle(string title)
        {

            MessageList.Add($"{ConsoleTitleSign}{title}{CommandSign}");


            return this;
        }


        public FluentConsoleBuilder Print()
        {
            try
            {

                ProcessMessageList();

            }
            finally
            {
                MessageList.Clear();
                Console.ResetColor();
            }
            return this;
        }



        public FluentConsoleBuilder PrintAndLog()
        {

            string logMessage = ConvertListToString();

            Print();

            Logger?.LogConsole(logMessage);

            return this;
        }



    }


}


