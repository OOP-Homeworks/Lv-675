using System;

namespace HomeWork8
{
    class Square : Shape
    {
        private int sideLength;
        public int SideLength
        {
            get => sideLength;
            set => sideLength = value;
        }
        public Square(string name, int length) : base(name)
        {
            sideLength = length;
        }
        public override double Area()
        {
            return sideLength * sideLength;
        }

        public override double Perimetr()
        {
            return sideLength * 4;
        }
    }
}
