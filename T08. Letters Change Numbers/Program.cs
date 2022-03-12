using System;

namespace T08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sequenceArr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            decimal totalSum = 0;

            foreach (string combination in sequenceArr)
            {
                // Here we receive a single combination of letters and digits as shown: "A12b".
                // We have to find the position in the English alphabet of the two letters.

                char firstLetter = combination[0];
                char lastLetter = combination[combination.Length - 1];

                int positionOfFirstLetter = GetPositionInAlphabet(firstLetter);
                int positionOfLastLetter = GetPositionInAlphabet(lastLetter);

                decimal currNumber = decimal.Parse(combination.Substring(1, combination.Length - 2));

                if (char.IsUpper(firstLetter))
                {
                    currNumber /= positionOfFirstLetter;
                }
                else
                {
                    currNumber *= positionOfFirstLetter;
                }

                if (char.IsUpper(lastLetter))
                {
                    totalSum += currNumber - positionOfLastLetter;
                }
                else
                {
                    totalSum += currNumber + positionOfLastLetter;
                }
            }

            Console.WriteLine($"{totalSum:f2}");
        }

        private static int GetPositionInAlphabet(char letter)
        {
            // We have to get the ASCII value of the LOWERCASE integer value of the given character.
            // LOWERCASE - 96 = result
            
            return char.ToUpperInvariant(letter) - 64;
        }
    }
}
