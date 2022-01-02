using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class magicmatrix
    {
        int no,row,col,flag=0;
        int[,] mat1;
        public void input()
        {
            xxx:
            Console.WriteLine("Enter the row and column and row and column should be same");
             row = Convert.ToInt32(Console.ReadLine());
             col = Convert.ToInt32(Console.ReadLine());
             if (row == col)
             {
                 checkmatrix();
             }
             else
             {
                 Console.WriteLine("Sorry Your Row and COlumn Value doesn't Match Please try again!...");
                 goto xxx;
             }
        }
        public void checkmatrix()
        {
            mat1 = new int[row, col];
            Console.Clear();
            Console.WriteLine("Enter the "+row*col+"value into matrix and Don't put any duplicate or zero value");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                xx:
                    no = Convert.ToInt32(Console.ReadLine());
                if (no != 0)
                {
                    if (i == 0 && j == 0)
                    {
                        mat1[i, j] = no;
                    }

                    else
                    {
                        flag = checkduplicate(i, j);
                        if (flag == 0)
                        {
                            mat1[i, j] = no;
                        }
                        else
                        {
                            Console.WriteLine("Sorry Duplicate value not allowed");
                            goto xx;
                        }
                        flag = 0;
                    }

                }
                else
                {
                    Console.WriteLine("Sorry 0 is not acceptable to print magic matrix please try again!...");
                    goto xx;
                }
                }
            }
 
        }
        public int checkduplicate(int x, int y)
        {
            for (int k = 0; k <= x; k++)
            {
                for (int l = 0; l < y; l++)
                {
                    if (mat1[k, l] !=0)
                    {
                        if (mat1[k, l] == no)
                        {
                            flag = 1;
                            break;
                        }
                    }
                }
            }
            return flag;
        }
       static Void Main()
        {
            magicmatrix obj = new magicmatrix();
            obj.input();
            Console.ReadLine();
        }
    }
}
