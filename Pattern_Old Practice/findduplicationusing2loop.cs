using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class findduplicationusing2loop
    {
        int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
            int []arr2=new int[]{4,5,6,2,8};
        public void duplication()
        {
            int j,count,flag=1,no,no1,flag1=0;
            string str1=string.Empty, str2=string.Empty;
           
          yyy:
            for(int i=0;i<5;)
           {
              
            xxx:
               for(j=0;j<5;j++)
               {
                   if (flag1 == 0)
                   {
                       str1 = arr1[i].ToString();
                       str2 = arr2[j].ToString();
                   }

                   else if (flag1 == 1)
                   {
                       str1 = arr2[i].ToString();
                       str2 = arr1[j].ToString();
                   }
               
                  
                   if(str1==str2)
                   {
                       flag=0;
                       break;
                   }

               }
               if (flag == 1)
               {
                   Console.Write(str1);
               }
               flag = 1;
               i++;
               if (i < 5)
               {

                   goto xxx;
               }
               else
               {
                   flag1 = 1;
                   goto yyy;
               }

              
           }
        }
        static void Main()
        {
            findduplicationusing2loop obj=new findduplicationusing2loop();
            obj.duplication();
            Console.ReadLine();   
        }
    }
}
