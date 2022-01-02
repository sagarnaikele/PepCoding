using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class patternodd1
    {
        int row, n, col, count = 1, no, k, count1;
        public void userinput()
        {
            Console.Write("Enter the no");
            n = Convert.ToInt32(Console.ReadLine());
            printpatter(n);
        }
        public void printpatter(int n)
        {
          
            for (row = n; row >=1; row--)
            {
                count = row + 1;
                k = row;
                Console.Write(count);
               
                for (col = n; col >row; col--)
                {
                    count = count+ k;
             
                    Console.Write(count);
                }
                

               
                k = row;
                Console.WriteLine();
            }
        }
        public static void Main()
        {
            patternodd1 obj = new patternodd1();
            obj.userinput();
            Console.Read();
        }
    }
}
