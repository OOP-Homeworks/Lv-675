using System;

namespace HomeWork5
{
    interface IDeveloper : IComparable<IDeveloper>
    {
        string Tool { get; set; }

        public void Create();
        public void Destroy();
    }
}
