﻿using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace for_tests1
{
    class Program
    {
        public class Vector
        {
            public double X;
            public double Y;
            public double Length { get { return Math.Sqrt(X * X + Y * Y); } }
            public Vector(int x, int y)
            {
                X = x;
                Y = y;
            }

            public override string ToString()
            {
                return string.Format("({0}, {1}) with length: {2}", X, Y, Length);
            }

        }
        public static void Checker()
        {
            Vector vector = new Vector(3, 4);
            Console.WriteLine(vector.ToString());

            vector.X = 0;
            vector.Y = -1;
            Console.WriteLine(vector.ToString());

            vector = new Vector(9, 40);
            Console.WriteLine(vector.ToString());

            Console.WriteLine(new Vector(0, 0).ToString());
        }

        static void Main(string[] args)
        {
            Checker();
        }
    }
}
