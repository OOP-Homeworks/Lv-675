using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salnikov_HW5_1
{
    class Programmer : IDeveloper, IComparable<IDeveloper>
    {
        public Programmer(string language)
        {
            this.language = language;
        }
        private string language;

        public string Tool
        {
            get { return language; }
            set { language = value; }
        }

        public void Create()
        {
            Console.WriteLine("\nA new programmer has been created who is " +
                "proficient in the programming language " + Tool);
        }

        public void Destroy()
        {
            Console.WriteLine("\nThe " + Tool + " programmer is removed ");
        }

        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return String.Compare(this.Tool, other.Tool);
        }
    }
}
