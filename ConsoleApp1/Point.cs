using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MyPoint
    {
        private double x;
        private double y;
        private static int size = 0;

        public MyPoint (double x, double y)
        {
            X = x;
            Y = y;
            size++;
        }

        public double X { get { return x; } set { x = value; } }
        public double Y { get { return y; } set { y = value; } }
        public static int Size => size;

        public override string ToString()
        {
            return $"Точка X: {this.X} Y: {this.Y} Len: {this.Length()    }";
        }

        public double Length()
        {
            return Math.Sqrt(X*X + Y*Y);
        }

        public static MyPoint operator --(MyPoint point)
        {
            return new MyPoint(point.X-1, point.Y-1);
        }

        public static MyPoint operator -(MyPoint point)
        {
            return new MyPoint(point.Y, point.X);
        }

        public static explicit operator int(MyPoint point)
        {
            return (int)point.X;
        }

        public static explicit operator double(MyPoint point)
        {
            return point.Y;
        }

        public static MyPoint operator -(MyPoint point, int i)
        {
            return new MyPoint(point.X - i, point.Y);
        }

        public static MyPoint operator -(int i, MyPoint point)
        {
            return new MyPoint(point.X, point.Y - i);
        }

        public static double operator -(MyPoint p1, MyPoint p2 )
        {
            return Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y));
        }
    }
}
