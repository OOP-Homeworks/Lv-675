

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


  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    internal class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
        }

        private int birthYear;
        public int BirthYear
        {
            get { return birthYear; }
        }

        public Person()
        {
            name = "Yan";
            birthYear = 2001;
        }

        public Person(string name, int birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }

        public static Person Input(int i)
        {
            Console.Write($"Enter {i + 1} name of person: ");
            string name = Console.ReadLine();
            Console.Write($"Enter {i + 1} birthday of person: ");
            int birthYear = Convert.ToInt32(Console.ReadLine());
            Person person = new Person(name, birthYear);
            return person;
        }

        public void Output()
        {
            Console.WriteLine("Name of person - " + name + "\nBirthday of person - " + birthYear);
        }

        public int Age(int birthday)
        {
            int age = DateTime.Now.Year - birthYear;
            return age;
        }

        public void Rename(string NewName)
        {
            name = NewName;
        }

        public static bool operator == (Person first, Person second)
        {
            return (first.name == second.name);
        }

        public static bool operator !=(Person first, Person second)
        {
            return !(first.name == second.name);

        }
        public override string ToString()
        {
            Person person = new Person();
            return "Person's name : " + Name + "\nBirthday of person: " + BirthYear +"\n Person's age: " + person.Age(BirthYear);
        }

    }
}
