using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryTasks
{
    public class Vector
    {
        public double X;
        public double Y;
    }
    public class Geometry
    {
        //public static double getLength(Vector vector)
        //{
        //    return Math.Sqrt((vector.X * vector.X) + (vector.Y * vector.Y));
        //}

        public static double getLength(Segment segment)
        {
            return Math.Sqrt(Math.Pow(segment.End.X - segment.Begin.X, 2) + Math.Pow(segment.End.Y - segment.Begin.Y, 2));
        }

        public static Vector Add(Vector vector1, Vector vector2)
        {
            var vector3 = new Vector { X = vector1.X + vector2.X, Y = vector1.Y + vector2.Y };
            return vector3;
        }

        public static bool IsVectorInSegment(Vector vector, Segment segment)
        {
            {
                if (vector.X == segment.Begin.X && vector.X == segment.End.X && vector.Y == segment.Begin.Y && vector.Y == segment.End.Y) return true;
                else
                { return ((vector.X - segment.Begin.X) * (segment.End.Y - segment.Begin.Y) == (segment.End.X - segment.Begin.X) * (vector.Y - segment.Begin.Y)) && (vector.X >= segment.Begin.X && vector.X <= segment.End.X && vector.Y >= segment.Begin.Y && vector.Y <= segment.End.Y); }
            }


            double X = vector.X,
                   Y = vector.Y,
                   X1 = segment.Begin.X,
                   X2 = segment.End.X,
                   Y1 = segment.Begin.Y,
                   Y2 = segment.End.Y;
            if (((X - X1) * (Y2 - Y1) - (X2 - X1) * (Y - Y1)) == 0) return true;
            else return false;
        }
    }
    public class Segment
    {
        public Vector Begin;
        public Vector End;
    }

    static void Main(string[] args)
    {
        Vector v = new Vector()
        {
            X = 4,
            Y = 6
        };
        Segment s = new Segment()
        {
            Begin = new Vector()
            {
                X = 2,
                Y = 5
            },
            End = new Vector()
            {
                X = 5,
                Y = 6
            }
        };
        Console.WriteLine(Geometry.IsVectorInSegment(v, s) ? "In segment" : "Out segment");

    }
}
