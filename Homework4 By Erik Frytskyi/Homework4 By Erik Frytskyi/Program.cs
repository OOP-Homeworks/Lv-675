using System;

namespace Homework4_By_Erik_Frytskyi
{
    class Program
    {
        static void Main(string[] args)
        {
 
            Person [] people = new Person [6];
            for (int i = 0; i < people.Length; i++)
            {
                people[i] = new Person();
                people[i].Input();
                Console.WriteLine("_______________________");
            }
            Console.WriteLine();
            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine(people[i].Name);
                Console.WriteLine(people[i].Age());
                Console.WriteLine("_______________________");
            }
            Console.WriteLine();
            for (int i = 0; i < people.Length; i++)
            {
                if(people[i].Age() < 16)
                {
                    people[i].Name = "Very Young";
                }
                Console.WriteLine("_______________________");
            }
            Console.WriteLine();
            for (int i = 0; i <  people.Length; i++)
            {
                people[i].Output();
                Console.WriteLine("_______________________");
            }
            Console.WriteLine();

            for (int i = 0; i < people.Length; i++)
                for (int j = i + 1; j < people.Length; j++)
                    if (people[i] == people[j])
                    {
                        people[i].Output();
                        people[j].Output();
                        Console.WriteLine("_______________________");
                    }
        }
    }
}
