using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter :");
            long A = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(fibfast(A));
            Console.WriteLine();
            Console.WriteLine(fibDP(A));
            Console.WriteLine();
            Console.WriteLine(fibrec(A));
            
        }
        public static long fibfast(long n)
        {
            long a = 0;
            long b = 1;
            long c = 0;

            if (n <= 1)
            {
                return n;
            }
            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return b;
        }

        public static long fibDP(long n)
        {
            long[] myarray = new long[n + 1];
            myarray[0] = 0;
            myarray[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                myarray[i]=myarray[i-1]+myarray[i-2];
            }
            return myarray[n];
        }

        public static long fibrec(long n)
        {
            if (n <= 1)
            {
                return n; 
            }
            return fibrec(n - 1) + fibrec(n - 2);
        }
    }
}
