using System;

namespace Salnikov_HW4
{
    class Program
    {
        static void Main(string[] args)
        {

            var persons = new Person[5];
            for (int i = 0; i < persons.Length; i++)
            {
                persons[i] = Person.Input(i);
                persons[i].Output();
                persons[i].ChangeName();
            }
            Console.Clear();
            for (int i = 0; i < persons.Length; i++)
            {
                persons[i].Output();
            }

            for (int a = 0; a < persons.Length; a++)
            {
                for (int j = a + 1; j < persons.Length; j++)
                {
                    if (persons[a].Name == (persons[j].Name))
                    {
                        Console.WriteLine($"We have {j-1} {persons[a].Name}s  ");
                    } 
                }
            }

        }
    }
}
