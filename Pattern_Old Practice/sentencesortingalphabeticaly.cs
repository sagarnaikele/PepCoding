using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class sentencesortingalphabeticaly
    {
        int i = 0, j = 0, k = 0;
        string[] str1;
        string str = string.Empty;
        string temp2;
        string str4;

        static int temp = 0;
        static int temp1 = 0;
        int sum, sum1, sum2;
        string str3 = string.Empty;
        string str5 = string.Empty;
        string str6 = string.Empty;
        int n = 0;
        int flag = 0;
        public void userinput()
        {
            Console.WriteLine("Enter the string");
            str = Console.ReadLine();

            for (i = 0; i < str.Length; i++)
            {
                if (str[i].ToString() != " ")
                {


                }

                else
                {

                    temp1 = temp1 + 1;

                }

            }
            temp1 = temp1 + 1;
            str1 = new string[temp1];
            temp1 = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].ToString() != " ")
                {
                    temp2 += str[i].ToString();
                }
                else
                {
                    str1[temp1] = temp2;

                    temp2 = string.Empty;
                    temp1 = temp1 + 1;
                }
            }

            str1[temp1] = temp2;

            sortstring();
        }
        public void sortstring()
        {

            for (int first = 0; first < str1.Length; first++)
            {
                str3 = str1[first].ToString();

                for (int last = 0; last < str1.Length; last++)
                {

                    str4 = str1[last].ToString();
                    k = 0; j = 0;
                    while (k < str4.Length)
                    {
                       

                        char ccc = str4[k];
                        temp = (int)ccc;
                        sum1 = temp;
                        k += 1;

                        if (j < str3.Length)
                        {
                            char c = str3[j];
                            temp = (int)c;
                            sum = temp;
                            j = j + 1;
                        }

                         if (sum > sum1)
                        {

                            temp2 = str1[first].ToString();
                            str1[first] = str1[last].ToString();
                            str1[last] = temp2;
                           }



                    }


                }
            }
            for (int i = 0; i < str1.Length; i++)
            {
                Console.Write(str1[i].ToString()+" ");
            }
        }
        public static void Main()
        {
            sentencesortingalphabeticaly obj = new sentencesortingalphabeticaly();
            obj.userinput();
            Console.ReadLine();
        }

    }
}
