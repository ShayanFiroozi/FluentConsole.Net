﻿/*---------------------------------------------------------------------------------------------

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
            Write(new string(' ', SpaceCount));

            return this;
        }


        public FluentConsoleBuilder AddLine(int LineWidth = 10)
        {
            Write(new string('_', LineWidth));

            return this;
        }


        public FluentConsoleBuilder AddCharacter(char character, int CharacterCount = 1)
        {
            Write(new string(character, CharacterCount));

            return this;
        }

        public FluentConsoleBuilder AddLineBreak(int LineBreakCount = 1)
        {

            for (int i = 0; i < LineBreakCount; i++)
            {
                Write(Environment.NewLine);
            }



            return this;
        }





    }


}


