using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputs = File.ReadLines("INPUT.TXT").First().Split(' ').Select(int.Parse).ToArray();
            int N = inputs[0];
            int A = inputs[1];
            int B = inputs[2];

            Console.WriteLine(C(N+1, A)* C(N + 1, B));
        }

        static int C(int n, int m)
        {
            return Factorial(n + m - 1) / (Factorial(n - 1) * Factorial(m));
        }

        static int Factorial(int x)
        {
            return (x == 0) ? 1 : x * Factorial(x - 1);
        }
    }
}
