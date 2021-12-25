using System;

namespace SortPractice3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Input a String");
            string myString = Console.ReadLine();
            char[] charArr = myString.ToCharArray();
            SwitchPositionElement(charArr);
            string sortString = new string(charArr);
            Console.WriteLine(charArr);
        }

        static void SwitchPositionElement(char[] myString)
        {
            for (int k = 0; k <= myString.Length - 2; k++)
            {
                for (int i = 0; i <= myString.Length - 2; i++)
                {
                    if (myString[i] > myString[i + 1])
                    {
                        char tempChar = myString[i];
                        myString[i] = myString[i + 1];
                        myString[i + 1] = tempChar;
                    }
                }
            }
        }
    }
}
