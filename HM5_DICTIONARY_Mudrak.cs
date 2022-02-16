using System;
using System.Collections.Generic;

namespace HM5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            uint ID;
            string Name;

            Dictionary<uint, string> dictioneryPairs = new Dictionary<uint, string>();
            do
            {

                Console.Write("Enter nummer ID (only numbers) :");           
                if (UInt32.TryParse(Console.ReadLine(), out ID))
                {
                    if (ID != 0)
                    {
                        if (dictioneryPairs.ContainsKey(ID))
                            Console.WriteLine("nummer ID already inserted");
                        else
                        {
                            Console.Write("Enter name :");
                            Name = Console.ReadLine();
                            dictioneryPairs.Add(ID, Name);
                        }
                    }
                }

            } while (ID != 0);

            Console.WriteLine("Check yr ID : ");
            uint value = Convert.ToUInt32(Console.ReadLine());
            bool keyExists = dictioneryPairs.ContainsKey(value);
            if (keyExists)
            {
                Console.WriteLine($"{dictioneryPairs.GetValueOrDefault(value)} exists in map");
            }
            else
            {
                Console.WriteLine("Person does not exist in map");
            }
            Console.ReadKey();
        }
    }
}
