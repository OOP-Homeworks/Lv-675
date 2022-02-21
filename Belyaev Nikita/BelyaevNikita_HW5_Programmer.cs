using System;

namespace HomeWork5
{
    class Programmer : IDeveloper, IComparable<IDeveloper>
    {
        private string language;

        public Programmer(string language)
        {
            this.language = language;
        }

        public string Tool
        {
            get => language;
            set => language = value;
        }

        public int CompareTo(IDeveloper other) => string.Compare(Tool, other.Tool);

        public void Create()
        {
            Console.WriteLine($"Programmer was created with language : {Tool} .");
        }

        public void Destroy()
        {
            Console.WriteLine($"Programmer with language {Tool} was destroyed.");
        }
    }
}
