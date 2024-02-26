﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle_objects
{
    internal class Circle
    {
        private double radius { get; set; }

        public Circle(double radius)
        {
            this.radius = radius;
        }
        double diameter;
        double area;
        double circumference;
        public double CalculateDiameter()
        {
            diameter = radius * 2;
            return diameter;
        }

        public double CalculateCircumference()
        {
            circumference = radius * 3.14;
            return circumference;
        }

        public double CalculateArea()
        {
            area = (radius * radius) * 3.14;
            return area;
        }

        public void Grow()
        {
            diameter *= 2;
            circumference *= 2;
            area *= 2;
            radius *= 2;
        }

        public double GetRadius()
        {
            return radius;
        }
    }
}
