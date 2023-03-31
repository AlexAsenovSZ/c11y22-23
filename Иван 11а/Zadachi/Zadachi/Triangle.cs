using System;
using System.Collections.Generic;
using System.Text;

namespace Zadachi
{
    class Triangle
    {
        public double Area1(int a, int b, int c)
        {
            double P = (a + b + c) / 2.0;
            return Math.Sqrt(P * (P - a) * (P - b) * (P - c));
        }
        public double Area2(int a, int b, int angle)
        {
            return a * b * Math.Sin(angle) / 2;
        }
        public double Area3(int a, int h)
        {
            return (a * h) / 2.0;
        }
        public double Area4(int a, int b, int c, double r)
        {
            double p = (a + b + c) / 2;
            return p * r;
        }
    }
}
