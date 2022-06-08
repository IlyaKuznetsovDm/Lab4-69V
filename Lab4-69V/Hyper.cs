using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_69V
{
    internal class Hyperbola : Function

    {

        public double A;
        public double B;
        public double X;
        public double Y;

        public Hyperbola(double a, double b, double x, double y)
        {
            A = a;
            B = b;
            X = x;
            Y = y;
        }

        public override double Ellipce()
        {
            return 0;
        }

        public override double Hyper()
        {
            //return B* Math.Sqrt(Math.Pow(X, 2) / Math.Pow(A, 2) - 1);
            return Math.Pow(X, 2) / Math.Pow(A, 2) - Math.Pow(Y, 2) / Math.Pow(B, 2);
            
        }

        public override string Print()
        {
            return $"Гипербола равна: {Hyper():F2}";
        }
    }
}
