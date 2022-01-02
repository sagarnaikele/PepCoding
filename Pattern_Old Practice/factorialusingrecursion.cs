using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class factorialusingrecursion
    {
        static int fact = 1, sum = 1;
        static int no;

        public void factorial(int no,int fact)
        {
            sum = sum * fact;
            if(no>1)
            {
                no--;
                factorial(no,fact=fact+1);
            }
           
        }
        public static void Main()
        {
            factorialusingrecursion obj = new factorialusingrecursion();
            Console.Write("Enter the no to print factorial");
            no = Convert.ToInt32(Console.ReadLine());
            obj.factorial(no,fact);
            Console.Write("factorial is:" + sum.ToString());
            Console.ReadKey();
        }
    }
}
