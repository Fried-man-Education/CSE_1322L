using System;

namespace Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            GeometricObject.Octagon Shape = new GeometricObject.Octagon(8);
            Console.WriteLine("Perimeter: " + Math.Round(8d * Shape.side, 2));
            Console.WriteLine("Area: " + Math.Round((2 + 4 / Math.Sqrt(2)) * Shape.side * Shape.side, 2));
            GeometricObject.Octagon newShape = Shape.Clone();
            Console.WriteLine("Objects are same: " + Shape.Compare(newShape));
        }
    }

    public abstract class GeometricObject
    {
        interface IComparable
        {
            bool Compare(Octagon otherObject);
        }
        interface ICloneable
        {
            Octagon Clone();
        }
        public class Octagon : IComparable, ICloneable
        {
            public int side;
            public Octagon (int n)
            {
                side = n;
            }
            public bool Compare(Octagon otherObject)
            {
                if (this.Equals(otherObject))
                {
                    return true;
                }
                return false;
            }
            public Octagon Clone ()
            {
                return this;
            }
        }
    }
}
