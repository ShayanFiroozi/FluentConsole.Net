namespace FluentConsoleNet
{
    public partial class ConsoleBuilder
    {

        private string ConvertListToString()
        {
            string result = string.Empty;

            for (int i = 0; i < messageList.Count; i++)
            {
                result += messageList[i];
            }

            return result;
        }




    }


}


