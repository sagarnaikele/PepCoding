using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class Binarypatternusingoneloop
    {
    
        public static int row=1, cell, space=1, no = 1,space1=1;
        int count = 1;
        public int input()
        {
            Console.Write("Enter the input row to print pattern using one loop");
            no = Convert.ToInt32(Console.ReadLine());
            return no;
        }
        public void printpattern(int no)
        {
           
            //for (row = 1; row <= no; row++)
            //{
              

             rowprint:
                    if (row <= no)
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
                row++;
              
                space1++;
                space = space1;
                Console.WriteLine();
                goto rowprint;
            }
        }
        static void Main(string[] args)
        {
            Binarypatternusingoneloop obj = new Binarypatternusingoneloop();
            no = obj.input();


            obj.printpattern(no);

            Console.ReadKey();
        }
    }
}
   