
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class Duplicate
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
            Console.WriteLine("Enter the input into secodn array");
            for (int i = 0; i < no1; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
           
            checkduplicate();
        }
        public void checkduplicate()
        {
            int flag = 0;
            
            for (int i = 0; i < no; i++)
            {
                int j = 0;

            xxx:
                flag = 0;
                    if (j <= i)
                    {
                        if (arr[i] == arr1[j])
                        {
                            flag = 1;
                        }
                          j++;
                        if (flag == 1)
                        {
                            Console.WriteLine("Duplicate value is:" + arr[i]);
                            flag = 0;
                        }
                        goto xxx;
                    }

                  
            }
        }
        static void Main()
        {
            Duplicate obj = new Duplicate();
            obj.input();
            Console.ReadLine();
        }
    }
}
