using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\PhoneBook";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            var names = new List<string>();
            List<string> phones = new List<string>();
            for (int i = 0; i < 9; i++)
            {
                Console.Write($"Enter the name {i + 1}: ");
                names.Add(Console.ReadLine());
                Console.Write($"Enter the phone number {i + 1}: ");
                phones.Add(Console.ReadLine());

            }
            try
            {
                string file1 = @"D:\PhoneBook\phones.txt";
                string file2 = @"D:\PhoneBook\newPhones.txt";
                string file3 = @"D:\PhoneBook\New.txt";

                using (var sw = new StreamWriter(file1, false))
                {
                    for (int i = 0; i < 9; i++)
                    {
                        sw.WriteLine($"Name - {names[i]}, phone - {phones[i]}");
                    }
                }

                Console.WriteLine();
                File.Copy(file1, file2, true);

                Console.WriteLine("Enter name, that find corresponding number: ");
                string name = Console.ReadLine();
                for (int i = 0; i < 9; i++)
                {
                    if (name == names[i])
                    {
                        Console.WriteLine($"Name {name} has phone numbe - " + phones[i]);
                    }
                }

                List<string> newPhones = new List<string>();
                
                for (int i = 0; i < 9; i++)
                { 
                       newPhones.Add($"{phones[i]: +38 (0##) ### ## ##}");            
                    
                }

                using (var sw = new StreamWriter(file3, false))
                {
                    for (int i = 0; i < 9; i++)
                    {
                        sw.WriteLine($"New phone number- {newPhones[i]}");
                    }
                }


            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}

        
