using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class ButterflyAshish
    {
     
        int num;
        public ButterflyAshish()
        {
            Console.Write("Enter no of row : ");
            num = int.Parse(Console.ReadLine());

        }
        public void Pattern()
        {
            for(int row=1;row<=num;row++)
            {
                for(int col=1;col<=num;col++)
                {
                    if (col == 1 || col == num)
                        Console.Write(5);
                    else if(col==num-(row-1))
                     Console.Write(5);
                    else if (col == row )
                    {

                        Console.Write(5);
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        static void Main()
        {
            ButterflyAshish b = new ButterflyAshish();
            b.Pattern();

            Console.ReadLine();
        }
    }
}

