/*---------------------------------------------------------------------------------------------

            ► FluentConsole.Net , Working With .Net Console In Elegant Way ! ◄



 → Copyright (c) 2020-2023 Shayan Firoozi , Bandar Abbas , Iran , Under MIT License.

 → Contact : <shayan.firoozi@gmail.com>

 → GitHub repository : https://github.com/ShayanFiroozi/FluentConsole.Net

---------------------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;

namespace FluentConsoleNet.Builder
{
    public sealed partial class FluentConsoleBuilder
    {

        public void Print()
        {
            _ = PrintOnConsole();

        }


        public void PrintAndLog()
        {
            string dataToLog = PrintOnConsole();

            Print();

            Logger?.LogConsole(dataToLog);
        }


        private string PrintOnConsole()
        {
            try
            {

                return ProcessMessageList();

            }
            finally
            {
                MessageList.Clear();
                Console.ResetColor();
            }
        }





    }


}


