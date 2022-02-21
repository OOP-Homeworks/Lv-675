using System;

namespace HomeWork5
{
    class Builder : IDeveloper, IComparable<IDeveloper>
    {
        private string tool;

        public Builder(string tool)
        {
            this.tool = tool;
        }

        public string Tool
        {
            get => tool;
            set => tool = value;
        }

        public int CompareTo(IDeveloper other) => string.Compare(Tool, other.Tool);

        public void Create()
        {
            Console.WriteLine($"Builder was created with tool : {Tool} .");
        }

        public void Destroy()
        {
            Console.WriteLine($"Builder with tool '{Tool}' was destroyed.");
        }
    }
}
