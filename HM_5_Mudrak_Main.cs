using System;
using System.Collections.Generic;

namespace HM5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDeveloper> programmers = new();
            programmers.Add(new Programmer("Петрович"));
            programmers.Add(new Programmer("Андрійович"));
            for (int i = 0; i < programmers.Count; i++)
            {
                programmers[i].Create();
                programmers.Sort();
                Console.WriteLine($"{programmers[i].Tool} новий програмер у братстві" );
                
            }
            for (int j = 0; j < programmers.Count; j++)
            {
                programmers.RemoveAt(j);
                programmers[j].Destroy();
            }
            List<IDeveloper> builders = new();
            builders.Add(new Builder("Олегович"));
            builders.Add(new Builder("Іванович"));
            for (int i = 0; i < builders.Count; i++)
            {
                builders[i].Create();
                builders.Sort();
                Console.WriteLine($"{builders[i].Tool} новий білдер у братстві");
            }
            for (int j = 0; j < builders.Count; j++)
            {
                builders.RemoveAt(j);
                builders[j].Destroy();
            }
        }
    }
}
