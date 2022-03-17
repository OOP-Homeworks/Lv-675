using System;

namespace HomeWork8
{
    abstract class Shape : IComparable<Shape>
    {
        private string name;
        public string Name 
        { 
            get => name;
            set => name = value; 
        }

        public Shape(string name)
        {
            this.name = name;
        }

        public abstract double Area();
        public abstract double Perimetr();

        public override string ToString()
        {
            return $"Shape '{Name}' have Area = {Area()} and Perimetr {Perimetr()}";
        }

        public int CompareTo(Shape shape)
        {
            if (shape is null) throw new ArgumentException("Некорректное значение параметра");
            return Area().CompareTo(shape.Area());
        }
    }
}
