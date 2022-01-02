using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class pushpendra
    {
        string no,no1;
        int j = 0, i, k;
        int count, temp;
        string[] no2;

        public void input()
        {
          
            Console.Write("Enter the no to check circular queue");
            no = Console.ReadLine();
            no2=new string[no.Length];
            for (i = 0; i < no.Length; i++)
            {
                no2[i] = no[i].ToString();
            }
            makecombination(no);
            //checkcircularqueue(no);
        }
        public void makecombination(string no)
        {
            for (i = 0; i < no2.Length; i++)
            {
                for (j = 0; j < no2.Length - 1; j++)
                {
                    no1 = no2[j].ToString();
                    no2[i] = no2[j + 1];
                    no2[i + 1] = no1;

                    for (int k= 0; k < no2.Length; k++)
                    {
                        Console.WriteLine("ARray Combination is:" + no2[k].ToString());
                    }
                }
            }
        }
        public void checkcircularqueue(string no)
        {
           
            count = 0;
            temp=Convert.ToInt32(no);
            for (i = 2; i < temp; i++)
            {
                if(temp%i==0)
                {
                    count++;
                }

            }
            if (count == 0)
            {

                Console.WriteLine("PrimeN0"+temp);
               
                while(j<no2.Length)
                {
                    for (k = 0; k <=j; k++)
                    {
                        no1 = no2[k].ToString();
                        no2[k] = no2[j].ToString();
                        no2[j] = no1;
                    }
                    no1 = string.Empty;
                    for (i = 0; i < no2.Length; i++)
                    {
                        no1 += no2[i].ToString();
                    }
                    
                    checkcircularqueue(no1);
                    j++;
                }

            }

        }
        public static void Main()
        {
            pushpendra obj = new pushpendra();
            obj.input();
            Console.ReadKey();
        }
    }
}
