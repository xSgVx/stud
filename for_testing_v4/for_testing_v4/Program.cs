﻿using System;

namespace use_override
{
    class Program
    {

        public class Triangle
        {
            public Point A;
            public Point B;
            public Point C;
            public override string ToString()
            {
                return string.Format("({0} {1}) ({2} {3}) ({4} {5})", A.X, A.Y, B.X, B.Y, C.X, C.Y);
            }

        }
        public class Point
        {
            public double X;
            public double Y;
            public override string ToString()
            {
                return string.Format("{0} {1}", X, Y);
            }
        }

        static void Main()
        {
            var triangle = new Triangle
            {
                A = new Point { X = 0, Y = 0 },
                B = new Point { X = 1, Y = 2 },
                C = new Point { X = 3, Y = 2 }
            };
            Console.WriteLine(triangle.ToString());
        }


    }
}
