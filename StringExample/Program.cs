using System;
using System.Text;

namespace StringExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // tach chuoi ra ki tu rieng biet
            string s1 = "Hello Em Zai"; //-- mang ki tu
            //char[] charArray = s1.ToCharArray();
            //for (int i = 0; i < s1.Length; i++)
            //{
            //    Console.WriteLine($"Ki tu thu {i} la ");
            //    Console.WriteLine(s1[i]);
            //}
            //foreach (char item in s1)
            //{ 
            //    console.writeline(item);
            //}
            char[] s2 = new char[] { 'E', 'M' ,' ', 'Z', 'A','I' };
            string c = new string(s2);
            Console.WriteLine(c);
        }
    }
}
