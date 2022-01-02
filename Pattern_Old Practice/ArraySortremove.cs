using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class ArraySortremove
    {
        int[] arr = new int[10];
        int[] arr1 = new int[10];
        int no, temp;
        int i = 0;
        public void input()
        {
            Console.Write("Enter the no in array");
            no = Convert.ToInt32(Console.ReadLine());
            temp = no;
            for (i = 0; i < no; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            sortarray(arr);
        }
        public void sortarray(int[] arr)
        {
            int j = 0;

            for (i = 0; i < arr.Length; i++)
            {
                for (j = 0; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        no = arr[j];
                        arr[j] = arr[i];
                        arr[i] = no;

                    }
                }
            }
            j = 0;
            while (j < arr.Length)
            {

                
                Console.WriteLine(arr[j].ToString());
                j++;
            }
            Console.WriteLine("Enter the value to remove");
            no = Convert.ToInt32(Console.ReadLine());
            for (j = 0; j < arr.Length; j++)
            {
                if (no != Convert.ToInt32(arr[j]))
                {
                    if (Convert.ToInt32(arr[j]) != 0)
                    {
                        Console.WriteLine(arr[j].ToString());
                    }
                }
            }



        }
        public static void Main()
        {
            ArraySortremove obj = new ArraySortremove();
            obj.input();
            Console.Read();
        }
    }
}
   