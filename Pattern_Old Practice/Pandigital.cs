using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class Pandigital
    {
        string str = string.Empty;
        int[] ar;
        int flag = 0;
        int j = 1, temp = 0;
        string st2;
        public void input()
        {
            Console.WriteLine("Enter the input in digit");
            str = Console.ReadLine();
            checkdigital();
        }
        public void checkdigital()
        {
            ar = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].ToString() != "0")
                {
                    st2 = str[i].ToString();
                    ar[i] = Convert.ToInt32(st2); ;
                }
                else
                {
                    flag = 1;
                    Console.WriteLine("Sorry It should not contain any 0 digit");
                    break;
                }
            }
            if (flag == 0)
            {
                j = 0;
                for (int i = 0; i < ar.Length; i++)
                {
                    for (j = 0; j < ar.Length; j++)
                    {
                        if (ar[i] >ar[j])
                        {
                            temp= ar[i];
                            ar[i] = ar[j];
                            ar[j] = temp;

                        }
                    }
                }
                if (ar[0] == str.Length)
                {
                    for (int k = 0; k < str.Length - 1; k++)
                    {

                        if (ar[k] == ar[k + 1])
                        {
                            flag = 1;
                            break;
                        }


                    }
                }
                else
                {
                    Console.WriteLine("Sorry not pandigital no");
                    return;
                }
            }
                    else
                    {
                        Console.WriteLine("Sorry this is not pandigital number");
                        return;
                    }
                
                

           
            if (flag == 0)
            {
                Console.WriteLine(" pandigital no");
            }
            else
            {
                Console.WriteLine("Not pandigital no");
                return;
            }
            

        }
        static void Main()
        {
            Pandigital obj = new Pandigital();
            obj.input();
            Console.ReadLine();
        }
    }
}
