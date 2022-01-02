using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class Voweldeceremnting
    {
    
 
        public static int row, cell, space, no = 1,flag=1;
        int count = 0;
        string []str=new string[5]{"a","e","i","o","u"};
        public int input()
        {
            Console.Write("Enter the input row to print pattern");
            row = Convert.ToInt32(Console.ReadLine());
            return row;
        }
        public void printpattern(int no)
        {

            for (row = 1; row <= no; row++)
            {
                for (space =1; space <=no-row; space++)
                {
                    Console.Write(" ");
                }
                for (cell = 0; cell < (2 *row) - 1; cell++)
                {
                    if (flag != 0)
                    {

                        Console.Write(str[count]);
                        count++;
                        if (count == 5)
                        {
                            flag = 0;
                            count--;
                        }

                    }
                    else
                    {
                        count--;
                        Console.Write(str[count]);


                        if (count == 0)
                        {
                            flag = 1;
                            count++;
                        }
                    }
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Voweldeceremnting obj = new Voweldeceremnting();
            row = obj.input();


            obj.printpattern(row);

            Console.ReadKey();
        }
    }
}
