using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class _1234
    {
        static void Main()
        {
            int no = 5;
            int no1=no;
            int count=0,count1=0;
            for (int i = no; i >= 1; i--)
            {
                count = 0;
                for (int cell = 1; cell <= 2 * no1-1; cell++)
                {
                    if (cell <= i)
                    {

                        count = count + 1;
                        Console.Write(count);
                    }
                    else 
                    {
                        for (int space = 1; space <=2*count1-1; space++)
                        {
                            if (i != no1)
                            {
                                Console.Write(" ");
                                cell++;
                            }
                        }
                    xxx:
                        if (cell < 2 * no1)
                        {
                            if (i == no1)
                            {
                                count = count - 1;
                                Console.Write(count);
                                
                                cell++;
                                goto xxx;
                            }
                            else
                            {
                                Console.Write(count);
                                count = count - 1;
                                cell++;
                                goto xxx;
                            }
                        }
                    }
                }
                count1++;
                Console.WriteLine();
                no = no - 1;
            }
            Console.ReadLine();
        }
    }
}
