using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class ReflectionMatrix
    {
        int row, cell, no, no1;
        int[,] mat1;
        public void input()
        {
            Console.WriteLine("Enter the Row and Column:=");
            no = Convert.ToInt32(Console.ReadLine());
            no1 = Convert.ToInt32(Console.ReadLine());
            mat1=new int[no, no1];
            Console.Write("Enter the value into matrix");
            for (int i = 0; i < no; i++)
            {
                for (int j = 0; j < no1; j++)
                {
                    mat1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            printreflection();

        }
        public void printreflection()
        {
            Console.WriteLine("Printitng Reflection Matrix");
            for(row=0;row<no;row++)
            {
                int no2 = row;
                int no3=no1;
            xxx:
                for (cell =0; cell <no1; cell++)
                {
                   
                        if (row == 0 || row == no - 1)
                        {
                            if (row == 0)
                            {

                                no3=no3-1;
                                Console.Write(mat1[no2,no3]);

                            }
                            else
                            {
                                
                                Console.Write(mat1[no2,cell]);
                            }
                           
                        }
                        
                   }

                
                Console.WriteLine();
                if (row == 0)
                {
                    if (no2 <= no - 2)
                    {
                        no2 = no2 + 1;
                        no3 = no1;
                        goto xxx;
                    }
                }
                else if(row==no-1)
                {
                    if (no2 >0)
                    {
                        no2 = no2 -1;
                       
                        goto xxx;
                        break;
                    }
                }
               
                
        }
        }
        static void Main()
        {
            Console.Write("Printing Reflection Matrix");
            ReflectionMatrix obj = new ReflectionMatrix();
            obj.input();
            Console.ReadLine();
        }
    }
}
