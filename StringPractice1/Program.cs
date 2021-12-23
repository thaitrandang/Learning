using System;

namespace StringPractice1
{
    internal class Program
    {

        static int GetLengthOfStringFunc(string myString)
        {
            // Practice 1 : 
            // Write the program to find the length of a string without using library
            int lengthOfString = 0;
            foreach (char myChar in myString)
            {
                lengthOfString += 1;
            }
            return lengthOfString;
        }

        static void SeparateTheIndividualCharacters(string myString)
        {
            // Practice 2:  Write the program to separate the individual characters from a string
            char[] myChar = myString.ToCharArray();
            Console.WriteLine("\nThe character of the string are : ");
            for (int i = 0; i < myString.Length; i++)
            {
                Console.Write("{0,4}", myString[i]);
            }
        }

        static void PrintIndiCharReverseOder(string myString)
        {
            char[] myChar = myString.ToCharArray();
            Console.WriteLine("\nThe character of the string in reverse are : ");
            for (int i = myString.Length - 1; i >= 0; i--)
            {
                Console.Write("{0,4}", myString[i]);
            }
        }

        static void Main(string[] args)
        {

            // 1 . Enter any string
            Console.WriteLine(" Input a String :");
            string myString = Console.ReadLine();

            // 2 . Create a function to count the length of a string

            int lengthOfString = GetLengthOfStringFunc(myString);

            // 3 . Practice 1 : find the length of a string
            Console.Write($" Length of the String is : {lengthOfString}");

            // 4 . Practice 2 :
            // Create a function to separate the individual characters from a string
            SeparateTheIndividualCharacters(myString);

            // 5 . Practice 3 : 
            // Create a function to print individual characters of the string in reverse order
            PrintIndiCharReverseOder(myString);

        }
    }
}
