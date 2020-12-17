using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemsolution5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. printblocks.");
            printblocks1(5);
            Console.WriteLine("2. printblocks.");
            printblocks2(8);
            Console.WriteLine("3. printblocks.");
            printblocks3(8);
            Console.WriteLine("4. printblocks.");
            printblocks4(10);
            Console.WriteLine("5. printblocks.");
            printblocks5(10);
            Console.WriteLine("6. printblocks.");
            printblocks6(5);
            Console.WriteLine("7. printblocks.");
            printblocks7(5);
            Console.WriteLine("8. printblocks.");
            printblocks8(8);
            Console.WriteLine("9. printblocks.");
            printblocks9(8);
            Console.WriteLine("12. printblocks.");
            printblocks12(5);
            Console.WriteLine("13. printblocks.");
            printblocks13(5);
            Console.WriteLine("14. printblocks.");
            printblocks14(5);
            Console.WriteLine("15. printblocks.");
            printblocks15(05);
            Console.WriteLine("16. printblocks.");
            printblocks16(5);
            Console.WriteLine("17. printblocks.");
            printblocks17(4);
            Console.WriteLine("18. printblocks.");
            printblocks18(4);
            Console.WriteLine("19. printblocks.");
            printblocks19(4);
            Console.WriteLine("20. printblocks.");
            printblocks20(4);
            Console.WriteLine("21. printblocks.");
            printblocks21(10);
            Console.WriteLine("22. printblocks.");
            printblocks22(10);
            Console.WriteLine("23. printblocks .");
            printblocks23(10);
            Console.WriteLine("24. printblocks.");
            printblocks24(10);
            Console.WriteLine("25. printblocks.");
            printblocks25(10);
            Console.WriteLine("26. printblocks.");
            printblocks26(10);
            Console.WriteLine("27. printblocks.");
            printblocks27(8);
            Console.WriteLine("27. printblocks.");
            printblocks28(8);
           
        }
        public static void printblocks1(int rows)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write("# ");
                    
                }
                Console.WriteLine();
            }
        }
        public static void printblocks2(int rows)
        {
            for (int i = 1; i < rows; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    
                    Console.Write("# ");

                }
                Console.WriteLine();
            }
        }
        public static void printblocks3(int rows)
        {
            
            for (int i = 0; i <=rows; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }
        }
        public static void printblocks4(int rows)
        {
            for (int i = 1; i <= rows; i++)
            {
                for (int j = i; j <= rows; j++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }
        }
        public static void printblocks5(int rows)
        {
          
            for (int i = 1; i <= rows; i++)
            {
                for (int k = 1; k < i; k++)
                {                    
                    Console.Write(" ");
                }
                for (int j = i; j <= rows; j++)
                {
                    Console.Write("# ");
                }
                    Console.WriteLine();
            }
        }
        public static void printblocks6(int rows)
        {

            for (int i = 1; i <= rows; i++)
            {
                for (int k = 1; k <=(rows-i); k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
        public static void printblocks7(int rows)
        {
    
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                    
                }
                Console.WriteLine();
            }
        }
        public static void printblocks8(int rows)
        {
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
        public static void printblocks9(int rows)
        {
            for (int i = 1; i <= rows; i++)
            {
                for (int a = 0; a < (i); a++)
                {
                     Console.Write(" ");
                }
                for (int j = i; j <= rows; j++)
                {
                    Console.Write(j);
                }
                    Console.WriteLine();
            }
        }
        public static void printblocks12(int rows)
        {
          for(int i = rows; i >= 1; i--)
            {
                for (int k = 1; k <= (rows - i); k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("#");
                }
                for (int j = 2; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
        public static void printblocks13(int rows)
        {
            for (int i = 1; i <= rows; i++)
            {
                for (int k = 1; k <= (rows - i); k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("#");
                }
                for (int j = 2; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
        public static void printblocks14(int rows)
        {
            for (int i = 1; i <= rows; i++)
            {
                for (int k = 1; k <= (rows - i); k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("#");
                }
                for (int j = 2; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            for (int i = 4; i >= 1; i--)
            {
                for (int k = 1; k <= (rows - i); k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("#");
                }
                for (int j = 2; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
        public static void printblocks15(int rows)
        {
            int temp = 01;
            for (int i = 01; i <= rows; i++)
            {
                for (int j = 01; j <= i; j++)
                {
                    Console.Write(" "+temp);
                    temp++;
                }
                Console.WriteLine( );
            }
            Console.ReadLine();
        }
        public static void printblocks16(int rows)
        {
            for (int i = 0; i <= rows; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= rows; i++)
            {
                for (int j = i; j <= rows; j++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }
        }
        public static void printblocks17(int rows)
        {
            for (int i = 0; i <= rows; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("1 ");
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= rows; i++)
            {
                for (int j = i; j <= rows; j++)
                {
                    Console.Write("1 ");
                }
                Console.WriteLine();
            }
        }
        public static void printblocks18(int rows)
        {
            char ch = 'a';
            for (int i = 0; i <= rows; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(ch);
                    ch++;
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= rows; i++)
            {
                for (int j = i; j <= rows; j++)
                {
                    Console.Write(ch);
                    ch++;
                }
                Console.WriteLine();
            }
        }
        public static void printblocks19(int rows)
        {
            char ch = 'a';
            for (int i = 0; i <= rows; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(ch);
                    ch++;
                }
                Console.WriteLine();
            }
           
        }
        public static void printblocks20(int rows)
        {
            int temp=1;
            for (int i = 0; i <= rows; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" "+temp);
                    temp++;
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= rows; i++)
            {
                for (int j = i; j <= rows; j++)
                {
                    Console.Write(" "+temp);
                    temp++;
                }
                Console.WriteLine();
            }

 
        }
        public static void printblocks21(int rows)
        {
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows; j++)
                {
                    if (i == 1  || j == 1 || i==rows || j==rows)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                 
                }
                Console.WriteLine();
            }
        }
        public static void printblocks22(int rows)
        {
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows; j++)
                {
                    if (i==1 || i==rows || j==i )
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
        }
        public static void printblocks23(int rows)
        {
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows; j++)
                {
                    if (i == 1 || i == rows || i + j == (rows + 1))
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
        }
        public static void printblocks24(int rows)
        {
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows; j++)
                {
                    if (i == 1 || i == rows || j == i || i+j==(rows+1))
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
        }
        public static void printblocks25(int rows)
        {
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows; j++)
                {
                    if (i == 1 || i == rows || j == i || i + j == (rows + 1) || j == 1 || j == rows)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
        }
        public static void printblocks26(int rows)
        {
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows; j++)
                {
                        
                    if ( j == i || i + j== (rows+ 1))
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
        }
        public static void printblocks27(int rows)
        {
            for (int i=1;i<=rows;i++)
            {
                for (int j = rows - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k < i; k++)
                {
                    Console.Write(k);
                }
                for (int l = i; l > 0; l--)
                {
                    Console.Write(l);
                }
                Console.WriteLine();
            }
        }
        public static void printblocks28(int rows)
        {
            for (int i = 1; i <= rows; i++)
            {
                for (int j = rows - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k < i; k++)
                {
                    Console.Write(k);
                }
                for (int l = i; l > 0; l--)
                {
                    Console.Write(l);
                }
                Console.WriteLine();
            }
        }
        
    }
}





