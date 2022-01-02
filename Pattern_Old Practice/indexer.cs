using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
namespace Pattern
{
    class indexer
    {
        public readonly static string i = "hello";
        public readonly string s;
        static indexer()
        {
            i = "he"; 
           
        }
        public indexer()
        {
            s = "hefd";
        }
        public  void disp()
        {
            Console.Write(i);
            
            //dynamic v;
            //v = "ankita";
            //v++;
        }

        static void Main(string [] str)
        {
            indexer obj = new indexer();
        }
        //static virtual void Main(string[]str)
        //{
        //    indexer obj = new indexer();
        //    Console.Write("fasd");
        //}
      //  static void Main(string[] args);
    }

}
