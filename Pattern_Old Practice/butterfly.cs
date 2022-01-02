using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class butterfly
    {
        int no, no1, row, space, cell;
        public void userinput()
        {
            Console.WriteLine("Enter the no");
            no = Convert.ToInt32(Console.ReadLine());

        }
        public void printpattern()
        {
            int no1 = 1;
            int no2 =   no / 2;
            int flag = 0;
            int no3=no/2;
            for (row = 0; row < no; row++)
            {
                for (cell = 0; cell < no; )
                {
                    if (cell <= row)
                    {
                        Console.Write(no);
                        cell++;
                    }

                }//innerforloop
                Console.WriteLine();
            }//outerforloop
        }
        static void Main()
        {
            butterfly obj = new butterfly();
            obj.userinput();
            obj.printpattern();
            Console.ReadLine();
        }

    }
}
