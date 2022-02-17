using System;
using System.Collections.Generic;
using System.Text;

namespace Gural_HW5
{
    class Builder : IDeveloper, IComparable
    {
        string tool;
        public string Tool
        {
            get
            {
                return this.tool;
            }
            set
            {
                this.tool = value;
            }
        }

        public void Create()
        {
            Console.WriteLine("Enter builder tool");
            string x = Console.ReadLine();
            this.tool = x;
        }
        public void Destroy()
        {
            Console.WriteLine("Deleting info of builder");
            this.tool = null;
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
            return this.tool;
        }
    }
}
