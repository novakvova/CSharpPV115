using DocumentFormat.OpenXml.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Extention_Net
{
    public class MyPoint : IComparable<MyPoint>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public MyPoint(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString() => $"[{this.X}, {Y}]";

        public static MyPoint operator+(MyPoint p1, MyPoint p2)
        {
            return new MyPoint(p1.X+p2.X, p1.Y+p2.Y);
        }
        public static MyPoint operator-(MyPoint p1, MyPoint p2)
        {
            return new MyPoint(p1.X - p2.X, p1.Y - p2.Y);
        }

        public static MyPoint operator++(MyPoint p1)
        {
            return new MyPoint(p1.X+1, p1.Y+1);
        }

        public override bool Equals(object? obj) => obj.ToString() == this.ToString();
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public int CompareTo(MyPoint? other)
        {
            if (this.X > other.X && this.Y > other.Y)
                return 1;
            if (this.X < other.X && this.Y < other.Y)
                return -1;
            else
                return 0;
        }

        public static bool operator <(MyPoint p1, MyPoint p2) => p1.CompareTo(p2) < 0;
        public static bool operator >(MyPoint p1, MyPoint p2) => p1.CompareTo(p2) > 0;
        public static bool operator >=(MyPoint p1, MyPoint p2) => p1.CompareTo(p2) >= 0;
        public static bool operator <=(MyPoint p1, MyPoint p2) => p1.CompareTo(p2) <= 0;

        public static bool operator==(MyPoint p1, MyPoint p2) => p1.Equals(p2);
        public static bool operator!=(MyPoint p1, MyPoint p2) => !p1.Equals(p2);

    }
}
