using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeApp
{
    [System.Xml.Serialization.XmlInclude(typeof(Circle))]
    [System.Xml.Serialization.XmlInclude(typeof(Triangle))]
    [System.Xml.Serialization.XmlInclude(typeof(Quadilateral))]
    public abstract class Shape : IComparable
    {

        private static int count = 0;
 
        public Shape()
        {
            Interlocked.Increment(ref count);
        }

        public virtual int Count
        {
            get
            {
                return count;
            }
        }

        public int TotalCount
        {
            get
            {
                return count;
            }
        }


        public virtual string Name
        {
            get
            {
                return "Shape";
            }
        }

        public abstract double Perimeter
        {
            get;
        }

        public abstract double Area
        {
            get;
        }

        // Default Compare by Area
        public int CompareTo(object? obj)
        {
            if (obj == null)
            {
                return 1;
            }

            Shape s = (Shape)obj;
            
            return this.Area.CompareTo(s.Area);
        }

    }
}
