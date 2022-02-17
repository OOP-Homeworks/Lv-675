using System;
using System.Collections.Generic;
using System.Text;

namespace Gural_HW5
{
    class Programmer : IDeveloper, IComparable
    {
        string language;
        public string Tool
        {
            get
            {
                return this.language;
            }
            set
            {
                this.language = value;
            }
        }

        public void Create()
        {
            Console.WriteLine("Enter programer language");
            string x = Console.ReadLine();
            this.language = x;
        }
        public void Destroy()
        {
            Console.WriteLine("Deleting info of programer");
            this.language = null;
        }
        public int CompareTo(object? o)
        {
            if (o is IDeveloper dev)
            {
                return Tool.CompareTo(dev.Tool);
            }
            else
            {
                throw new ArgumentException("Invalid object");
            }
        }

        public override string ToString()
        {
            return this.language;
        }
    }
}

