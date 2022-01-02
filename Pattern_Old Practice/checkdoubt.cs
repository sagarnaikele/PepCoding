using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern
{
    class checkdoubt
    {
        private checkdoubt()
        {
            Console.Write("we can inherit if parameterized constructor is private");
        }
        public checkdoubt(int i)
        { }
      
    }
    class bb: checkdoubt
    {
        static void Main(string[] args)
        {
            bb obj = new bb();
            Console.Read();
        }
    }
}
