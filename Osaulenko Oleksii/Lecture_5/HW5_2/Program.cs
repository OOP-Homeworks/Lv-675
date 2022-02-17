using System;
using System.Collections.Generic;


namespace HomeWork5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new Persons[7];
            Dictionary<uint, string> map = new Dictionary<uint, string>();
            for (int i = 0; i < persons.Length; i++)
            {
                persons[i] = Persons.Input();
                map.Add(persons[i].Id, persons[i].Name);
            }
            
            Console.Write("Enter person Id: ");
            uint find_id = Convert.ToUInt32(Console.ReadLine());

            if (map.ContainsKey(find_id))
            {
                Console.WriteLine($"The name of person with Id {find_id} is {map[find_id]}");
            }
            else 
            { 
                Console.WriteLine($"The person with Id {find_id} not found"); 
            }
        }
    }
}
