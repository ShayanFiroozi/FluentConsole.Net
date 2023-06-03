namespace FluentConsoleNet.ConsoleExtension
{
    public static partial class ExtensionMethods
    {

        public static void PrintOnConsole(this bool boolean, bool YesNoFormat = false)
        {
            FluentConsole.Console.WriteLine(YesNoFormat ? (boolean ? "Yes" : "No") : boolean.ToString()).Print();
            
        }


    }
}
