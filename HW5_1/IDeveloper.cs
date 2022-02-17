using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_
{
    internal interface IDeveloper:IComparable<IDeveloper>
    {
        void Create();
        void Destroy();

        string Tool
        {
            get; set;
        }
    }
}
