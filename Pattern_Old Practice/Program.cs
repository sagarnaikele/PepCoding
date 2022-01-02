using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class Program
    {
       public static int row, cell, space, no=1;
       int count = 1;
       public int input()
       {
           Console.Write("Enter the input row to print pattern");
           row = Convert.ToInt32(Console.ReadLine());
           return row;
       }
       public void printpattern(int row)
       {
         
           for (space = no; space <= row - 1; space++)
           {
               Console.Write(" ");
           }
           for (cell = 0; cell <(2*no) - 1; cell++)
           {
               Console.Write(count % 2);
               count++;
           }
           Console.WriteLine();
           if (no < row)
           {
               no++;
               printpattern(row);
           }
       }
       static void Main(string[] args)
        {
            Program obj = new Program();
            row = obj.input();
           
           
           obj.printpattern(row);

            Console.ReadKey();
        }
    }
}
