using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var persons = new Person[7];
            for (int i = 0; i < persons.Length; i++)
            {
                persons[i] = Person.Input(i);
            }

            Dictionary<uint, string> pairs = new Dictionary<uint, string>();
            pairs.Add(persons[0].ID, persons[0].Name);
            pairs.Add(persons[1].ID, persons[1].Name);
            pairs.Add(persons[2].ID, persons[2].Name);
            pairs.Add(persons[3].ID, persons[3].Name);
            pairs.Add(persons[4].ID, persons[4].Name);
            pairs.Add(persons[5].ID, persons[5].Name);
            pairs.Add(persons[6].ID, persons[6].Name);


            Console.WriteLine("Enter id of person: ");
            uint id = Convert.ToUInt32(Console.ReadLine());

            foreach (KeyValuePair<uint, string> kvp in pairs)
            {
                if (id == kvp.Key)
                {
                    Console.WriteLine("Name of user: " + kvp.Value);                  
                }

                if (id != kvp.Key)
                {
                     Console.WriteLine("Can't found user by entered id!");
                }
            }
        }
    }
}
