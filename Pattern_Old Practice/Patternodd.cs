using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class Patternodd
    {
        int row, n, col, count=1,no,k,count1;
        public void userinput()
        {
            Console.Write("Enter the no");
            n = Convert.ToInt32(Console.ReadLine());
            printpatter(n);
        }
        public void printpatter(int n)
        {
            no = n;
            for (row = 1; row <= n; row++)
            {
                Console.Write(count);
                count1 = count;
                for (col = 1;col <row; col++)
                {
                    count1 = count1 - k;
                    k++;
                    Console.Write(count1);
                }
                count = count + no;
                
                no--;
                k = no;
                Console.WriteLine();
            }
        }
        public static void Main()
        {
            Patternodd obj = new Patternodd();
            obj.userinput();
            Console.Read();
        }
    }
}
