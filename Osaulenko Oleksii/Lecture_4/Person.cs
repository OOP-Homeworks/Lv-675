using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    public class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int birthYear;
        public int BirthYear
        {
            get { return birthYear; }
            set { birthYear = value; }
        }

        public Person(string name, int birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }

        public int Age()
        {
            int age = (DateTime.Now.Year - birthYear);
            return age;
        }

        public static Person Input(int i)
        {
            Console.Write($"Enter {i + 1} name: ");
            string name = Console.ReadLine();
            Console.Write($"Enter {i + 1} birthay year: ");
            int birthYear = Convert.ToInt32(Console.ReadLine());
            Person person = new Person(name, birthYear);
            return person;
        }
        public void ChangeName(int age)
        {
            if (age < 16)
            {
                name = "Very Young";
            }
        }
        public void Output()
        {
            Console.WriteLine($"Name - {name}, birthday year - {birthYear}");
        }
        public static bool operator == (Person first, Person second)
        {
            return (first.name == second.name);
        }

        public static bool operator != (Person first, Person second)
        {
            return !(first.name == second.name);
        }
    }
}
