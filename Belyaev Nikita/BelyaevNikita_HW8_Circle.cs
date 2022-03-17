using System;

namespace HomeWork8
{
    class Circle : Shape
    {
        private int radius;
        public int Radius 
        {
            get => radius;
            set => radius = value;
        }
        public Circle(string name, int radius) : base(name)
        {
            this.radius = radius;
        }
        public override double Area()
        {
            return radius * radius * Math.PI;
        }

        public override double Perimetr()
        {
            return 2 * Math.PI * radius;
        }
    }
}
