
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCD_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter");
            long a = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("enter");
            long b = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(euclidGCD(a,b));
            Console.WriteLine(euclidGCDsub(a,b));
            Console.WriteLine(naiveGCDImproved(a,b));
        }
        public static long euclidGCD(long a, long b)
        {
            if (b == 0)
                return a;
            return euclidGCD(b, a % b);
        }

        public static long euclidGCDsub(long a, long b)
        {
            if(a==0)
                return b;
                if(b==0)
                    return a;
                    if(a==b)
                        return a;
                    if (a > b)
                        return euclidGCDsub(a - b, b);
                    return euclidGCDsub(a, b - a);
        }

        public static long naiveGCDImproved(long a, long b)
        {
            long min = Math.Min(a, b);
            if (a % min == 0 && b % min == 0)
            {
                return min;
            }
            for (long i = min / 2; i >= 2; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    return i;
                }
               
            }
            return 1;
        }


    }
}
