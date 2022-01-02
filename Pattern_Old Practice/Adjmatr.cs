using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class Adjmatr
    {
        static void Main(string[] args)
        {
            int[,] arr;
            int val1, val2;
            //bool brek = false;
            int i, j;
            Console.WriteLine("Enter the rows and column of the matrix respectively");
            i = int.Parse(Console.ReadLine());
            j = int.Parse(Console.ReadLine());
            arr = new int[i, j];
            Console.WriteLine("Enter the {0} element in the matrix respectively", i * j);
            for (int row = 0; row < i; row++)
            {
                for (int col = 0; col < j; col++)
                {
                    arr[row, col] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter the {0} element in the matrix respectively", i * j);
            for (int row = 0; row < i; row++)
            {
                for (int col = 0; col < j; col++)
                {
                    Console.Write(arr[row, col] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Enter the value");
            int val = int.Parse(Console.ReadLine());
            for (int row = 0; row < i; row++)
            {
                for (int col = 0; col < j; col++)
                {
                    if (arr[row, col] == val)
                    {
                        val1 = row;
                        val2 = col;
                        if (val1 == 0 && val2== j-1)
                        {
                            Console.Write("Bottom Element is:" + arr[++row, col]);
                            Console.WriteLine("Right Element is:" + arr[val1, ++col]);
                            break;
                        }
                        else if(val1 == i-1 && val2== j-1)
                        {
                            Console.Write("Bottom Element is:" + arr[--row, col]);
                            Console.WriteLine("Right Element is:" + arr[val1,--col]);
                            break;
                        }
                        else if (row== 0 && col == j-1)
                        {
                            Console.Write("Bottom Element is:" + arr[++row, col]);
                            Console.WriteLine("Right Element is:" + arr[val1, --col]);
                            break;
                        
                        }
                        else if (row == i-1 && col == 0)
                        {
                            Console.Write("Bottom Element is:" + arr[--row, col]);
                            Console.WriteLine("Right Element is:" + arr[val1, ++col]);
                            break;

                        }
                        else
                        {
                            if (val1 != i-1)
                            {
                                Console.WriteLine("Bottom Element is:" + arr[++row, col]);
                            }
                             if (val1!= 0)
                            {
                                Console.WriteLine("Top Element is:" + arr[--row, col]);
                            }

                            if (val2!=j-1)
                            {
                                Console.WriteLine("Right Element is:" + arr[val1, ++col]);
                            }
                            if (val2 != 0)
                            {
                                Console.WriteLine("Left Element is:" + arr[val1, --val2]);
                            }
                            break;
                        }
                    }
                  
                }
                          }
            Console.ReadKey();
        }
    }
}