using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string newStr = "";
            string Str = Console.ReadLine();
            int only = OnlyBrackets(ref newStr, Str);
            int psp = IfPSP(ref newStr);

        }

        static int OnlyBrackets(ref string newStr, string Str)
        {

            int only = 0;
            for (int i = 0; i < Str.Length; i++)
            {
                if ((Str[i] == '(') || (Str[i] == ')') || (Str[i] == '[') || (Str[i] == ']') || (Str[i] == '{') || (Str[i] == '}'))
                {
                    newStr = newStr + Str[i];
                }

            }

            return only;
        }
        static int IfPSP(ref string newStr)
        {
            char[] nullStr = newStr.ToCharArray();
            int psp = 0;
            int sum = 0;
            // ()
            for (int i = 0; i < nullStr.Length; i++)
            {
                if (nullStr[i] == '(')
                {
                    for (int j = i; j < nullStr.Length; j++)
                    {
                        if (nullStr[j] == ')')
                        {
                            nullStr[i] = '0';
                            nullStr[j] = '0';
                            break;
                        }
                    }
                }
            }
            //[]
            for (int i = 0; i < nullStr.Length; i++)
            {
                if (nullStr[i] == '[')
                {
                    for (int j = i; j < nullStr.Length; j++)
                    {
                        if (nullStr[j] == ']')
                        {
                            nullStr[i] = '0';
                            nullStr[j] = '0';
                            break;
                        }
                    }
                }
            }
            //{}
            for (int i = 0; i < nullStr.Length; i++)
            {
                if (nullStr[i] == '{')
                {
                    for (int j = i; j < nullStr.Length; j++)
                    {
                        if (nullStr[j] == '}')
                        {
                            nullStr[i] = '0';
                            nullStr[j] = '0';
                            break;
                        }
                    }
                }
            }

            for (int i = 0; i < nullStr.Length; i++)
            {
                if (nullStr[i] != 0)
                {
                    sum = 1;
                }
            }
            if (sum == 0)
            {
                Console.WriteLine("Строка с правильной скобочной последовательностью");

            } else Console.WriteLine("Строка с неправильной скобочной последовательностью");

            return psp;
        }
    }
}
