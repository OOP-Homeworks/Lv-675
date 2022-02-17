using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask5
{
    internal class Builder : IDeveloper, IComparable<IDeveloper>
    {
        private string tool;

        

        public Builder(string tool)
        {
            this.tool = tool;
        }

        public string Tool
        {
            get { return tool; }
            set { tool = value; }

        }

        public void Create()
        {
            Console.WriteLine("Create builder with tool: " + Tool);
        }

        public void Destroy()
        {
            Console.WriteLine("Destroy builder with tool: " + Tool);
        }



        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return String.Compare(this.Tool, other.Tool);
        }
    }
}
