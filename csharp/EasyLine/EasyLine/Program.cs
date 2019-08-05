using System;
using System.Numerics;

namespace EasyLineNS
{
    class EasyLines
    {

        public static BigInteger EasyLine(int n)
        {
            BigInteger [] row = new BigInteger[n + 1];
            row[0] = 1;
            row[1] = 1;

            BigInteger x;
            for (int i = 0; i < (int)(n/2);++i)
            {
                x = row[i] * (n - i) / (i + 1);
                row[i + 1] = x;
                row[n - i - 1] = x;
            }
            BigInteger result = 0;
            foreach(BigInteger number in row)
            {
                result += number * number;
            }

            return result + 1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(EasyLine(13));
        }
    }
}
