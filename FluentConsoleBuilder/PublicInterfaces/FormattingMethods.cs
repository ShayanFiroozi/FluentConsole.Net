/*---------------------------------------------------------------------------------------------

            ► FluentConsole.Net , Working With .Net Console In Elegant Way ! ◄



 → Copyright (c) 2020-2023 Shayan Firoozi , Bandar Abbas , Iran , Under MIT License.

 → Contact : <shayan.firoozi@gmail.com>

 → GitHub repository : https://github.com/ShayanFiroozi/FluentConsole.Net

---------------------------------------------------------------------------------------------*/

using System;

namespace FluentConsoleNet.Builder
{
    public sealed partial class FluentConsoleBuilder
    {

        public FluentConsoleBuilder AddSpace(int SpaceCount = 1)
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

        public FluentConsoleBuilder AddLineBreak(int BreakLineCount = 1)
        {

            for (int i = 0; i < BreakLineCount; i++)
            {
                MessageList.Add(Environment.NewLine);
            }



            return this;
        }





    }


}


