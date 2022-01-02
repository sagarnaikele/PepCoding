using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class countdecrementing
    {
        static void Main()
        {
            Console.Clear();
            int count=1;
            int flag = 1;
            Console.WriteLine("Printing");
            for (int row = 1; row <=7; row++)
            {
                for (int cell = 1; cell <=(2 * row) - 1; cell++)
                {
                    if (flag != 0)
                    {

                        Console.Write(count.ToString());
                        count++;
                        if (count == 10)
                        {
                            flag = 0;
                            count--;
                        }

                    }
                    else
                    {
                        count--;
                        Console.WriteLine(count.ToString());
                        
                        
                        if (count == 1)
                        {
                            flag = 1;
                            count++;
                        }
                    }
                }
                //Console.WriteLine();
            }
            Console.ReadKey();
        }

    }
}
