using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            int countingA = 0;
            int countingO = 0;
            int countingI = 0;
            int countingE = 0;
            Console.WriteLine("Enter the line of symbols: ");
            str = Console.ReadLine();
            for (int i = 0; i < str.Length; i++) // Get access to each letter
            {
                switch (str[i])      // Checking every letter
                {
                    case 'a':
                    case 'A':
                        countingA++; // Counting each letter "a"
                        break;
                    case 'o':
                    case 'O':
                        countingO++; // Counting each letter "o"
                        break;
                    case 'i':
                    case 'I':
                        countingI++; // Counting each letter "i"
                        break;
                    case 'e':
                    case 'E':
                        countingE++; // Counting each letter "e"
                        break;
                }
            }
            Console.WriteLine($"First: {countingA}\nSecond: {countingO}\nThird: {countingI}\nFourth: {countingE}");
            if (countingA == 0 && countingO == 0 && countingI == 0 && countingE == 0)
                Console.WriteLine("No vowels found");
        }
    }
}
