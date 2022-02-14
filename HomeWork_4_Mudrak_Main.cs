using System;
using System.Collections.Generic;
using System.Linq;
using HomeWork;


namespace NomeWork03
{
    class HM3
    {
        static void Main(string[] args)
        {
            var persons = new Person[6];
            for (int i = 0; i < persons.Length; i++)
            {
                persons[i] = Person.Input(i);
                persons[i].Output();
                persons[i].Age();
                persons[i].ChangeName();

            }
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
                        Console.WriteLine($"У нас у списку декілька {persons[a].Name}-ів  ");
                    } //Якось так
                }
            }

        }
    }
}
