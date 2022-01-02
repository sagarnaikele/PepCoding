using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class nearestpalindrome
    {
      static  int no, sum, temp = 0, no1,high,low,dif,diff1,copy,count=1,no2;
       static Boolean flag=false;
        public int userinput()
        {
            Console.Write("Enter the no to find nearest palindrome");
            no = Convert.ToInt32(Console.ReadLine());
           
            return no;
        }
        public static  bool checkpalindrome(int no1)
        {
            temp = 0;
            if (count == 0)
            {
                no2 = no1;
            }
            while (no1 > 0)
            {
                sum = no1 % 10;
                temp = temp * 10 + sum;
                no1 = no1 / 10;
            }
            //if(count==0)
            //{
                if(temp==no2)
                    flag=true;
            //}
            else
            {
                if(temp==no)
                flag = true;
            }
            return flag;
        }
        public void palindrome()
        {
            flag = false;
           
            for (no1 = no; ; no1--)
            {
                count = 0;
                copy = no1;
                flag = nearestpalindrome.checkpalindrome(no1);
                if (flag == true)
                {
                    low = copy;
                    break;
                }
            }
            for (no1 = no; ; no1++)
            {
                flag = false;
                copy = no1;
                count = 0;
                flag = nearestpalindrome.checkpalindrome(no1);
                if (flag == true)
                {
                    high = copy;
                    break;
                }
            }

            dif = no - low;
            diff1 = high - no;
            if (dif > diff1)
            {
                Console.Write(high);
            }
            else
            {
                Console.Write(low);
            }
        }
        static void Main(string[] args)
        {
            nearestpalindrome obj=new nearestpalindrome();
            no = obj.userinput();
            flag = nearestpalindrome.checkpalindrome(no);
            if (flag ==true)
            {
                Console.Write("No is Already Palindrome");
                //return;
            }
            else
            {
                obj.palindrome();
            }
            Console.ReadKey();
        }
    }
}
