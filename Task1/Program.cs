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
        }
    }
}
