using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace T05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string strOfBigNumber = Console.ReadLine();
            //int multiplyingNumber = int.Parse(Console.ReadLine());

            //StringBuilder finalNum = new StringBuilder();

            //int residue = 0;

            //for (int i = strOfBigNumber.Length - 1; i >= 0; i--)
            //{
            //    // 9999 * 9 -> 89991

            //    string currentDigitInStringFormat = strOfBigNumber[i].ToString();

            //    string currMultRslt = string.Empty; 

            //    if (residue > 0)
            //    {
            //        currMultRslt = (int.Parse(currentDigitInStringFormat) * multiplyingNumber + residue).ToString();
            //    }
            //    else
            //    {
            //        currMultRslt = (int.Parse(currentDigitInStringFormat) * multiplyingNumber).ToString();
            //    }
                
            //    finalNum.Append(currMultRslt[currMultRslt.Length - 1]);

            //    if (currMultRslt.Length > 1) 
            //    {
            //        // 9 * 9 -> 18
            //        residue = int.Parse(currMultRslt.Substring(0, currMultRslt.Length - 1));
            //    }
            //}

            //finalNum.Append(residue);
            //Console.WriteLine(string.Join("", finalNum.ToString().Reverse()));

            BigInteger number = BigInteger.Parse(Console.ReadLine());

            number *= int.Parse(Console.ReadLine());

            Console.WriteLine(number.ToString());
        }
    }
}
