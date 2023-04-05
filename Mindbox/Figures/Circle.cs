using System;
using Mindbox.Interfaces;

namespace Mindbox.Figures
{
    public class Circle : IBaseFigure
    {
        private double _radius;
        public double Radius { get => _radius; init => _radius = value; }
        public Circle(double radius)
        {
            if (_radius <= 0)
            {
                throw new Exception("Circle's radius must not be zero or negative");
            }

            _radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}