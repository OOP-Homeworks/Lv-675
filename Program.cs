using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many persons will be use: ");
            int a = Convert.ToInt32(Console.ReadLine());
            var persons = new Person[a];

            for (int i = 0; i < persons.Length; i++)
            {
                persons[i] = Person.Input(i);
            }

            Console.WriteLine();

            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine($"Name of person: {persons[i].Name} " +
                    $"\nAge of person: {persons[i].Age(persons[i].BirthYear)} ");

            }

            Console.WriteLine();

            for (int i = 0; i < persons.Length; i++)
            {
                if (persons[i].Age(persons[i].BirthYear) < 16)
                {
                    Console.WriteLine("Enter new name: ");
                    string newName = Console.ReadLine();
                    persons[i].Rename(newName);
                }
                persons[i].ToString();
            }

            Console.WriteLine();

            for (int i = 0; i < persons.Length; i++)
            {
                for (int j = i + 1; j < persons.Length; j++)
                {
                    if (persons[i].Name == persons[j].Name)
                    {
                        Console.WriteLine("Persons: " + persons[i].ToString() + "\n Persons : " + persons[j].ToString());
                    }
                    else
                    { Console.WriteLine("Persons aren't equals"); }
                }
            }

        }
    }
  }
