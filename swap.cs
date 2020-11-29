using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first value:");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second value :");
            int second = Convert.ToInt32(Console.ReadLine());

            first = first + second;
            second = first - second;
            first = first - second;
            Console.WriteLine("the swap of first "+ first);
            Console.WriteLine("the swap of second " + second);
        }
    }
}
