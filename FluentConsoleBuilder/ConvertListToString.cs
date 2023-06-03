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


