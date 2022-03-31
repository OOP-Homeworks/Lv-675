using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace HW9_2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
            string[] text = File.ReadAllLines(@"E:\Programming\HomeWork for SoftServe\Home Work 9\Home Work 9\Program.cs");
           
            //foreach (string line in text)
            //{
            //    Console.WriteLine(line);
            //}
            
            string path = @"E:\Programming\HomeWork for SoftServe\Home Work 9.1\text.txt";
            if (!File.Exists(path))
                using (FileStream fc = File.Create(path)) { }
            
            

            using (StreamWriter sw = new StreamWriter(path, false))
            {
                int result = 0;
                foreach (string i in text)
                {
                    result += i.Length;
                }
                sw.WriteLine($"The sum of all characters in text: {result} ");
                sw.WriteLine();
         
                var Maximum = text.OrderByDescending(a => a.Length).First().ToString();
                var Minimum = text.OrderBy(a => a.Length).First().ToString();

                sw.WriteLine($"The longest line:'{Maximum}', " +
                    $"value of line - {Maximum.Length}." +
                    $"\nthe shortest line:'{Minimum}'" +
                    $", value of line - {Minimum.Length}.");
                sw.WriteLine();

                Regex regex = new Regex(@"var(\w*)");
                foreach (string line in text) 
                {
                    MatchCollection matches = regex.Matches(line);
                    foreach (Match match in matches)
                    {
                        sw.WriteLine($"line contains 'var': {match.Value}");
                    }
                }
            }

            string text_1 = File.ReadAllText(path);
            Console.WriteLine(text_1);
                     
        }
    }
}
