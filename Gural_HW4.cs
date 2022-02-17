using System;

namespace Gural_HW4
{
    class Program
    {
        static void Main(string[] args)
        {

            //1
            int current_year = 2022;
            int n = 6;
            Person[] people = new Person[n];
            for(int i = 0; i < n; i++)
            {
                
                if(i == 0)
                {
                    people[i] = new Person();
                }
                else
                {
                    people[i].Input();
                }
            }

            for(int i = 0;i < n; i++)
            {
                Console.WriteLine("Person {0}",i+1);
                Console.WriteLine("Name:{0}\nAge:{1}", people[i].Name, people[i].Age(current_year));
                Console.WriteLine();
            }

            foreach (Person i in people)
            {
                if(i.Age(current_year) <= 16)
                {
                    i.ChangeName("Too young");
                }
            }

            foreach (Person i in people)
            {
                i.Output(current_year);
                Console.WriteLine();
            }

            for(int i = 0; i < n - 1; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    if(people[i] == people[j])
                    {
                        Console.WriteLine("Person {0} and person {1} have same names",i + 1, j + 1);
                    }
                }
            }

        }
    }
}
