using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class Arrrajendrasir
    {
        int[] arr;
        int[] arr1;
        string str,str1;
        int no,no1,flag=0;
        public void input()
        {
            Console.WriteLine("Enter the Length 2 times for both the array");
            no = Convert.ToInt32(Console.ReadLine());
            no1 = Convert.ToInt32(Console.ReadLine());
            arr = new int[no];
            arr1 = new int[no1];
            Console.Write("Enter the value into first array");
            for (int i = 0; i < no; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Enter the vlaue into second array");
            for (int i = 0; i < no1; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            checkduplicate();
        }
        public void checkduplicate()
        {
            Console.WriteLine("Now printing array duplicate and similar vlaue");
            for (int i = 0; i < arr.Length; i++)
            {
                flag = 0;
                for (int j = 0; j < no1; j++)
                {
                    if (arr[i] == arr1[j])
                    {
                        flag = 1;
                        break;
                    }

                }
                if (flag == 1)
                {
                    if (i != 0)
                    {
                        str1= arr[i].ToString();
                        chk();
                    }
                    else
                    {
                        Console.WriteLine("Matched Element of Array:"+arr[i]);
                        str += arr[i].ToString();
                    }
                }
                else
                {
                    if (i != 0)
                    {
                        str1 = arr[i].ToString();
                        chk();
                    }
                    else
                    {
                        Console.WriteLine("UnMatchedElement Of Array:" + arr[i]);
                        str += arr[i].ToString();
                    }
                }
            }
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    flag = 0;
            //    for (int j = 0; j < no; j++)
            //    {
            //        if (arr1[i] == arr[j])
            //        {
            //            flag = 1;
            //            break;
            //        }

            //    }
            //    if (flag == 1)
            //    {
            //        if (i != 0)
            //        {
            //            str1 = arr1[i].ToString();
            //            chk();
            //        }
            //        else
            //        {
            //            Console.WriteLine("Matched Element of Array:" + arr1[i]);
            //            str += arr[i].ToString();
            //        }
            //    }
            //    else
            //    {
            //        if (i != 0)
            //        {
            //            str1 = arr1[i].ToString();
            //            chk();
            //        }
            //        else
            //        {
            //            Console.WriteLine("Unmatched Element of Array:" + arr1[i]);
            //            str += arr1[i].ToString();
            //        }
            //    }
            //}



}
        public void chk()
        {
            flag = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].ToString() == str1)
                {
                    flag = 1;

                }
            }
            if (flag != 1)
            {


                Console.WriteLine("unquie value of Array:=" + str1);
                str += str1;

            }
            else
            {
                Console.Write("Duplicate value of Array:=" + str1);
            }
        }
        static void Main()
        {
            Arrrajendrasir obj = new Arrrajendrasir();
            obj.input();
            Console.ReadLine();
        }
    }
}
