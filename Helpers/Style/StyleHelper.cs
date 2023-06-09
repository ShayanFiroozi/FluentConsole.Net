﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentConsoleNet.Helpers.Style
{
    internal static class StyleHelper
    {
        internal static readonly List<SymbolicStyleModel> SymbolicStylesList = new List<SymbolicStyleModel>();


        private static void InitializeAllStyles()
        {
            SymbolicStylesList.Clear();

            StyleA.InitializeStyle();
        }

        public static void AddAlphabet(FontStyle fontStyle, char asciiAlphabet, string symbolicAlphabet)
        {
            if (SymbolicStylesList.Exists(style => style.FontStyle == fontStyle && style.AsciiAlphabet == asciiAlphabet && style.SymbolicAlphabet == symbolicAlphabet))
            {
                // The data is already exists on list.
                return;
            }

            SymbolicStylesList.Add(new SymbolicStyleModel(fontStyle, asciiAlphabet, symbolicAlphabet));


        }


        public static string GetSymbolicAlphabet(FontStyle fontStyle, char asciiAlphabet)
        {
            if (!SymbolicStylesList.Any())
            {
                InitializeAllStyles();
            }


            if (SymbolicStylesList.Exists(s => s.FontStyle == fontStyle && s.AsciiAlphabet == asciiAlphabet))
            {
                return SymbolicStylesList.First(s => s.FontStyle == fontStyle && s.AsciiAlphabet == asciiAlphabet).SymbolicAlphabet;
            }
            else
            {
                // if the symbolic alphabet is not available , at least we return the alphabetic character itself !!
                return asciiAlphabet.ToString();
            }


        }


        public static string GetSymbolicText(FontStyle fontStyle, string text)
        {
            StringBuilder line1 = new StringBuilder();
            StringBuilder line2 = new StringBuilder();

            foreach (char character in text)
            {
                if (char.IsWhiteSpace(character))
                {
                    line1.Append("  ");
                    line2.Append("  ");

                    continue;
                }


                if (!char.IsLetterOrDigit(character)) continue;

                try

                {

                    string wholeSymbolicText = GetSymbolicAlphabet(fontStyle, char.ToUpper(character));

                    string part1 = wholeSymbolicText.Split('²')[0] + ' ';
                    string part2 = wholeSymbolicText.Split('²')[1] + ' ';

                    line1.Append(part1);
                    line2.Append(part2);
                }
                catch
                {
                    // If error occured filled the failed character with itself !
                    line1.Append(character);
                    line2.Append(character);
                }
            }


            return line1 + Environment.NewLine + line2;
        }

    }
}
