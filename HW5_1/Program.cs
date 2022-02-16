using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IDeveloper> developers = new List<IDeveloper>();
            developers.Add(new Programmer("Unreal engine 4"));
            developers.Add(new Programmer("Unity"));
            developers.Add(new Programmer("Unreal engine 5"));
            developers.Add(new Builder("Epic Games Launcher"));
            developers.Add(new Builder("Unity hub"));
            developers.Add(new Builder("Epic Games Launcher"));
            foreach (IDeveloper develop in developers)
            {
                develop.Create();
                develop.Destroy();
            }
            developers.Sort();
            foreach (IDeveloper develop in developers)
            {
                develop.Create();
                develop.Destroy();
            }
        }
    }
}
