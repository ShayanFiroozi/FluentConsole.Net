/*---------------------------------------------------------------------------------------------

            ► FluentConsole.Net , Working With .Net Console In Elegant Way ! ◄



 → Copyright (c) 2020-2023 Shayan Firoozi , Bandar Abbas , Iran , Under MIT License.

 → Contact : <shayan.firoozi@gmail.com>

 → GitHub repository : https://github.com/ShayanFiroozi/FluentConsole.Net

---------------------------------------------------------------------------------------------*/

using FluentConsoleNet.ConsoleExtension;
using System;
using System.Collections.Generic;

namespace FluentConsoleNet.Builder
{
    public sealed partial class FluentConsoleBuilder
    {

        // short
        public FluentConsoleBuilder Write(short number, bool formatted = false)
        {
            if (formatted)
            {
                Write($"{number:N0}");
            }
            else
            {
                Write(number.ToString());
            }

            return this;
        }

        public FluentConsoleBuilder WriteLine(short number, bool formatted = false)
        {
            if (formatted)
            {
                WriteLine($"{number:N0}");
            }
            else
            {
                WriteLine(number.ToString());
            }

            return this;
        }


        // ushort
        public FluentConsoleBuilder Write(ushort number, bool formatted = false)
        {
            if (formatted)
            {
                Write($"{number:N0}");
            }
            else
            {
                Write(number.ToString());
            }

            return this;
        }

        public FluentConsoleBuilder WriteLine(ushort number, bool formatted = false)
        {
            if (formatted)
            {
                WriteLine($"{number:N0}");
            }
            else
            {
                WriteLine(number.ToString());
            }

            return this;
        }


        // int
        public FluentConsoleBuilder Write(int number, bool formatted = false)
        {
            if (formatted)
            {
                Write($"{number:N0}");
            }
            else
            {
                Write(number.ToString());
            }

            return this;
        }

        public FluentConsoleBuilder WriteLine(int number, bool formatted = false)
        {
            if (formatted)
            {
                WriteLine($"{number:N0}");
            }
            else
            {
                WriteLine(number.ToString());
            }

            return this;
        }


        // uint
        public FluentConsoleBuilder Write(uint number, bool formatted = false)
        {
            if (formatted)
            {
                Write($"{number:N0}");
            }
            else
            {
                Write(number.ToString());
            }

            return this;
        }

        public FluentConsoleBuilder WriteLine(uint number, bool formatted = false)
        {
            if (formatted)
            {
                WriteLine($"{number:N0}");
            }
            else
            {
                WriteLine(number.ToString());
            }

            return this;
        }


        // long
        public FluentConsoleBuilder Write(long number, bool formatted = false)
        {
            if (formatted)
            {
                Write($"{number:N0}");
            }
            else
            {
                Write(number.ToString());
            }

            return this;
        }

        public FluentConsoleBuilder WriteLine(long number, bool formatted = false)
        {
            if (formatted)
            {
                WriteLine($"{number:N0}");
            }
            else
            {
                WriteLine(number.ToString());
            }

            return this;
        }


        // ulong
        public FluentConsoleBuilder Write(ulong number, bool formatted = false)
        {
            if (formatted)
            {
                Write($"{number:N0}");
            }
            else
            {
                Write(number.ToString());
            }

            return this;
        }

        public FluentConsoleBuilder WriteLine(ulong number, bool formatted = false)
        {
            if (formatted)
            {
                WriteLine($"{number:N0}");
            }
            else
            {
                WriteLine(number.ToString());
            }

            return this;
        }


        // float
        public FluentConsoleBuilder Write(float number, bool formatted = false)
        {
            if (formatted)
            {
                Write($"{number:N6}");
            }
            else
            {
                Write(number.ToString());
            }

            return this;
        }

        public FluentConsoleBuilder WriteLine(float number, bool formatted = false)
        {
            if (formatted)
            {
                WriteLine($"{number:N6}");
            }
            else
            {
                WriteLine(number.ToString());
            }

            return this;
        }



        // double
        public FluentConsoleBuilder Write(double number, bool formatted = false)
        {
            if (formatted)
            {
                Write($"{number:N6}");
            }
            else
            {
                Write(number.ToString());
            }

            return this;
        }

