using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_69V
{
    public class Ellipse : Function
    {
        public double A;
        public double B;
        public double X;
        public double Y;

        public Ellipse(double a, double b, double x,double y)
        {
            A = a;
            B = b;
            X = x;
            Y = y;
        }

        public override double Ellipce()
        {
           //return B * Math.Sqrt(1 - Math.Pow(X, 2) / Math.Pow(A, 2));
           return Math.Pow(X,2)/Math.Pow(A,2)+Math.Pow(Y,2)/Math.Pow(B,2);
        }

        public override double Hyper()
        {
            return 0;
        }

        public override string Print()
        {
            return $"Эллипс равен: {Ellipce():F2}";


        }
    }
}
