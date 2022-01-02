using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    public class b:c
    {
       public b()
        {
            Console.WriteLine("public consrucor B called");
            
        }

        static b()
        {
            Console.WriteLine("Static constructor B called");
           
        }
        
    }
        public class a:b
        {
            static a()
            {
                Console.WriteLine("Static a claled");

            }
            public a()
            {
                Console.WriteLine("public a claled");

            }
            static void Main()
            {
                a obj = new a();
                Console.Read();
            }

        }

    public class c
     {
         static c()
         {
             Console.WriteLine("Static c claled");

         }
         public c()
         {
             Console.WriteLine("public c claled");

         }
        

     }
    //class c:a
    //{
    //    int c()
    //    {
    //        Console.WriteLine("public consrucor B called");
    //        return 0;
    //    }

    //    static int c()
    //    {
    //        Console.WriteLine("Static constructor B called");
    //        return 0;
    //    }
    //}
}
