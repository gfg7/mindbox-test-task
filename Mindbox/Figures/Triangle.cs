using System;
using System.Linq;
using Mindbox.Interfaces;

namespace Mindbox.Figures
{
    public class Triangle : ITriangle
    {
        private double[] _sides;
        public double[] Sides { get => _sides; init => _sides = value; }

        public Triangle(double a, double b, double c) : this(new double[] { a, b, c }) { }

        public Triangle(double[] sides)
        {
            if (sides.Count() < 3)
            {
                throw new Exception("Triangle must have 3 sides");
            }

            TriangleInitialization(sides);
        }

        private void TriangleInitialization(double[] sides)
        {
            if (sides.Any(x => x <= 0))
            {
                throw new Exception("Triangle must have none zero sides");
            }

            _sides = sides;
        }

        public double GetArea()
        {
            var hP = _sides.Sum()/2;
            double temp = 0;

            foreach (var i in _sides)
            {
                temp*= hP - i;
            }

            return Math.Sqrt(hP*temp);
        }

        public bool IsSquare()
        {
            return _sides.Any(x => Math.Sqrt(_sides.TakeWhile(y => y != x).Sum(z => Math.Pow(z, 2))) == x);
        }
    }
}