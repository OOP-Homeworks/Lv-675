using System;
using System.Collections.Generic;

namespace HomeWork4
{
    class Program
    {
        static List<Person> persons = new();

        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                var person = new Person();
                person.Input();
                persons.Add(person);
            }

            persons.Add(new Person("Joe Biden", DateTime.Parse("20/11/1942")));
            persons.Add(new Person("John Wick", DateTime.Parse("11/11/1911")));
            persons.Add(new Person("Micky Mouse", DateTime.Parse("21/12/2012")));

            foreach (var item in persons)
            {
                Console.WriteLine($"{item.Name} is {item.Age()} years old.");
            }

            foreach (var item in persons)
            {
                item.ChangeName();
            }

            foreach (var item in persons)
            {
                item.Output();
            }

            for (int i = 0; i < persons.Count; i++)
            {
                for (int j = i + 1; j < persons.Count; j++)
                {
                    if (persons[i].Name == (persons[j].Name))
                    {
                        Console.WriteLine($"{persons[i].Name} have the same name as {persons[j].Name}");
                    }
                }
            }
        }
    }
}
