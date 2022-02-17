using System;
using System.Collections.Generic;

namespace Gural_HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = 10;
            List<IDeveloper> list = new List<IDeveloper>();
            for(int i = 0; i < n; i++)
            {
                if(i % 2 == 0)
                {
                    Programmer x = new Programmer();
                    list.Add(x);
                    list[i].Create();
                }
                else
                {
                    Builder x = new Builder();
                    list.Add(x);
                    list[i].Create();
                }
            }
            Console.WriteLine();
            list.Sort();
            foreach(object i in list)
            {
                Console.WriteLine(i);
            }

            for(int i = 0; i < n; i++)
            {
                list[i].Destroy();
            }
            Console.WriteLine("\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
            Console.WriteLine();
            

            Console.WriteLine("Task 2");
            Dictionary<uint, string> persons = new Dictionary<uint, string>();
            int k = 7;
            for(int i = 0; i < k; i++)
            {
                Console.WriteLine("Enter person ID");
                uint id = UInt32.Parse(Console.ReadLine());
                Console.WriteLine("Enter person name");
                string name = Console.ReadLine();
                persons.Add(id, name);
            }

            Console.WriteLine("Enter Id to seach");
            int g = Int32.Parse(Console.ReadLine());
            bool cheak = true;
            foreach(KeyValuePair<uint, string> pair in persons)
            {
                if(pair.Key == g)
                {
                    cheak = false;
                    Console.WriteLine("ID = {0}, Name = {1}", pair.Key, pair.Value);
                    break;
                }
            }
            if (cheak)
            {
                Console.WriteLine("ID not found");
            }
        }
    }
}

