using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_By_Erik_Frytskyi
{
    class Person
    {
        #region Private

        private string name;
        private DateTime birthYear;

        #endregion

        #region Constructor

        public Person() 
        {
            this.name = "Dahaka";
            this.birthYear = new DateTime(1998, 09, 15); 
        }

        public Person(string name, DateTime birthYear) 
        {
             this.name = name;
             this.birthYear = birthYear;
        }

        #endregion

        #region Property

        public string Name 
        {
            get => this.name;
            set => this.name = value;
        }

        public DateTime BirthYear 
        {
            get => this.birthYear;
            set => this.birthYear = value;
        }

        #endregion

        #region Methods
        public int Age() 
        {
            return DateTime.Today.Year - this.birthYear.Year;
        }

        public void Input() 
        {
            Console.Write("Input Name: ");
            this.name = Console.ReadLine();

            Console.Write("Input Year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Month: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Day: ");
            int day = Convert.ToInt32(Console.ReadLine());

            this.birthYear = new DateTime(year, month, day);
        }

        public void ChangeName() 
        {
            Console.Write("Input new name: ");
            this.name = Console.ReadLine();
        }

        public override string ToString() 
        {
            return $"Name : {this.name}, Birthday: {this.birthYear.ToShortDateString()}";
        }

        public void Output() 
        {
            Console.WriteLine(this.ToString());
        }
        #endregion

        #region Operator
        public static bool operator == (Person first, Person second)
        {
            return first.Name == second.Name;
        }
        public static bool operator !=(Person first, Person second)
        {
            return first.Name != second.Name;
        }
        #endregion

    }


}
