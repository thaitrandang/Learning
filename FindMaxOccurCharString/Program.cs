using System;
using System.Collections.Generic;

namespace FindMaxOccurCharString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tìm kí tự xuất hiện nhiều nhất trong chuỗi

            // 1 . Nhập vào một chuỗi bất kỳ Welcome to w3resource.com
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(" Input A String ");
            string myString = Console.ReadLine();

            // 2 . Biến chuỗi đó thành mảng ký tự
            char[] charArr = myString.ToCharArray();

            //3 . Add các kí tự cùng số lần xuất hiện vào Dict . Đồng thời tìm số lần xuất hiện max
            int max = 1;
            Dictionary<char, int> maxFrequencyCharDict = new Dictionary<char, int>();

            for (int i = 0; i < myString.Length; i++)
            {
                if (maxFrequencyCharDict.ContainsKey(myString[i])) // Kiểm tra trùng lặp ký tự trong Dict
                {
                    maxFrequencyCharDict[myString[i]]++; // Nếu trùng lặp tăng Value lên +1
                    max = maxFrequencyCharDict[myString[i]];  // Gán max là phàn tử vừa ++ lên
                    if (max < maxFrequencyCharDict[myString[i]]) // Nếu max nhỏ hơn kí tự nào
                    {
                        max = maxFrequencyCharDict[myString[i]]; // thì kí tự ấy là max
                    }
                }
                else
                {
                    maxFrequencyCharDict.Add(myString[i], 1); // Nếu không trùng lặp thì Value = 1
                }
            }

            // 4. In ra Từ điển chứa ký tụ nhiều nhất
            foreach (KeyValuePair<char, int> character in maxFrequencyCharDict)
            {
                if (character.Value == max) // Chỉ in kí tự trong từ điển có Value max
                {
                    Console.WriteLine($" The Highest frequency of character : ' {character.Key} ' " + $" Appear number of times : {max}  ");
                }
            }
        }
    }
}
