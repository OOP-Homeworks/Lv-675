using System;
using System.Collections.Generic;

namespace Salnikov_HW5_2
{
    class Program
    {
        static void Main(string[] args)
        {
           
                Dictionary<uint, string> persons = new Dictionary<uint, string>();
                Console.WriteLine("Enter the Number of persons");
                int count = int.Parse(Console.ReadLine());
                for (uint i = 0; i < count; i++)
                {
                    uint id = i;
                    Console.WriteLine("Enter the name " + (i+1) + " person : ");
                    string name = Console.ReadLine();
                    persons.Add(id, name);
                }
                Console.WriteLine("Press key to display the contents of your dictionary..");
                Console.ReadLine();
                foreach (var item in persons)
                {
                    Console.Write("ID :" + item.Key + ";");
                    Console.WriteLine("  Name :" + item.Value + ";");
                }

                Console.ReadLine();

            bool answer = true;
            do
            {
                Console.Clear();

                
                Console.WriteLine("Enter the ID : ");
                uint userAnswer = uint.Parse(Console.ReadLine());
                if (userAnswer >= count) 
                {
                    Console.WriteLine("Error, there’s no such person in the dictionary. Try again.");
                    Console.ReadLine();
                    continue;
                }
                Console.WriteLine($"The name of the person with ID {userAnswer} - {persons[userAnswer]} ");
                Console.WriteLine("Do u want exit? (\"Yes\"-press 1; \"No\"- press 2;)");
                byte exit = byte.Parse(Console.ReadLine());
                if (exit == 1) { answer = false; }
            } while (answer);
            
        }
    }
}
