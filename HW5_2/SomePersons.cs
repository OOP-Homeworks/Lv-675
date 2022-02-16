using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_2
{
    internal class SomePersons
    {
        private string name;
        private uint id;

        public SomePersons(string name, uint id)
        {
            this.name = name;
            this.id = id;
        }

        public static SomePersons Input(int i)
        {
            Console.WriteLine("Enter the name of person: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the id of person: ");
            uint id = Convert.ToUInt32(Console.ReadLine());
            SomePersons somePersons = new SomePersons(name, id);
            return somePersons;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public uint Id 
        {
            get { return id; }
            set { id = value; }
        }
    }
}
