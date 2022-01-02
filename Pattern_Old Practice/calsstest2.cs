using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class calsstest2
    {
        static int no, no1;
        static int[] arr;
        static int[] arr1;
        static int flag = 0;
        static void Main()
        {
            Console.WriteLine("Enter the no and no1");
            no = Convert.ToInt32(Console.ReadLine());
            no1 = Convert.ToInt32(Console.ReadLine());
            arr = new int[no];
            arr1 = new int[no1];
            for (int i = 0; i < no; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int j = 0; j < no; j++)
            {
                arr1[j] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < no; i++)
            {
                for (int j = 0; j < no; j++)
                {
                    if (arr[i] == arr1[j])
                    {
                        flag = 1;
                        break;
                    }

                }
                if (flag != 1)
                {
                    Console.WriteLine(arr[i]);
                }
                flag = 0;
            }
            flag = 0;
            for (int i = 0; i < no; i++)
            {
                for (int j = 0; j < no; j++)
                {
                    if (arr1[i] == arr[j])
                    {
                        flag = 1;
                        break;
                    }

                }
                if (flag != 1)
                {
                    Console.WriteLine(arr1[i]);
                }
                flag = 0;
            }
            Console.ReadLine();
        }
    }
}
