using System;
using Library_Homework_1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApp_Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Enter a");
            while(!Double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Input is not valid");
                Console.WriteLine("Enter a");
            }
            Console.WriteLine("Enter b");
            while (!Double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Input is not valid");
                Console.WriteLine("Enter b");
            }
            Console.WriteLine("Enter c");
            while (!Double.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("Input is not valid");
                Console.WriteLine("Enter c");
            }

            Console.WriteLine();

            Decomposer decomposer = new Decomposer(a, b, c);
            decomposer.Resolve();

            /*if (Decomposer.CountDiscriminant(a, b, c) > 0)
            {
                Console.WriteLine($"x1 = {Decomposer.FindX1(Decomposer.CountDiscriminant(a, b, c), a, b)}, x2 = {Decomposer.FindX2(Decomposer.CountDiscriminant(a, b, c), a, b)}");
                Console.WriteLine(Decomposer.Decompose(a, Decomposer.FindX1(Decomposer.CountDiscriminant(a, b, c), a, b), Decomposer.FindX2(Decomposer.CountDiscriminant(a, b, c), a, b)));
                
            }
            else if(Decomposer.CountDiscriminant(a, b, c) == 0)
            {
                Console.WriteLine($"x1 = x2 = {Decomposer.FindSingleX(a, b)}");
                Console.WriteLine(Decomposer.Decompose(a, Decomposer.FindSingleX(a, b), Decomposer.FindSingleX(a, b)));
            }
            else
            {
                Console.WriteLine("The equation has no roots");
            }*/

            Console.ReadLine();
        }
    }
}
