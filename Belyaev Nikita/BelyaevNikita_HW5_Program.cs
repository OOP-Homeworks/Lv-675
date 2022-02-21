using System.Collections.Generic;

namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            var developers = new List<IDeveloper>();
            developers.Add(new Builder("Visual Studio"));
            developers.Add(new Builder("React"));
            developers.Add(new Builder("Angular"));
            developers.Add(new Programmer("C#"));
            developers.Add(new Programmer("HTML/CSS/JS"));
            developers.Add(new Programmer("SQL"));
            developers.Add(new Programmer("Python"));

            foreach (var item in developers)
            {
                item.Create();
            }

            developers.Sort();

            foreach (var item in developers)
            {
                item.Destroy();
            }
        }
    }
}
