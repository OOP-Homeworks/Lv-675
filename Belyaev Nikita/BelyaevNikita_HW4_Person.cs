using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Person
    {
        private string name;
        private DateTime birthYear;

        public string Name
        {
            get => name;
        }

        public DateTime BirthYear
        {
            get => birthYear;
        }

        public Person()
        {

        }

        public Person(string name, DateTime birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }

        public int Age()
        {
            return DateTime.Today.Year - this.birthYear.Year;
        }

        public void Input()
        {
            Console.Write("Type name of person : ");
            var name = Console.ReadLine();
            Console.Write("Type date of birthday of person (dd/mm/yyyy) : ");
            var birthYear = DateTime.Parse(Console.ReadLine());
            this.name = name;
            this.birthYear = birthYear;
        }

        public void ChangeName()
        {
            if (Age() < 16)
            {
                this.name = "Very Young";
            }
        }

        public override string ToString()
        {
            return $"Name : {this.name} | Age : {Age()} years";
        }


        public void Output()
        {
            Console.WriteLine(ToString());
        }

        public static bool operator ==(Person firstPerson, Person secondPerson)
        {
            return (firstPerson.name == secondPerson.name);
        }

        public static bool operator !=(Person firstPerson, Person secondPerson)
        {
            return !(firstPerson.name == secondPerson.name);
        }
    }
}