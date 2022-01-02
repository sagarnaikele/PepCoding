using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class AdjacentMatrix
    {

        static int[,] arr;
       
      static   int i, j,val,val1,val2;
      public void UserInput()
      {
          Console.WriteLine("Enter the rows and column");
          i = int.Parse(Console.ReadLine());
          j = int.Parse(Console.ReadLine());
          arr = new int[i, j];
          Console.WriteLine("Enter the element:=");
          for (int row = 0; row < i; row++)
          {
              val1=row;
              for (int col = 0; col < j; col++)
              {
                  val2=col;
              xxx:

                  int temp = int.Parse(Console.ReadLine());
                 

                  arr[row, col] = int.Parse(Console.ReadLine());
              }
          }
          Console.WriteLine("Entered element in the matrix ", i * j);
          for (int row = 0; row < i; row++)
          {
              for (int col = 0; col < j; col++)
              {

                  Console.Write(arr[row, col]);
              }
              Console.WriteLine();
          }
          Console.WriteLine();
          Console.WriteLine("Enter the value");
          int val = int.Parse(Console.ReadLine());
           CheckAdjacentMatrix(val);
      }
        public void CheckAdjacentMatrix(int val)
        {

            for (int row = 0; row < i; row++)
            {
                for (int col = 0; col < j; col++)
                {
                    if (arr[row, col] == val)
                    {
                        if (row == 0)
                        {
                            Console.WriteLine("No top element");
                            Console.WriteLine("Bottom element = {0}", arr[row + 1, col]);
                        }
                        else if (row == i - 1)
                        {
                            Console.WriteLine("No Bottom element");
                            Console.WriteLine("Top element = {0}", arr[row - 1, col]);
                        }


                        else
                        {
                            Console.WriteLine("Top element = {0}", arr[row - 1, col]);
                            Console.WriteLine("Bottom element = {0}", arr[row + 1, col]);
                        }
                        if (col == 0)
                        {
                            Console.WriteLine("No Left element");
                            Console.WriteLine("Right element = {0}", arr[row, col + 1]);
                        }
                        else if (col == j - 1)
                        {
                            Console.WriteLine("No Right element");

                            Console.WriteLine("Left element = {0}", arr[row, col - 1]);

                        }
                        else
                        {
                            Console.WriteLine("Right element = {0}", arr[row, col + 1]);
                            Console.WriteLine("Left element = {0}", arr[row, col - 1]);
                        }
                    }
                }

            }
            
        }
        
        static void Main(string[] args)
        {
            AdjacentMatrix obj = new AdjacentMatrix();
            obj.UserInput();
           
Console.ReadLine();
        }

    }
}