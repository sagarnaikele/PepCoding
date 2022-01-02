using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class vowelpattern
    {
        public static int row, cell, space, no = 1;
        int count = 0;
        string []str=new string[5]{"a","e","i","o","u"};
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
            for (cell = 0; cell < (2 * no) - 1; cell++)
            {
                if (count < 5)
                {

                  
                    Console.Write(str[count].ToString());
                    
                }
                else
                {
                    count = 0;
                    Console.Write(str[count].ToString());
                   
                }
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
            vowelpattern obj = new vowelpattern();
            row = obj.input();


            obj.printpattern(row);

            Console.ReadKey();
        }
    }
}
