using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Programmer : IDeveloper, IComparable<IDeveloper>
    {
        string language;
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
            Console.WriteLine($"Progammer {language} created");
        }
        public void Destroy()
        {
            Console.WriteLine($"Programmer {language} distroyed");
        }
        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return String.Compare(this.Tool, other.Tool);
        }
    }
}
