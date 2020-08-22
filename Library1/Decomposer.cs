using System;

namespace Library_Homework_1
{
    public class Decomposer
    {
        private double a, b, c;
        private double discriminant;
        private double[] roots;

        public Decomposer(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            roots = new double[2];
        }

        private void CountDiscriminant()
        {
            discriminant = b * b - 4 * a * c;
        }

        private bool HasRealRoots()
        {
            return discriminant >= 0;
        }

        private void FindRoots()
        {
            roots[0] = (-1 * b + Math.Sqrt(discriminant)) / (2 * a);
            roots[1] = (-1 * b - Math.Sqrt(discriminant)) / (2 * a);
        }

        private void PrintRoots()
        {
            Console.WriteLine($"x1={roots[0]}, x2={roots[1]}");
        }

        private void PrintMessage()
        {
            Console.WriteLine("No roots");
        }

        private void Decompose()
        {
            string result = $"{a}(x";
            if(roots[0] < 0)
            {
                result += $"+{-1 * roots[0]})(x";
            }
            if (roots[0] > 0)
            {
                result += $"-{roots[0]})(x";
            }
            if (roots[1] < 0)
            {
                result += $"+{-1 * roots[1]})";
            }
            if (roots[1] > 0)
            {
                result += $"-{roots[1]})";
            }
            Console.WriteLine(result);
        }

        public void Resolve()
        {
            CountDiscriminant();
            if (HasRealRoots())
            {
                FindRoots();
                PrintRoots();
                Decompose();
            }
            else
            {
                PrintMessage();
            }
        }

    }
}
