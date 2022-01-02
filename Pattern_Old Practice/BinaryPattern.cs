using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class BinaryPattern
    {
        public static int row, cell, space=1, no = 1,space1=1;
        int count = 1;
        public int input()
        {
            Console.Write("Enter the input row to print pattern");
            no = Convert.ToInt32(Console.ReadLine());
            return no;
        }
        public void printpattern(int no)
        {
           
            for (row = 1; row <= no; row++)
            {
              

                for (cell = 1; cell <= (2 * row) - 1; cell++)
                {
                xxx:
                    if (space <= no - 1)
                    {

                        Console.Write(" ");
                        space++;
                        goto xxx;
                    }
                    Console.Write(count % 2);
                    count++;
                }
                space1++;
                space = space1;
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            BinaryPattern obj = new BinaryPattern();
            no = obj.input();


            obj.printpattern(no);

            Console.ReadKey();
        }
    }
}
   