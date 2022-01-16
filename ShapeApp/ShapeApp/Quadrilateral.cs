using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeApp
{

    public class Quadilateral : Shape
    {
        private double width;
        private double length;
        private string name = "Quadilateral";
        public static int quadilateralCount = 0;

        public Quadilateral()
        {
            Interlocked.Increment(ref quadilateralCount);
        }

        public Quadilateral(double Width, double Length)
        {
            this.width = Width;
            this.length = Length;

            if (width == length)
            {
                name = "Square";
            }
            else
            {
                name = "Rectangle";
            }

            Interlocked.Increment(ref quadilateralCount);
        }

        public override int Count
        {
            get
            {
                return quadilateralCount;
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
                return (width + length) * 2.0 ;
            }
        }

        public override double Area
        {
            get
            {
                return width * length;
            }
        }
    }
}
