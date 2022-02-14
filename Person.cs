using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_
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
            name = "Dima";
            birthYear = 2002;
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

        public static bool operator ==(Person first, Person second)
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
            return "Person's name : " + Name + "\nBirthday of person: " + BirthYear + "\n Person's age: " + person.Age(BirthYear);
        }

    }
 }
