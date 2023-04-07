using System;
using Mindbox.Interfaces;
using Mindbox.Models.Figures.Exceptions;

namespace Mindbox.Models.Figures
{
    public class Circle : IBaseFigure
    {
        private double _radius;
        public double Radius { get => _radius; init => _radius = value; }
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new FigureCreationException("Circle's radius must not be zero or negative");
            }

            _radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}