using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class printmiddlespace
    {
        int row, cell, no, space=0, count=1, count1=1,k,count2,count3;
        public void userinput()
        {
            Console.WriteLine("Enter the input ");
            no = Convert.ToInt32(Console.ReadLine());
            printpattern(no);

        }
        public void printpattern(int no)
        {
            count1 = no * 3 + 2;
            for (row = 1; row <= no; row++)
            {

            
                for (cell =1; cell <= no; cell++)
                {
                    if (row == 1||row==no)
                    {
                        if (row == 1)
                        {
                            Console.Write(count+" ");

                            count++;
                        }
                        else if (row == no)
                        {
                            Console.Write(count);
                            count--;
                        }
                       
                    }

                    else
                    {

                        if (cell == 1 || cell == no)
                        {

                            Console.Write(count);
                           
                            if (cell == 1)
                            {
                                count2 = count;
                                count3 = count2;
                            }
                            count = row + no - 1;
                           
                        }
                        if (cell == no - 1)
                        {
                            count2 = count2 + 2 * row - 1;
                            Console.Write(count2);
                        }
                        if (cell != 1 && cell != no && cell != no - 1)
                        {
                            if (row == 2)
                            {
                                Console.Write(++count3);
                            }
                            else
                            {
                                if (row != 2 && space == 0)
                                {
                                    count3 = count3 + 9;
                                    space = space + 1;
                                }
                                if (row == no - 1)
                                {

                                    Console.Write(count3);
                                    count3--;
                                }
                                else
                                {
                                    Console.Write(count3);
                                    count3++;
                                }
                            }
                        }

                    }

                }
                space = 0;
                Console.WriteLine();

                count1--;
                count = count1;
               
            }
        }
        public static void Main()
        {
            printmiddlespace obj = new printmiddlespace();
            obj.userinput();
            Console.ReadLine();
        }
    }
}
