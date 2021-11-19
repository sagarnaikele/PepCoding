// Sample Input
// 3
// Sample Output
// 3 2 1 1 1 2 1 1 1 2 3 2 1 1 1 2 1 1 1 2 3
using System;
public class PrintZigZag_211121112
{
    public static void Main()
    {
        Print(3);

    }
        public static void Print(int num)
        {
            if (num==0)
            {
                return;
            }
            Console.Write(num); ///3
            Print(num-1); //21112
            Console.Write(num);
            Print(num-1);
            Console.Write(num);
        }
}

