using System;
using System.Collections.Generic;

namespace HomeWork5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new Dictionary<uint, string>();

            persons.Add(1,"Ivan");
            persons.Add(2,"Andriy");
            persons.Add(3,"Gennadiy");
            persons.Add(4,"Maria");
            persons.Add(5,"Petro");
            persons.Add(6,"Irina");
            persons.Add(7,"Angelina");

            Console.Write("Type ID of person : ");
            uint id = uint.Parse(Console.ReadLine());

            try
            {
                string person = persons[id];

                Console.WriteLine(person);
            }
            catch (Exception)
            {
                Console.WriteLine($"We dont have person with ID {id}.");
            }
        }
    }
}
