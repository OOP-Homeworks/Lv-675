using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace HM_Mudrak_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> PhoneBook = new Dictionary<string, string>(9);
            string phonesFile = "C:/Users/andrew/source/repos/HM_Mudrak_7/HM_Mudrak_7/phones.txt";
            string PhonesFile = "C:/Users/andrew/source/repos/HM_Mudrak_7/HM_Mudrak_7/Phoness.txt";
            string New = "C:/Users/andrew/source/repos/HM_Mudrak_7/HM_Mudrak_7/New.txt";
            using (StreamReader sr = new(phonesFile, System.Text.Encoding.Default))
            {
                string[] str = new string[9];
                string[] Name = new string[9];
                string[] Number = new string[15];
                string temp = "";
                for (int i = 0; i < 9; i++)
                {
                    str[i] = File.ReadLines("C:/Users/andrew/source/repos/HM_Mudrak_7/HM_Mudrak_7/phones.txt").Skip(i).First();

                    temp = str[i];
                    for (int k = 0; k < temp.Length; k++)
                    {
                        if (char.IsLetter(temp[k]))
                        {
                            Name[i] = Name[i] + temp[k].ToString();
                        }
                        else if (temp[k] == ' ')
                        {
                            continue;
                        }
                        else
                        {
                            Number[i] = Number[i] + temp[k];
                        }
                    }
                    Console.WriteLine(Name[i] + " " + Number[i]);
                    PhoneBook.Add(Name[i], Number[i]);
                    using (StreamWriter ff = new(PhonesFile, true, System.Text.Encoding.Default))
                    {
                        ff.WriteLine(Number[i]);
                    }
                    //sho tut robutu?
                    using StreamWriter fs = new(New, true, System.Text.Encoding.Default);
                    if (Number[i].StartsWith('0'))
                    {
                        fs.WriteLine("+3" + Number[i]);
                    } else
                    {
                        fs.WriteLine("+3" + Number[i]);
                    }
                }
            }
            string value = Convert.ToString(Console.ReadLine());
            bool nameExist = PhoneBook.ContainsKey(value);
            if (nameExist)
            {
                Console.WriteLine($"{PhoneBook.GetValueOrDefault(value)} here ur numba");
            } 
            else
            {
                Console.WriteLine("No numba in list");
            }

            Console.ReadKey();
        }
    }
}
