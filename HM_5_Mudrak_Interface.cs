using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM5
{
    public interface IDeveloper : IComparable<IDeveloper>
    {
        string Tool { get; set; }
        public void Create()
        {
            Console.WriteLine("Person created");
        }
        public void Destroy()
        {
            Console.WriteLine("Person destroyed");
        }
    }
    public class Programmer : IDeveloper
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
        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return String.Compare(this.Tool, other.Tool);
        }
    }
    public class Builder : IDeveloper
    {
        private string tool;
        public string Tool
        {
            get { return tool; }
            set { tool = value; }
        }
        public Builder(string tool)
        {
            this.tool = tool;
        }

        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return String.Compare(this.Tool, other.Tool);
        }
    }
}
