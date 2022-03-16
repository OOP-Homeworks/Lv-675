using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Salnikov_HW7
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> PhoneBook = new Dictionary<string, string>(9);
            string phonesFile = "C:/Users/Acer/source/repos/Salnikov_HW7/Salnikov_HW7/phones.txt";
   
             using (StreamReader sr = new(phonesFile, System.Text.Encoding.Default)) 
             {
                 byte length = 9; // some magic numb :(
                 string[] str = new string[length];
                 string[] name = new string[length];
                 string[] number = new string[length];

                 string temp = "";

                 for (int i = 0; i < length ; i++)
                 {
                     str[i] = File.ReadLines("C:/Users/Acer/source/repos/Salnikov_HW7/Salnikov_HW7/phones.txt").Skip(i).First();
                     temp = str[i];

                     for (int k = 0; k < temp.Length; k++)
                     {
                         if (char.IsLetter(temp[k]))
                         {
                             name[i] = name[i] + temp[k].ToString();
                         }
                         else if (temp[k] == ' ')
                         {
                             continue;
                         }
                         else
                         {
                             number[i] = number[i] + temp[k];
                         }
                     }
                    if (number[i].StartsWith('0'))
                    {
                        number[i] = ("+38" + number[i]);
                    }
                    else if (number[i].StartsWith('8'))
                    {
                        number[i] = ("+3" + number[i]);
                    }
                    
                    PhoneBook.Add(name[i], number[i]);
                     Console.WriteLine(name[i]+ " - " + number[i]);


                    using (var writer = new StreamWriter("C:/Users/Acer/source/repos/Salnikov_HW7/Salnikov_HW7/New.txt"))
                    {
                        foreach (var kvp in PhoneBook)
                        {

                            writer.WriteLine($"{kvp.Key}\t{kvp.Value}");
                        }
                    }
                 }
             }
             a1:
            Console.WriteLine("To find a person’s number, enter his/her name  below: ");
            string value = Convert.ToString(Console.ReadLine());
            try
            {
                Console.WriteLine($"{PhoneBook.GetValueOrDefault(value)} ");
                bool nameExist = PhoneBook.ContainsKey(value);
                if (!nameExist) { Console.WriteLine("There is no such name "); }
            }
            catch (Exception ex)
            {
                Console.Write( ex.Message);
            }
            a2:
            try
            {
                
                Console.WriteLine("Do u want continue? (Y-1 / N-2)");
                byte answer = byte.Parse(Console.ReadLine());
                if (answer == 1)
                {
                    goto a1;
                }
                else { Console.WriteLine("Bye :)"); }
            }
            catch (FormatException ex)
            {

                Console.WriteLine("Invalid format", ex) ;
                goto a2;
            }
        }
    }
}