        public FluentConsoleBuilder WriteLine(double number, bool formatted = false)
        {
            if (formatted)
            {
                WriteLine($"{number:N6}");
            }
            else
            {
                WriteLine(number.ToString());
            }

            return this;
        }




        // decimal
        public FluentConsoleBuilder Write(decimal number, bool formatted = false)
        {
            if (formatted)
            {
                Write($"{number:N6}");
            }
            else
            {
                Write(number.ToString());
            }

            return this;
        }

        public FluentConsoleBuilder WriteLine(decimal number, bool formatted = false)
        {
            if (formatted)
            {
                WriteLine($"{number:N6}");
            }
            else
            {
                WriteLine(number.ToString());
            }

            return this;
        }


        // bool
        public FluentConsoleBuilder Write(bool boolean, bool YesNoFormat = false)
        {
            if (YesNoFormat)
            {
                if (boolean)
                {
                    Write("True");
                }
                else
                {
                    Write("False");
                }
            }
            else
            {
                if (boolean)
                {
                    Write("Yes");
                }
                else
                {
                    Write("No");
                }
            }

            return this;
        }



        // List<string>
        public FluentConsoleBuilder Write(List<string> StringList)
        {
            for (int i = 0; i < StringList.Count; i++)
            {
                if (i < StringList.Count - 1)
                {
                    Write(StringList[i] + ",");
                }
                else
                {
                    Write(StringList[i]);
                }
            }

            return this;
        }

        public FluentConsoleBuilder WriteLine(List<string> StringList)
        {
            foreach (string stringValue in StringList)
            {
                WriteLine(stringValue);
            }

            return this;
        }



        // List<int>
        public FluentConsoleBuilder Write(List<int> IntegerList, bool formatted = false)
        {
            for (int i = 0; i < IntegerList.Count; i++)
            {
                if (i < IntegerList.Count - 1)
                {
                    if (formatted)
                    {
                        Write($"{IntegerList[i]:N0}" + ",");
                    }
                    else
                    {
                        Write(IntegerList[i].ToString() + ",");
                    }
                }
                else
                {
                    if (formatted)
                    {
                        Write($"{IntegerList[i]:N0}");
                    }
                    else
                    {
                        Write(IntegerList[i].ToString());
                    }
                }
            }

            return this;
        }


        public FluentConsoleBuilder WriteLine(List<int> IntegerList, bool formatted = false)
        {
            foreach (int number in IntegerList)
            {
                if (formatted)
                {
                    WriteLine($"{number:N0}");
                }
                else
                {
                    WriteLine(number.ToString());
                }
            }

            return this;
        }



        // Number range
        public FluentConsoleBuilder Write(int from, int to, bool formatted = false)
        {

            for (int i = from; i <= to; i++)
            {
                string number;

                if (formatted)
                {
                    number = $"{i:N0}";
                }
                else
                {
                    number = i.ToString();
                }


                if (i != to)
                {
                    Write(number + ",");
                }
                else
                {
                    Write(number);
                }

            }

            return this;
        }

        public FluentConsoleBuilder WriteLine(int from, int to, bool formatted = false)
        {

            for (int i = from; i <= to; i++)
            {


                if (formatted)
                {
                    WriteLine($"{i:N0}");
                }
                else
                {
                    WriteLine(i.ToString());
                }

            }

            return this;
        }



        //DateTime

        public FluentConsoleBuilder Write(DateTime dateTime, string format = "yyyy-MM-dd HH:mm:ss")
        {
            Write(dateTime.ToString(format));
            return this;
        }

        public FluentConsoleBuilder WriteLine(DateTime dateTime, string format = "yyyy-MM-dd HH:mm:ss")
        {
            WriteLine(dateTime.ToString(format));
            return this;
        }


        // Exception 

        public FluentConsoleBuilder Write(Exception exception, bool JsonFormat = true)
        {
            if (JsonFormat)
            {
                Write(exception.ToJsonFormat());
            }
            else
            {
                Write(exception.ToStringFormat());
            }

            return this;
        }


        public FluentConsoleBuilder WriteLine(Exception exception, bool JsonFormat = true)
        {
            if (JsonFormat)
            {
                WriteLine(exception.ToJsonFormat());
            }
            else
            {
                WriteLine(exception.ToStringFormat());
            }

            return this;
        }


    }


}


