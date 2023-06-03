using System;

namespace FluentConsoleNet
{
    public static class FluentConsole
    {

        public static readonly FluentConsoleBuilder Console = FluentConsoleBuilder.Create();

        public static void AttachLogger(dynamic logger)
        {
            if (logger is null)
            {
                throw new ArgumentNullException(nameof(logger));
            }

            Console.AttachLogger(logger);

        }


    }
}