using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class Assignment5
    {


        public static int row, cell, space, no = 1, flag = 1,flag1=1;
        int count = 0,count1=1;
        string[] str = new string[5] { "a", "e", "i", "o", "u" };
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
                for (space = 1; space <= no - row; space++)
                {
                    Console.Write(" ");
                }
                for (cell = 0; cell < (2 * row) - 1; cell++)
                {
                    if (row % 2 != 0)
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
                    else
                    {
                        if (flag1 != 0)
                        {

                            Console.Write(count1.ToString());
                            count1++;
                            if (count1 == 10)
                            {
                                flag1 = 0;
                                count1--;
                            }

                        }
                        else
                        {
                            count1--;
                            Console.Write(count1.ToString());


                            if (count1 == 1)
                            {
                                flag1 = 1;
                                count1++;
                            }
                        }

                    }
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Assignment5 obj = new Assignment5();
            row = obj.input();


            obj.printpattern(row);

            Console.ReadKey();
        }
    }
}
