using System;

namespace T02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string firstStr = words[0];
            string secondStr = words[1];

            int result = GetTheMultipliedValue(firstStr, secondStr);

            Console.WriteLine(result);
        }

        static int GetTheMultipliedValue(string str1, string str2)
        {
            int sum = 0;

            if (str1.Length > str2.Length)
            {
                for (int i = 0; i < str2.Length; i++)
                {
                    sum += str1[i] * str2[i];
                }

                for (int i = str2.Length; i < str1.Length; i++)
                {
                    sum += str1[i];
                }
            }
            else
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    sum += str1[i] * str2[i];
                }

                for (int i = str1.Length; i < str2.Length; i++)
                {
                    sum += str2[i];
                }
            }

            return sum;
        }
    }
}
