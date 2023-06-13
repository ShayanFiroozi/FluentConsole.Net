namespace FluentConsoleNet.Helpers.Style
{
    internal class SymbolicStyleModel
    {
        public SymbolicStyleModel(FontStyle fontStyle, char asciiAlphabet, string symbolicAlphabet)
        {
            FontStyle = fontStyle;
            AsciiAlphabet = asciiAlphabet;
            SymbolicAlphabet = symbolicAlphabet;
        }

        public FontStyle FontStyle { get; set; }

        public char AsciiAlphabet { get; set; }

        public string SymbolicAlphabet { get; set; }

    }
}
