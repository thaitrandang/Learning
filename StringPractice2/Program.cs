using System;
using System.Collections.Generic;

namespace StringPractice2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1 . Enter any string
            Console.WriteLine(" Input the \"Firt String\" : ");
            string firtString = Console.ReadLine();
            Console.WriteLine(" Input the \"Second String\" : ");
            string secondString = Console.ReadLine();

            // 2 . Compare two Strings
            bool isEqual = isStringsEqual(firtString,secondString);

            // 3 . Print result
            PrintResult(isEqual);

            // 4 . Count total number of alphabets, digits and special characters
            Dictionary<string, int> statisticalDictionary = GetCountDisTinctChar(firtString);
            PrintDict(statisticalDictionary);
        }
       

        static bool isStringsEqual(string firtString, string secondString)
        {
            return (firtString == secondString);
        }

        static void PrintResult(bool isEqual)
        {
            if(isEqual)
            {
                Console.WriteLine("String are Equal");
            }
            else
            {
                Console.WriteLine("String are not Equal");
            }
        }

        static Dictionary<string , int> GetCountDisTinctChar(string myString)
        {
            Dictionary<string, int> statisticalDictionary = new Dictionary<string, int>();
            int countNumOfAlphabets = 0;
            int countNumOfDigits = 0;
            int countNumOfSpChar = 0;
            for (int i = 0; i < myString.Length; i++)
            {
                if ((myString[i] >= 'a' && myString[i] <= 'z') || (myString[i] >= 'A' && myString[i] <= 'Z'))
                {
                    countNumOfAlphabets++;                   
                }
                else if (myString[i] >= '0' && myString[i] <= '9')
                {
                    countNumOfDigits++;                  
                }
                else
                {
                    countNumOfSpChar++;                 
                }
            }
            statisticalDictionary.Add(" Number of Alphabets in the String is : ", countNumOfAlphabets);
            statisticalDictionary.Add(" Number of Digits in the String is : ", countNumOfDigits);
            statisticalDictionary.Add(" Number of Special in the String is : ", countNumOfSpChar);
            return statisticalDictionary;
        }

        static void PrintDict(Dictionary<string , int> statisticalDictionary)
        {
            foreach (KeyValuePair<string , int> item in statisticalDictionary)
            {
                Console.WriteLine(item.Key + "{0,5}" , item.Value);
            }
        }

        static void SwitchPositionElement (char[] myString)
        { 
            for (int k = 0; k < myString.Length - 2; k++)
            {
                for (int i = 0; i < myString.Length - 2; i++)
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
