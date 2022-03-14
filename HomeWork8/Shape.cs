using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    public abstract class Shape : IComparable
    {
        private string name;
        public string Name { get { return name; } }

        public Shape (string name)
        {
            this.name = name;
        }

        public abstract double Area(double x);
        public abstract double Perimeter(double x);
        public abstract int CompareTo(object obj);

        //public virtual int CompareTo(object obj1)
        //{
        //    Shape p1 = obj1 as Shape;
        //    if (p1 == null)
        //        throw new ArgumentException("Object is not a Person");
        //    else
        //        return this.Name.ToLower().CompareTo(p1.Name.ToLower());
        //}

    }
}
