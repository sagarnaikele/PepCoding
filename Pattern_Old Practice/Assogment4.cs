using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class Assogment4
    {
        static int no, row, cell, space = 0, k = 1;
        public static void printpattern(int no)
        {
            space = no;
            for (row = 1; row <=no; row++)
            {
               
                for (cell = 1; cell <= row; cell++)
                {
                xxx:
                    if (k <space)
                    {
                        Console.Write(" ");
                        k = k + 1;
                        goto xxx;
                    }
                    Console.Write(cell);

                }
                Console.WriteLine();
                space--;
                k = 1;
            }
        }
        public static void Main()
        {
            Console.Write("Enter the to print pattern");
            no = Convert.ToInt32(Console.ReadLine());
            Assogment4.printpattern(no);
            Console.ReadKey();
        }
    }
}
