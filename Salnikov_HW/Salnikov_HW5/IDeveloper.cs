using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salnikov_HW5_1
{
    interface IDeveloper : IComparable<IDeveloper>
    {
        public string Tool { get; set; }
        public void Create() { }
        public void Destroy() { }

    }
}
