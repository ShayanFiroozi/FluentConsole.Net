/*---------------------------------------------------------------------------------------------

            ► FluentConsole.Net , Working With .Net Console In Elegant Way ! ◄



 → Copyright (c) 2020-2023 Shayan Firoozi , Bandar Abbas , Iran , Under MIT License.

 → Contact : <shayan.firoozi@gmail.com>

 → GitHub repository : https://github.com/ShayanFiroozi/FluentConsole.Net

---------------------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace FluentConsoleNet.Helpers
{
    internal static class ColorHelper
    {
        private static readonly Dictionary<ConsoleColor, string> ConsoleColors = new Dictionary<ConsoleColor, string>();


        static ColorHelper()
        {
            foreach (ConsoleColor color in (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor)))
            {
                ConsoleColors.Add(color, color.ToString());
            }
        }


        internal static ConsoleColor GetConsoleColor(string consoleColorName)
        {
            return ConsoleColors.Single(color => color.Value == consoleColorName).Key;
        }
    }
}
