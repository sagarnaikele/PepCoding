using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class binarypatternusingwithoutloop
    {

        public static int row = 1, cell=1, space = 1, no = 1, space1 = 1;
        int count = 1;
        public int input()
        {
            Console.Write("Enter the input row to print pattern without using  loop");
            no = Convert.ToInt32(Console.ReadLine());
            return no;
        }
        public void printpattern(int no)
        {

         
             rowprint:
            if (row <= no)
            {

            cellprint:
                if(cell<=(2*row)-1)
                {
                
                spacevalue:
                    if (space <= no - 1)
                    {

                        Console.Write(" ");
                        space++;
                        goto spacevalue;
                    }
                cell++;
                    Console.Write(count % 2);
                    count++;
                    goto cellprint;
                }
                row++;
                cell = 1;
                space1++;
                space = space1;
                Console.WriteLine();
                goto rowprint;
            }
        }
        static void Main(string[] args)
        {
            binarypatternusingwithoutloop obj = new binarypatternusingwithoutloop();
            no = obj.input();


            obj.printpattern(no);

            Console.ReadKey();
        }
    }
}
