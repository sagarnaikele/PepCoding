using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class Logica
    {
        public static int row, cell, count = 1, no = 1,count1 = 1;
       
        public int input()
        {
            Console.Write("Enter the input row to print pattern");
            no = Convert.ToInt32(Console.ReadLine());
            return no;
        }
        public void printpattern(int no)
        {

            for (row = 1; row <= no; row++)
            {

                count = no - 1;
                count1 = row;
                Console.Write(row);
                for (cell = 1; cell < row; cell++)
                {
                    count = count1 +count;
                    Console.Write(count);
                    count1 = count1 - 1;
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Logica obj = new Logica();
            no = obj.input();


            obj.printpattern(no);

            Console.ReadKey();
        }
    }
}