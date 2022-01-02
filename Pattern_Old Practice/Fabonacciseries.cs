using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class Fabonacciseries
    {

   
        static int first= 0,last=1,sum=0;
        static int no;

        public void factorial(int no,int first)
        {
            Console.Write(sum);
            sum = last +first;
            last = first;
            first = sum;
            if(no>1)
            {
                no--;
                factorial(no,first);
            }
           
        }
        public static void Main()
        {
            Fabonacciseries obj = new Fabonacciseries();
            Console.Write("Enter the no to print fabonacci");
            no = Convert.ToInt32(Console.ReadLine());
            obj.factorial(no,first);
            Console.ReadKey();
        }
    }
}

