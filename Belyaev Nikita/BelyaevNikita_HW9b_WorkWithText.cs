using System;
using System.Linq;

namespace HomeWork9b
{
    class WorkWithText
    {
        public void CountSymbols(string[] text)
        {
            var countLine = 1;

            foreach (var item in text)
            {
                Console.WriteLine($"Line {countLine++} have {item.LongCount()} symbols.");
            }
        }

        public void ShortAndLongLine(string[] text)
        {
            var longest = text.OrderByDescending(s => s.Length).First();
            var shortest = text.OrderByDescending(s => s.Length).Last();

            Console.WriteLine($"Longest line : {longest}");
            Console.WriteLine($"Shortest line : {shortest}");
        }

        public void ContainText(string[] text, string containWord)
        {
            foreach (var item in text)
            {
                if (item.Contains(containWord))
                {
                    Console.Write($"This line contains '{containWord}' : ");
                    Console.WriteLine(item);
                }
            }
        }
    }
}
