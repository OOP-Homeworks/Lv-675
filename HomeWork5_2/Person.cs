using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5_2
{
    internal class Person
    {
        private string name;
        private uint id;

        public Person(string name, uint id)
        {
            this.name = name;
            this.ID = id;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public uint ID
        {
            get { return id; }
            set { id = value; }
        }

        public static Person Input(int i)
        {
            Console.Write($"Enter {i + 1} name of person: ");
            string name = Console.ReadLine();
            Console.Write($"Enter {i + 1} ID of person: ");
            uint ID = Convert.ToUInt32(Console.ReadLine());
            Person person = new Person(name, ID);
            return person;
        }
    }
}
