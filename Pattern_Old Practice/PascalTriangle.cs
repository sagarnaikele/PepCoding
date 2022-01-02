using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class PascalTriangle
    {
        int no, count, i, j, space;
        public void input()
        {
            Console.WriteLine("Enter the input row");
            no = Convert.ToInt32(Console.ReadLine());
            printpasacl();
        }
        public void printpasacl()
        {
            for(i=0;i<no;i++)
            {
                for(space=1;space<no-i;space++)
                {
                    Console.Write(" ");
                }
                for(j=0;j<=i;j++)
                {
                    if(j==0||j==i)
                    {
                        Console.Write("1"+" ");
                        count=1;
                    }
                    else
                    {
                         
                        int temp = (i - j + 1);
                        count=((count*(temp))/j);
                        Console.Write(count+" ");
                    }
                }
                Console.WriteLine();
            }
        }
        static void Main()
        {
            PascalTriangle obj = new PascalTriangle();
            obj.input();
            Console.ReadKey();
        }
    }
}
