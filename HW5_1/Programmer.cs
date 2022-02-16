using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_
{
    internal class Programmer : IDeveloper, IComparable<IDeveloper>
    {
        string language;
        public Programmer(string language)
        {
            this.language = language;
        }
        public string Tool
        {
            get { return language; }
            set { language = value; }
        }
        public void Create()
        {
            Console.WriteLine("Create programmer " + language);
        }

        public void Destroy()
        {
            Console.WriteLine("Destroy programmer " + language);
        }
        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return String.Compare(this.Tool, other.Tool);
        }
    }
}
