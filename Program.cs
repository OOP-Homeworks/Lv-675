using System;
using System.IO;
using System.Collections.Generic;


namespace HW11
{
    public delegate void MyDel(int m);

    public class Student
    {
        private string name;
        public string Name { get { return "Dima"; } }

        public event MyDel MarkChange;

        List<int> marks = new List<int>();

        public void AddMark(int m)
        {
            marks.Add(m);
            if (MarkChange != null)
                    MarkChange.Invoke(m);
        }      
    }

    public class Parent : Student
    {
        public void OnMarkChange(int est)
        {
            Console.WriteLine($"Your son {Name} has {est} mark");
        }
    }

    public class Accountancy : Student
    {
        public void PayingFellowship(int mark)
        {
            if (mark >= 10) 
                Console.WriteLine($"{Name} will have stepuhy\n");
            else
            Console.WriteLine($"{Name} will not have stepuhy((, please study hard\n");
        }
    }
    
    public class Program
    {
       public static void Main(string[] args)
        {
            Student student = new Student();
            Parent parent = new Parent();
            Accountancy accountancy = new Accountancy();

            MyDel father = parent.OnMarkChange;
            MyDel stepuha = accountancy.PayingFellowship;

            student.MarkChange += father;
            student.MarkChange += stepuha;

            student.AddMark(4);
            student.AddMark(10);
            student.AddMark(5);
            student.AddMark(4);
            student.AddMark(7);         

            Console.WriteLine();
        }
    }
}
