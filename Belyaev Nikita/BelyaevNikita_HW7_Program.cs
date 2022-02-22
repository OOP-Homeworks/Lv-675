using System;
using System.Collections.Generic;
using System.IO;

namespace HomeWork7
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\hekeemje\Desktop\test.txt"; // added this .txt file to github also

            try
            {
                var dictOfNumbers = ParsePhoneFromFile(path);

                var rightFormat = ConvertPhoneToRightFormat(dictOfNumbers);

                foreach (var item in rightFormat)
                {
                    Console.WriteLine($"{item.Value} have phone number - {item.Key}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static Dictionary<string, string> ParsePhoneFromFile(string path)
        {
            var result = new Dictionary<string, string>();

            if (File.Exists(path))
            {
                var str = File.ReadAllLines(path);

                foreach (var item in str)
                {

                    var splitText = item.Split(',');

                    if (splitText[1].Replace(" ", "").Length < 10 && splitText[1].Replace(" ", "").Length > 13)
                    {
                        throw new Exception("Phone number in not right format.");
                    }
                    else
                    {
                        result.Add(splitText[1].Replace(" ", ""), (splitText[0]));
                    }
                }
            }
            else
            {
                throw new Exception("File not found.");
            }

            return result;
        }

        private static Dictionary<string, string> ConvertPhoneToRightFormat(Dictionary<string, string> dictOfNumbers)
        {
            var rightNumbers = new Dictionary<string, string>();

            foreach (var item in dictOfNumbers)
            {
                string phoneNumber;

                if (item.Key.Length == 10) // convert 0... to +380...
                {
                    phoneNumber = "+38" + item.Key;
                    rightNumbers.Add(phoneNumber, item.Value);
                }
                else if (item.Key.Length == 11) // convert 80... to +380...
                {
                    phoneNumber = "+3" + item.Key;
                    rightNumbers.Add(phoneNumber, item.Value);
                }
                else
                {
                    rightNumbers.Add(item.Key, item.Value);
                }
            }

            return rightNumbers;
        }
    }
}
