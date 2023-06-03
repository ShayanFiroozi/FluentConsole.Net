using System;

namespace FluentConsoleNet
{
    public static class ConsoleHelper
    {

        public static readonly ConsoleBuilder Console = ConsoleBuilder.Create();

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