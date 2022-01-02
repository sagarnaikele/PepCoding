
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class SpiralPatternDynamic
    {
        int no, count1, count2=1, count3, count4,no1,count5=40,coun6;
        public void input()
        {
            Console.Write("Enter the input ");
            no = Convert.ToInt32(Console.ReadLine());
            printspiral();
        }
        public void printspiral()
        {
            count1 = (no - 1)* 4;
            count3 = count1 - no + 2;
            count4 = count3 + no - 2;
            

            for (int i = 1; i <= no; i++)
            {
                for (int j = 1; j <= no; j++)
                {
                    if (i == 1&&j!=no)//first row but except last column of row
                    {
                        Console.Write(count2+" "+" ");
                        count2++;
                    }
                    else if (i == no)//completely last row
                    {
                        Console.Write(count3+" ");
                        count3--;
                    }
                    else if (j==1)//after firstrow always first column value
                    {
                        Console.Write(count4+" ");
                        count4--;
                    }

                    else if (j == no)//after first row always last column wil print
                    {
                        Console.Write(count2);
                        count2++;
                    }
                    else if (j == no - 1&&i>2)//after second row it will print no-1 cell value
                    {
                        
                        count1 = count1 + 1;
                        Console.Write(count1+ " ");
                        
                    }
                    else if (i == 2)///Complete second row wil print
                    {

                        count1 = count1 + 1;
                        Console.Write(count1 + " ");


                    }
                    else
                    {

                        if (no1 == no / 2)
                        {
                            if (j == 2)
                            {
                                Console.Write(count5 + " ");
                                coun6 = count5;
                                count5 = count5 - 1;
                            }
                            else
                            {

                                coun6 = coun6 + 1;
                                Console.Write(coun6 + " ");
                            } 
                        }
                        else if (no1 <= no / 2)
                        {
                            if (j == 2)
                            {
                                Console.Write(count5 + " ");
                                coun6 = count5;
                                count5 = count5 - 1;
                            }
                            else
                            {

                                coun6 = coun6 + 1;
                                Console.Write(coun6+" ");
                            }

                        }
                        else
                        {
                            if (j == 2)
                            {
                                Console.Write(count5 + " ");
                                coun6 = count5;
                                count5 = count5 - 1;
                            }
                            else
                            {
                                
                                coun6 = coun6 - 1;
                                Console.Write(coun6 + " ");
                            }
                        }

                     }




                     
                       
                    
                
                }
                Console.WriteLine();
                no1=no1+1;
            }
        }
        static void Main()
        {
            SpiralPatternDynamic obj = new SpiralPatternDynamic();
            obj.input();
            Console.ReadLine();
        }
    }
}
