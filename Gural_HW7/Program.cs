using System;
using System.Collections.Generic;
using System.IO;

namespace Gural_HW7
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> PhoneBook = new Dictionary<string, string>();
            string file = "phone.txt";
            int n = 9;
            StreamReader reader = new StreamReader(file);
            string line;
            while((line = reader.ReadLine()) != null)
            {
                string[] path = line.Split(' ');
                if(path[1][0] != '+')
                {
                    string number = "+380";
                    int num = path[1].Length - 9;
                    for (int i = num; i < path[1].Length; i++)
                    {
                        number += path[1][i];
                    }
                    path[1] = number;
                }
                PhoneBook.Add(path[0], path[1]);
            }
            reader.Close();

            Console.WriteLine("Enter name");
            string name = Console.ReadLine();


            foreach(KeyValuePair<string,string> i in PhoneBook)
            {
                if(name == i.Key)
                {
                    Console.WriteLine("{0}, {1}", i.Key, i.Value);
                    break;
                }
                
            }

            StreamWriter writer = new StreamWriter("New.txt");
            foreach (KeyValuePair<string, string> i in PhoneBook)
            {
                writer.WriteLine(i.Value);
            }
            writer.Close();
        }
    }
}
