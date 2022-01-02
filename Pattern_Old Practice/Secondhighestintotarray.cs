 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class Secondhighestintotarray
    {
        int no, no1;
        int[] arr;
       int[] arr1;
        public void input()
        {
            Console.WriteLine("Enter the first no and second no for array:");
            no = Convert.ToInt32(Console.ReadLine());
            no1 = Convert.ToInt32(Console.ReadLine());
            arr = new int[no];
            arr1 = new int[no1];

            Console.WriteLine("Enter input into first array:");
            for (int i = 0; i < no; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                
            }
         
            checkduplicate();
        }
        public void checkduplicate()
        {
            int flag = 0;
            for (int i = 0; i < no; i++)
            {
                for (int j = 0; j < no; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        no1 = arr[i];
                        arr[i] = arr[j];
                        arr[j] = no1;
                    }
                }
            }

           int  k = 0;
           int count=0;
                Console.WriteLine("Top Heighest is:"+arr[arr.Length-1]);
                for (int j = no-1; j > 0; j--)
                {
                    if (arr[j] > arr[j -1])
                    {
                        count = count + 1;
                        if (count == 2)
                        {
                            Console.WriteLine("second lowest is:" + arr[j]);
                            count = 0;
                            break;
                        }
                    }
                }
              
               
                for (int j = 0; j < no; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        count = count+1;
                        if (count == 2)
                        {
                            Console.WriteLine("second lowest is:" + arr[j]);

                            break;
                        }
                    }
                }
        }
        static void Main()
        {
          Secondhighestintotarray obj = new Secondhighestintotarray();
            obj.input();
            Console.ReadLine();
        }
    }
}
