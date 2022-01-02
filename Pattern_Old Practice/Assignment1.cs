using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class Assignment1
    {
       static int no, row, cell;
        public static void printpattern(int no)
        {
            for (row = 1; row<=no; row++)
            {
                for (cell = 1; cell <= row; cell++)
                {
                    Console.Write(cell);
                }
                Console.WriteLine();
            }
        }
        public static void Main()
        {
            Console.Write("Enter the row to print pattern");
            no = Convert.ToInt32(Console.ReadLine());
            Assignment1.printpattern(no);
            Console.ReadKey();
        }
    }
}
