using System;
using System.Collections.Generic;
using System.Text;

namespace Gural_HW5
{
    interface IDeveloper
    {
        string Tool { get; set; }
        void Create();
        void Destroy();
    }
}
