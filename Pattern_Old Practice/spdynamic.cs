using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class spdynamic
    {

       static int [,]arr;
        static int no,t,i,max=0,index,j;
        static int count = 1;

        public void Input()
        {
            Console.WriteLine("Enter the no");
            no = Convert.ToInt32(Console.ReadLine());
            printpattern();
        }
        public void printpattern()
        {
            int no1, no2, no3;
            no1 = no;
            no2 = no;
            no3 = no;
            arr = new int[no, no];
            for (i = 0; i <=no/2; i++)
            {
                no1=i;
                for (j =no1 ; j < no - i - 1; j++)
                {
                    arr[no1, j] = count;
                    count = count + 1;

                }

                for (j = no2 - 1; j >= no1; )
                {
                    arr[no1, j] = count;
                    no1 = no1 + 1;
                    count = count + 1;

                }
                no1 = no1 - 1;
                for (j = no2-2; j>i; j--)
                {
                    arr[no1, j] = count;
                    count = count + 1;

                }
                for (j =i; j <= no1-1; )
                {

                    
                    arr[no1, i] = count;
                    no1 = no1 - 1;
                    count = count + 1;

                }
              
                no2 = no2 - 1;
                
                //for (j = no1; j >= 0; j--)
                //{
                //    arr[no1, j] = count;
                //    count += 1;
                //}
            }
           
            for (
                i = 0; i < no; i++)
            {
                for (j = 0; j < no; j++)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
       

        static void Main()
        {

            spdynamic obj = new spdynamic();
            obj.Input();
            Console.ReadLine();
           
        }
        
    }
}
