using System;
using System.Text;

namespace T07._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();

            StringBuilder result = new StringBuilder();

            int punches = 0;

            for (int i = 0; i < inputStr.Length; i++)
            {
                char currChar = inputStr[i];

                if (currChar == '>')
                {
                    result.Append(currChar);

                    int currPunches = int.Parse(inputStr[i + 1].ToString());
                    punches += currPunches;
                }
                else
                {
                    if (punches > 0)
                    {
                        punches--;
                    }
                    else
                    {
                        result.Append(currChar);
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
