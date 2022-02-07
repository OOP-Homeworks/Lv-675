using System;

namespace Lecture2
{


    class Program
    {


        static void Main(string[] args)
        {
            Dog myDog;
            myDog.name = "Tyson";
            myDog.mark = "Pug";
            myDog.age = 8;

            myDog.Info();
            Console.ReadLine();

        }


    }
    struct Dog
    {
        public string name;
        public string mark;
        public int age;

        public void Info()
        {
            Console.WriteLine($"My dogs name is {name}, his mark is {mark}. He is {age} years)");
        }
    }
}