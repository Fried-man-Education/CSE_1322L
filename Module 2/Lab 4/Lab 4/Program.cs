using System;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            GeometricObject.Octagon Shape = new GeometricObject.Octagon(8);
            GeometricObject.Octagon newShape = Shape.Clone();
            Console.WriteLine("Octagon 1’s side length: " + Shape.side + " and area is: " + Math.Round((2 + 4 / Math.Sqrt(2)) * Shape.side * Shape.side, 2));
            Console.WriteLine("Octagon 2’s side length: " + newShape.side + " and area is: " + Math.Round((2 + 4 / Math.Sqrt(2)) * newShape.side * newShape.side, 2));
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
            public Octagon(int n)
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
            public Octagon Clone()
            {
                return this;
            }
        }
    }
}
