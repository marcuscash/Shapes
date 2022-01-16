using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeApp
{

    public class Circle : Shape
    {
        private string name = "Circle";
        private double radius;
        private const double PI = 3.14;
        public static int circleCount = 0;

        public Circle(double radius)
        {
            this.radius = radius;
            Interlocked.Increment(ref circleCount);
        }

        public override int Count
        {
            get
            {
                return circleCount;
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
                return (2.0 * radius * PI); 
            }
        }

        public override double Area
        {
            get
            {
                return PI * radius * radius;
            }
        }
    }
}
