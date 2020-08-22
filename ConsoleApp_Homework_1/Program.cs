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

            Console.ReadLine();
        }
    }
}
