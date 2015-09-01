using System;

namespace MaxXOR
{
    class Program
    {
        static int maxXor(int l, int r)
        {
            int n = l ^ r;
            int i = 1;
            while (n > 2)
            {
                n /= 2;
                i <<= 1;
            }
            return Convert.ToInt32(Math.Pow(2, i + 1)) - 1;
        }

        static void Main(String[] args)
        {
            int res;
            int _l;
            _l = Convert.ToInt32(Console.ReadLine());

            int _r;
            _r = Convert.ToInt32(Console.ReadLine());

            res = maxXor(_l, _r);
            Console.WriteLine(res);
            Console.ReadLine();

        }
    }
}
