using System;
using System.IO;

namespace HomeWork9b
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\hekeemje\Desktop\justText.txt";

            if (File.Exists(path))
            {
                var text = File.ReadAllLines(path);

                var WorkWithText = new WorkWithText();
                WorkWithText.CountSymbols(text);
                WorkWithText.ShortAndLongLine(text);
                WorkWithText.ContainText(text, "var");
            }
            else
            {
                Console.WriteLine("Can't find your file.");
            }
            
        }
    }
}
