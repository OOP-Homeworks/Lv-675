using System;
using System.Collections.Generic;

namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDeveloper> developers = new List<IDeveloper>();
            developers.Add(new Programmer("C#"));
            developers.Add(new Programmer("Python"));
            developers.Add(new Programmer("Java"));
            developers.Add(new Programmer("JavaScript"));
            developers.Add(new Builder("Visual Studio"));
            developers.Add(new Builder("Pycharm"));
            developers.Add(new Builder("PphShtom"));
            developers.Add(new Builder("Postman"));
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
