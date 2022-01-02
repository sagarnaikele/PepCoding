using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class Arraysort
    {
        int[] arr = new int[10];
        int[] arr1 = new int[10];
        int no,temp;
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
          
                    j=0;
                
                    Console.Write("Top value="+arr[j].ToString());
                    Console.WriteLine("Bottom Value:="+arr[temp - 1].ToString());
                
            
        }
        public static void Main()
        {
            Arraysort obj = new Arraysort();
            obj.input();
            Console.Read();
        }
    }
}
