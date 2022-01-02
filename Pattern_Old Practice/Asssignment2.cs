using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class Assignment2
    {
        static int no, row, cell;
        public static void printpattern(int no)
        {
            for (row = no; row >= 1;row--)
            {
                no--;
                for (cell = 1; cell <= row; cell++)
                {
                    Console.Write(cell);
                }
                Console.WriteLine();
            }
        }
        public static void Main()
        {
            Console.Write("Enter the to print pattern");
            no = Convert.ToInt32(Console.ReadLine());
            Assignment2.printpattern(no);
            Console.ReadKey();
        }
    }
}
