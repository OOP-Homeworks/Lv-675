using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5_2
{
    internal class Persons
    {
        private uint id;
        public uint Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Persons(uint id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public static Persons Input()
        {
            Console.Write("Enter person Id: ");
            uint id = Convert.ToUInt32(Console.ReadLine());
            Console.Write("Enter person name: ");
            string name = Console.ReadLine();
            Persons persons = new Persons(id, name);
            Console.WriteLine($"Person Id {id}, name {name} created.");
            return persons;
        }
    }
}
