using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class MatrixPattern
    {
        int row,cell,count,count1,count2=1,no,count3;
        public void userinput()
        {
            Console.Write("Enter the row value");
            no = Convert.ToInt32(Console.ReadLine());
            count = no;
            printmatrix(no, count);
        }
        public void printmatrix(int no,int count)
        {
           count1=no;
           count3 = no;
            for (row =count; row>=1; row--)
            {
                
                for (cell = 1; cell <=2 * no - 1; cell++)
                {
                    if(cell==1||cell==2*no-1)
                    {
                        Console.Write(count3);
                        count3 = row;
                        count1++;
                        count2=1;
                    }
                    
                    if (count2 <=2*row-1)
                    {
                        Console.Write(row);
                        count2++;
                      
                    }
                    else
                    {
                        count3++;
                        Console.Write(count3);

                    }
                    
                }
                Console.WriteLine();
                //count1 = count;
                count = count - 1;
                count2=1;
                count3 = no;
                count1--;
            }
        }
        static void Main()
        {
            MatrixPattern obj = new MatrixPattern();
            obj.userinput();
            Console.ReadLine();
        }
    }
}
