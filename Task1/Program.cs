using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] inputs = Console.ReadLine().Split(' ').Select(x => byte.Parse(x)).ToArray();
            byte N = inputs[0];
            byte A = inputs[1];
            byte B = inputs[2];
            
            Console.WriteLine(C((byte) (N + 1), A) * C((byte) (N + 1), B));
        }

        static decimal C(byte n, byte m)
        {
            var a1 = getFactorialMultipliersWithStop((byte) (n + m - 1), (byte) Math.Max(n - 1, m));
            var a2 = getFactorialMultipliers((byte) Math.Min(n - 1, m));
            var t = Simplify(a1, a2);
            var r1 = Multiply(t.Item1);
            var r2 = Multiply(t.Item2);
            return r1 / r2;
        }

        static byte[] getFactorialMultipliers(byte n)
        {
            return getFactorialMultipliersWithStop(n, 1);
        }

        static byte[] getFactorialMultipliersWithStop(byte n, byte stop)
        {
            if (n < 2) return new byte[] {1};

            byte[] temp = new byte[n-stop];
            for (byte i = n; i > stop; i--)
            {
                temp[n-i] = i;
            }
            return temp;
        }

        static decimal Multiply(byte[] ms)
        {
            decimal res = 1;
            foreach (var m in ms)
            {
                res *= m;
            }
            return res;
        }

        static Tuple<byte[], byte[]> Simplify(byte[] greater, byte[] less)
        {
            List<byte> _g = greater.ToList();
            List<byte> _l = less.ToList();

            for (int i = 0; i < _g.Count; i++)
            {
                for (int j = 0; j < _l.Count; j++)
                {
                    if (_g[i] % _l[j] == 0)
                    {
                        _g[i] /= _l[j];
                        _l.RemoveAt(j);
                        j--;
                    }
                }
            }

            return new Tuple<byte[], byte[]>(_g.ToArray(), _l.ToArray());
        }
    }

    class Tuple<A1, A2>
    {
        public A1 Item1;
        public A2 Item2;

        public Tuple(A1 item1, A2 item2)
        {
            Item1 = item1;
            Item2 = item2;
        }
    }
}
