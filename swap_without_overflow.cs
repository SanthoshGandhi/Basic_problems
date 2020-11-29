using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the A value :");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the B value :");
            int B = Convert.ToInt32(Console.ReadLine());

            A = A ^ B;
            B = A ^ B;
            A = A ^ B;
            Console.WriteLine(A);
            Console.WriteLine(B);
        }
    }
}
