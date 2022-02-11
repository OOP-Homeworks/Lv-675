using System;
using System.Collections.Generic;
using System.Text;

namespace Gural_HW4
{
    class Person
    {
        string name;
        public string Name
        {
            get
            {
                return this.name;
            }
        }
        DateTime birthYear;
        public DateTime BirthYear
        {
            get
            {
                return this.birthYear;
            }
        }

        public Person()
        {
            this.name = "Mark";
            this.birthYear = new DateTime(2001, 1, 1);
        }

        public Person(string n, int y)
        {
            this.name = n;
            this.birthYear = new DateTime(y, 1, 1);
        }

        public int Age(int current_year)
        {
            return current_year - this.birthYear.Year;
        }

        public void Input()
        {
            Console.WriteLine("Entering date for current person...");
            Console.WriteLine("Enter Name of your person");
            this.name = Console.ReadLine();
            Console.WriteLine("Enter birth year of your person");
            this.birthYear = new DateTime(Int32.Parse(Console.ReadLine()),1,1);
        }

        public void ChangeName(string n)
        {
            this.name = n;
        }

        public override string ToString()
        {

            return "Person info \nName:" + this.name + 
                "\nBirth Year:" + this.birthYear.Year;
        }

        public void Output(int n)
        {
            Console.WriteLine(this);
            Console.WriteLine( this.Age(n));
        }

        public static bool operator == (Person p1, Person p2)
        {
            if(p1.name.ToLower() == p2.name.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator != (Person p1, Person p2)
        {
            if (p1.name.ToLower() != p2.name.ToLower())
            {
                return false;
            }
            else
            {
                return true;
            }
        }


    }
    
}