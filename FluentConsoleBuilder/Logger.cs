/*---------------------------------------------------------------------------------------------

            ► FluentConsole.Net , Working With .Net Console In Elegant Way ! ◄



 → Copyright (c) 2020-2023 Shayan Firoozi , Bandar Abbas , Iran , Under MIT License.

 → Contact : <shayan.firoozi@gmail.com>

 → GitHub repository : https://github.com/ShayanFiroozi/FluentConsole.Net

---------------------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;

namespace FluentConsoleNet
{
    public sealed partial class FluentConsoleBuilder
    {

     

        internal void AttachLogger(dynamic logger)
        {
            Logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

      


    }


}


