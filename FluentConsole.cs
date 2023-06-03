/*---------------------------------------------------------------------------------------------

            ► FluentConsole.Net , Working With .Net Console In Elegant Way ! ◄



 → Copyright (c) 2020-2023 Shayan Firoozi , Bandar Abbas , Iran , Under MIT License.

 → Contact : <shayan.firoozi@gmail.com>

 → GitHub repository : https://github.com/ShayanFiroozi/FluentConsole.Net

---------------------------------------------------------------------------------------------*/

using System;

namespace FluentConsoleNet
{
    public static class FluentConsole
    {

        public static FluentConsoleBuilder Console => FluentConsoleBuilder.Create();


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