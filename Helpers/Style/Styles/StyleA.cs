namespace FluentConsoleNet.Helpers.Style
{
    internal static class StyleA
    {
        public static void InitializeStyle()
        {
            // A
            StyleHelper.AddAlphabet(FontStyle.StyleA, 'A', "▄▀█²█▀█");

            // B
            StyleHelper.AddAlphabet(FontStyle.StyleA, 'B', "█▄▄²█▄█");

            // C
            StyleHelper.AddAlphabet(FontStyle.StyleA, 'C', "█▀▀²█▄▄");
        }

    }
}
