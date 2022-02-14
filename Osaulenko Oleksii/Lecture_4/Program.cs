using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int num_obj = 6;                                // Create 6 object
            var persons = new Person[num_obj];
            for (int i = 0; i < persons.Length ; i++)
            {
                persons[i] = Person.Input(i);
            }

            for (int i = 0; i < persons.Length; i++)        // Output name and age of person
            {
                int age = persons[i].Age();
                Console.WriteLine($"Person {i}, name {persons[i].Name}, age {age}");
            }

            for (int i = 0; i < persons.Length; i++)        // Change name of persons 
            {
                int age = persons[i].Age();
                persons[i].ChangeName(age);
            }
          
            for (int i = 0; i < persons.Length; i++)       // Output info about all
            {
                persons[i].Output();
            }
            
            for (int i = 0; i < persons.Length; i++)       // Output info ==
            {
                for (int j = i + 1; j < persons.Length; j++)
                {
                    if (persons[i] == persons[j])
                    {
                        Console.WriteLine($"{persons[i].Name} and {persons[j].Name} are equals");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
