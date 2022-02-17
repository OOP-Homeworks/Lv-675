using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_
{
    internal class Builder : IDeveloper, IComparable<IDeveloper>
    {
        string tool;
        public Builder(string tool)
        {
            this.tool = tool;
        }

        public void Create()
        {
            Console.WriteLine("Create builder " + tool);
        }

        public void Destroy()
        {
            Console.WriteLine("Destroy builder " + tool);
        }

        public string Tool
        {
            get { return tool; }
            set { tool = value; }
        }
        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return String.Compare(this.Tool, other.Tool);
        }
    }
}
