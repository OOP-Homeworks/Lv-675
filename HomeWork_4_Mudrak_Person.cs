using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Person
    {
        private string _name;
        private DateTime _birthYear;

        public string Name
        {
            get { return _name; }
        }

        public DateTime BirthYear
        {
            get { return _birthYear; }
        }

        public Person() { _name = "Петрович"; _birthYear = new DateTime(); }
        public Person(string n, string birthYear)
        { _name = n; _birthYear = Convert.ToDateTime(birthYear); }

        public void Age()
        {
            int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int dob = int.Parse(_birthYear.ToString("yyyyMMdd"));
            int age = (now - dob) / 10000;
            Console.WriteLine($"Вік людини {age}");
        }

        public static Person Input(int i)
        {
            Console.WriteLine($"Введіть ім'я людини №{i + 1}");
            string name = Console.ReadLine();
            Console.WriteLine("Введіть дату народження");
            string age = Console.ReadLine();
            Person human = new Person(name, age);
            return human;
        }

        public void ChangeName()
        {
            int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int dob = int.Parse(_birthYear.ToString("yyyyMMdd"));
            int age = (now - dob) / 10000;
            string name = "Very Young"; ;
            if (age < 16)
            {
                _name = name;
                Console.WriteLine($"Ім'я було змінено на {name}");
            }
        }

        public static bool operator ==(Person first, Person second)
        {
            return (first._name == second._name);
        }

        public static bool operator !=(Person first, Person second)
        {
            return !(first._name == second._name);
        }

        public void Output()
        {
            Console.WriteLine($"Ім'я людини {_name.ToString()}, року народження {_birthYear.ToString()}");
        }
    }
}
