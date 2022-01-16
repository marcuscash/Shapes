using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeApp
{

    internal class Triangle : Shape
    {
        private double a;
        private double b;
        private double c;
        private double h;
        private string name = "Triangle";
        private const double PI = 3.14;
        public static int triangleCount = 0;

        public Triangle()
        {
            Interlocked.Increment(ref triangleCount);
        }

        public Triangle(double a, double triangleBase, double c, double height)
        {
            this.a = a;
            this.b = triangleBase;
            this.c = c;
            this.h = height;
            

            Interlocked.Increment(ref triangleCount);

            if (a == b && b == c)
            {
                name = "EquilateralTriangle";
            }
            else if (a == b || a == c || b == c)
            {
                name = "IsoscelesTriangle";
            }
            else
            {
                name = "ScaleneTriangle";
            }

        }
    

        public override int Count
        {
            get
            {
                return triangleCount;
            }
        }

        public override string Name
        {
            get
            {
                return name;
            }
        }

        public override double Perimeter
        {
            get
            {
                return a + b + c;
            }
        }

        public override double Area
        {
            get
            {
                return (h * b)/2.0;
            }
        }
    }
}
