using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Builder : IDeveloper, IComparable<IDeveloper>
    {
        string tool;
        public string Tool
        {
            get { return tool; }
            set { tool = value; }
        }
        public Builder(string tool)
        {
            this.tool = tool;
        }
        public void Create()
        {
            Console.WriteLine($"Builder {tool} created");
        }
        public void Destroy()
        {
            Console.WriteLine($"Builder {tool} destroyed");
        }
        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return String.Compare(this.Tool, other.Tool);
        }
        
    }
}
