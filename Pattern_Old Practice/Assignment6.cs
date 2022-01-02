using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class Assignment6
    {
        int row, cell, space, no,count;
        public void userinput()
        {
            Console.Write("Enter the row no");
            no = Convert.ToInt32(Console.ReadLine());
            printpattern(no);
        }
        public void printpattern(int no)
        {
            for (row = 1; row <= no; row++)
            {
                
                for (space = 1; space <=no-row;space++)
                {
                    Console.Write(" ");
                }
                space = 0;
                for (cell = 0; cell < row; cell++)
                {
                    Console.Write("*");
                    if (row != 1)
                    {
                      
                        while (space <2*row-3)
                        {
                            Console.Write(" ");
                            space++;
                        }
                    }
                    if (row!=1)
                    {
                        Console.Write("*");
                        break;
                    }
                }
                Console.WriteLine();
            }
            count= no;
            for (row = 1; row < no; row++)
            {

                for (space = 1; space <= row; space++)
                {
                    Console.Write(" ");
                }
                
                for (cell = 1; cell <count; cell++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();
                count--;

            }
        }
        static void Main()
        {
            Assignment6 obj = new Assignment6();
            obj.userinput();
            Console.Read();
        }
        
    }
}
