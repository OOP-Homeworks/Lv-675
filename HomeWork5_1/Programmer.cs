using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask5
{
    internal class Programmer : IDeveloper, IComparable<IDeveloper>
    {
        private string language;
        public string Tool
        {
            get { return language; } 
            set { language = value; }
        }

        public Programmer(string language)
        {
            this.language = language;
        }

       

        public void Create()
        {
            Console.WriteLine("Create programmer with programming language: " + Tool); 
        }

        public void Destroy()
        {
            Console.WriteLine("Destroy programmer with programming language: " + Tool);
        }

        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return String.Compare(this.Tool, other.Tool);
        }
    }
}
