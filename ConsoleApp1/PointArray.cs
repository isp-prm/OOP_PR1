using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PointArray
    {
        MyPoint[] points;
        int size;

        public PointArray()
        {
            this.points = Array.Empty<MyPoint>();
            this.size = 0;
        }

        public PointArray(int size)
        {
            this.size = size;
            this.points = new MyPoint[size];
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                points[i] = new MyPoint(rnd.NextDouble()*100.0, rnd.NextDouble()*100.0);
            }
        }  

        public PointArray(MyPoint[] points, int size)
        {
            this.points = points;
            this.size = size;
        }

        public MyPoint this[int index]
        {
            get
            {
                if (index < this.size)
                {
                    return this.points[index];
                }
                else
                {
                    throw new ArgumentException("Индекс не существует");
                }
            }
            set
            {
                if (index < this.size)
                {
                    this.points[index].X = value.X;
                    this.points[index].Y = value.Y;
                }
                else
                {
                    throw new ArgumentException("Индекс не существует");
                }
            }
        }

        public int Lenght { get => this.size; }

        public MyPoint Min()
        {
            if (this.size > 0)
            {
                MyPoint min = points[0];
                for (int i = 1; i < this.size; i++)
                {
                    if (points[i].Length() < min.Length())
                    {
                        min = points[i];
                    }
                }
                return min;
            }
            return new MyPoint(0, 0);
        }
    }
}
