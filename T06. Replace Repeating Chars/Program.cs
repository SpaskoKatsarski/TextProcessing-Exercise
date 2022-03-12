using System;
using System.Text;

namespace T06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            
            for (int i = 0; i < inputStr.Length - 1; i++)
            {
                char currChar = inputStr[i];

                while (inputStr[i] == inputStr[i + 1])
                {
                    i++;

                    if (i > inputStr.Length - 2)
                    {
                        break;
                    }
                }
                
                result.Append(currChar);
            }

            if (inputStr.Length < 2) 
            {
                Console.WriteLine(inputStr[0]);
                return;
            }

            if (inputStr[inputStr.Length - 1] != inputStr[inputStr.Length - 2])
            {
                result.Append(inputStr[inputStr.Length - 1]);
            }

            Console.WriteLine(result);
        }
    }
}
