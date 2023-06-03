namespace FluentConsoleNet.ConsoleExtension
{
    public static partial class ExtensionMethods
    {

        #region Integral numeric types

        public static void PrintOnConsole(this sbyte number)
        {
            FluentConsole.Console.WriteLine(number.ToString()).Print();
        }

        public static void PrintOnConsole(this byte number)
        {
            FluentConsole.Console.WriteLine(number.ToString()).Print();
           
        }


        public static void PrintOnConsole(this short number, bool Formatted = false)
        {
            FluentConsole.Console.WriteLine(Formatted ? $"{number:N0}" : number.ToString()).Print();
        }


        public static void PrintOnConsole(this ushort number, bool Formatted = false)
        {
            FluentConsole.Console.WriteLine(Formatted ? $"{number:N0}" : number.ToString()).Print();
        }


        public static void PrintOnConsole(this int number, bool Formatted = false)
        {
            FluentConsole.Console.WriteLine(Formatted ? $"{number:N0}" : number.ToString()).Print();
        }


        public static void PrintOnConsole(this uint number, bool Formatted = false)
        {
            FluentConsole.Console.WriteLine(Formatted ? $"{number:N0}" : number.ToString()).Print();
        }


        public static void PrintOnConsole(this long number, bool Formatted = false)
        {
            FluentConsole.Console.WriteLine(Formatted ? $"{number:N0}" : number.ToString()).Print();
           
        }


        public static void PrintOnConsole(this ulong number, bool Formatted = false)
        {
            FluentConsole.Console.WriteLine(Formatted ? $"{number:N0}" : number.ToString()).Print();
        
        }

        #endregion


        #region Floating-point numeric types

        

        public static void PrintOnConsole(this float number, bool Formatted = false)
        {
            FluentConsole.Console.WriteLine(Formatted ? $"{number:N6}" : number.ToString()).Print();
            
        }


        public static void PrintOnConsole(this double number, bool Formatted = false)
        {
            FluentConsole.Console.WriteLine(Formatted ? $"{number:N6}" : number.ToString()).Print();
            
        }

        public static void PrintOnConsole(this decimal number, bool Formatted = false)
        {
            FluentConsole.Console.WriteLine(Formatted ? $"{number:N6}" : number.ToString()).Print();
        }


        #endregion



    }
}
