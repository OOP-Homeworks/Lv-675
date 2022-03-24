using System;
using System.Collections.Generic;
using System.Linq;

namespace justCoding
{
    public delegate void MyDel(int m);

    public class Student
    {
        public static List<int> marks = new List<int>();

        public string Name

        {
            get { return "Ivan"; }
        }

        public event MyDel MarkChange;


        public void AddMark(int grade)
        {
            marks.Add(grade);
            MarkChange.Invoke(grade);
        }

    }

    class Parent : Student
    {
        public void OnMarkChange(int grade)
        {
            Console.WriteLine($"{Name} have new grade : {grade} .");
        }
    }

    class Accountancy : Student
    {
        public void PayingFellowship(int grade) 
        {
            if (marks.Average() < 10)
            {
                Console.WriteLine($"Average grades = {marks.Average()}");
                Console.WriteLine($"{Name} dont have enough grades for stipendia.");
            }
            else
            {
                Console.WriteLine($"Average grades = {marks.Average()}");
                Console.WriteLine($"{Name} have enough grades for stipendia.");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Student child = new Student();
            Parent parent = new Parent();
            Accountancy acc = new Accountancy();

            MyDel mydel1 = parent.OnMarkChange;
            MyDel mydel2 = acc.PayingFellowship;

            child.MarkChange += mydel1;
            child.MarkChange += mydel2;

            child.AddMark(5);
            child.AddMark(7);
            child.AddMark(20);
            child.AddMark(30);
        }
    }
}
