using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the A variable :");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the B variable :");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the temp variable :");
            int temp = Convert.ToInt32(Console.ReadLine());

            temp = A;
            A = B;
            B = temp;
            Console.WriteLine("the swap of A " +A);
            Console.WriteLine("the swap of B " +B);
        }
    }
}
