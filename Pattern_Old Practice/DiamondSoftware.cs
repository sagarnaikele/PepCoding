using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class DiamondSoftware
    {
        int no,no3;
        int count;
        string str;
         
        public void input()
        {
            Action<string> ankit = Console.Write;
            Action ankita = Console.WriteLine;
            ankit = Console.WriteLine;
           ankita();

            ankit("Enter the string:=");
            str = Console.ReadLine();
            no3 = str.Length;
            print();
        }
        public void print()
        {
            int no = 0;
            int no1 = str.Length/2;
            int no2 = str.Length - 1;
            int flag=0;
            for (int row = 0; row < str.Length; row++)
            {

                for (int cell = 0; cell < str.Length; cell++)
                {
                    if (row == 0 || row == str.Length - 1)
                    {
                        if (row == 0)
                        {

                            Console.Write(str[cell]);
                        }
                        else if(row==str.Length-1)
                        {
                              no3= no3 - 1;
                            Console.Write(str[no3]);

                        }
                    }
                    else
                    {
                        if (cell == 0)
                        {
                            if (no <= no1 - 1)
                            {
                                no = no + 1;

                                Console.Write(str[no]);
                                //Console.Write(" ");
                            }
                            else
                            {
                                //
                                no = no + 1;
                                Console.Write(str[no]);


                            }

                        }
                        else if (cell == str.Length - 1)
                        {
                            if (no2 >= no1)
                            {
                                no2 = no2 - 1;
                                Console.Write(str[no2]);

                            }
                            else
                            {
                                no2 = no2 - 1;
                                Console.Write(str[no2]);
                            }
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
        static void Main()
        {
            Console.BackgroundColor = System.ConsoleColor.Blue;
            DiamondSoftware obj = new DiamondSoftware();
            obj.input();
            Console.ReadLine();
        }
    }

}
