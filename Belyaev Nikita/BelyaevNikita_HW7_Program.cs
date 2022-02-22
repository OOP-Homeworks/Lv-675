using System;

namespace HomeWork7
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\hekeemje\Desktop\phones.txt"; // added this .txt file to github also

            try
            {
                var phones = new Phones();

                var dictOfNumbers = Phones.ParsePhoneFromFile(path);

                var rightFormat = Phones.ConvertPhoneToRightFormat(dictOfNumbers);

                foreach (var item in rightFormat)
                {
                    Console.WriteLine($"{item.Value} have phone number - {item.Key}");
                }

                var outputPath = @"C:\Users\hekeemje\Desktop\new.txt"; // aded this .txt file also to github

                Phones.OutputInfoToFile(outputPath, rightFormat);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
