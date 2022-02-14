using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salnikov_HW4
{
    class Person

    {
        private int birthYear;
        private string name;

       

        public string Name
        {
            get { return name; }
                    
        }
        public int BirthYear
        {
            get { return birthYear;}
        }
       
        public Person() { }
        public Person(string name, int birthYear) 
        {
           this.name = name;
           this.birthYear = birthYear;
        }

        public static Person Input(int counter)
        {
            Console.Write($"Enter the name {counter + 1}-person: ");
            string name = Console.ReadLine();
            Console.Write("Enter birth year: ");
            int birthYear = int.Parse(Console.ReadLine());
            Person thePerson = new Person(name, birthYear);
            return thePerson;

        }

        public int Age(int birthYear) 
        {
            int age = (Convert.ToInt32(DateTime.Now.ToString("yyyy")) - birthYear);
            return age;
        }

        public void ChangeName() 
        {
            string changeName = "Very Young";

            Person person = new Person();
            if (person.Age(birthYear) < 16)
            {
                name = changeName;
                Console.WriteLine(name);
            }
            
        }

        public void Output() 
        {
            Console.WriteLine($"Name:  {name.ToString()}; Age: {Age(birthYear).ToString()}");
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
            return "Name: " + name + "   Age:  " + person.Age(birthYear);
        }

    }
}
