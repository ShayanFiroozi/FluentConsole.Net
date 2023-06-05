/*---------------------------------------------------------------------------------------------

            ► FluentConsole.Net , Working With .Net Console In Elegant Way ! ◄



 → Copyright (c) 2020-2023 Shayan Firoozi , Bandar Abbas , Iran , Under MIT License.

 → Contact : <shayan.firoozi@gmail.com>

 → GitHub repository : https://github.com/ShayanFiroozi/FluentConsole.Net

---------------------------------------------------------------------------------------------*/

namespace FluentConsoleNet.Builder
{
    public sealed partial class FluentConsoleBuilder
    {

        private FluentConsoleBuilder(dynamic Logger)
        {
            this.Logger = Logger;
        }


        public static FluentConsoleBuilder Create(dynamic Logger)
        {
            return new FluentConsoleBuilder(Logger);
        }


    }


}


