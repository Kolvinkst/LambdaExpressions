using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    internal class Program
    {
        static Random random => new Random();

        static double GetRandomDouble(int max) => max * random.NextDouble();

        static void PrintValue(double d) => Console.WriteLine($"The value is {d:0.0000}");
        static void Main(string[] args)
        {
            var value = Program.GetRandomDouble(100);
            Program.PrintValue(value);
            Console.WriteLine("Press any key to exit");
            char key = Console.ReadKey().KeyChar;
        }
    }
}
