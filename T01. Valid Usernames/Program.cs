using System;

namespace T01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernamesToValidate = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (string username in usernamesToValidate)
            {
                if (username.Length > 3 && username.Length < 16)
                {
                    bool isValid = true;

                    for (int i = 0; i < username.Length; i++)
                    {
                        if (!char.IsLetterOrDigit(username[i]) && (username[i] != '-' && username[i] != '_'))
                        {
                            isValid = false;
                        }
                    }

                    if (isValid)
                    {
                        Console.WriteLine(username);
                    }
                }
            }
        }
    }
}
