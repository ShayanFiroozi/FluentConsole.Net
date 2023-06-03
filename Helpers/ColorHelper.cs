using System;
using System.Collections.Generic;
using System.Linq;

namespace FluentConsoleNet.Helpers
{
    internal  static class ColorHelper
    {
        private static Dictionary<ConsoleColor, string> ConsoleColors = new Dictionary<ConsoleColor, string>();


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
