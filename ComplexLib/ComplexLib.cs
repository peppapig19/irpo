using System;

namespace ComplexLib
{
    public class Complex
    {
        public readonly double a;
        public readonly double b;

        public Complex(double a = 0, double b = 0)
        {
            this.a = a;
            this.b = b;
        }

        public static Complex operator +(Complex z1, Complex z2)
        {
            return new Complex(z1.a + z2.a, z1.b + z2.b);
        }

        public static Complex operator -(Complex z1, Complex z2)
        {
            return new Complex(z1.a - z2.a, z1.b - z2.b);
        }

        public static Complex operator *(Complex z1, Complex z2)
        {
            double real = z1.a * z2.a - z1.b * z2.b;
            double imaginary = z1.b * z2.a + z1.a * z2.b;

            return new Complex(real, imaginary);
        }

        public static Complex operator /(Complex z1, Complex z2)
        {
            double real = (z1.a * z2.a + z1.b * z2.b) / (Math.Pow(z2.a, 2) + Math.Pow(z2.b, 2));
            double imaginary = (z1.b * z2.a - z1.a * z2.b) / (Math.Pow(z2.a, 2) + Math.Pow(z2.b, 2));

            return new Complex(real, imaginary);
        }

        public override string ToString()
        {
            if (b < 0) return $"{a} - {-b}i";
            else return $"{a} + {b}i";
        }
    };
}