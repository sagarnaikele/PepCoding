using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class Assignment3
    {
    
        static int no, row, cell,space=0,k=0;
        public static void printpattern(int no)
        {
            for (row = no; row >= 1;row--)
            {
                no--;
                for (cell = 1; cell <= row; cell++)
                {
                xxx:
                    if (k<space)
                    {
                        Console.Write(" ");
                        k = k +1;
                        goto xxx;
                    }
                    Console.Write(cell);
                   
                }
                Console.WriteLine();
                space++;
                k = 0;
            }
        }
        public static void Main()
        {
            Console.Write("Enter the to print pattern");
            no = Convert.ToInt32(Console.ReadLine());
            Assignment3.printpattern(no);
            Console.ReadKey();
        }
    }
}
