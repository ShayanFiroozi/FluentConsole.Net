/*---------------------------------------------------------------------------------------------

            ► FluentConsole.Net , Working With .Net Console In Elegant Way ! ◄



 → Copyright (c) 2020-2023 Shayan Firoozi , Bandar Abbas , Iran , Under MIT License.

 → Contact : <shayan.firoozi@gmail.com>

 → GitHub repository : https://github.com/ShayanFiroozi/FluentConsole.Net

---------------------------------------------------------------------------------------------*/

namespace FluentConsoleNet
{
    public sealed partial class FluentConsoleBuilder
    {

        private string ConvertListToString()
        {
            string result = string.Empty;

            for (int i = 0; i < MessageList.Count; i++)
            {
                result += MessageList[i];
            }

            return result;
        }




    }


}


