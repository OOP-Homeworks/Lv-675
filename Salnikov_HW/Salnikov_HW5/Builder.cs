using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salnikov_HW5_1
{
    class Builder : IDeveloper, IComparable<IDeveloper>
    {
        public Builder(string tool)
        {
            this.tool = tool;
        }
        private string tool;
        public string Tool
        {
            get { return tool; }
            set { tool = value; }
        }

        public void Create()
        {
            Console.WriteLine($"\nNew builder with {Tool} created ");
        }

        public void Destroy()
        {
            Console.WriteLine($"\nThe builder with {Tool} destroyed ");
        }

        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return String.Compare(this.Tool, other.Tool);
        }

    }
}
