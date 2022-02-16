using System;
using System.Linq;
using System.Collections.Generic;



public class SmallestNumberFollowingPattern
{

    public static void Main()
    {
        string str = "ddddiiii"; //543216789
        SmallestNumber(str);

    }
    //Smallest Number Following Pattern
    public static void SmallestNumber(string str)
    {
        Stack<int> pStack = new Stack<int>();
        string ans = String.Empty;
        int j = 1;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == 'd')
            {
                pStack.Push(j);
                j++;
            }
            else
            {
                pStack.Push(j);
                j++;
                while (pStack.Count() > 0)
                {
                    ans += pStack.Pop();
                }
            }
        }
        pStack.Push(j);
        while (pStack.Count() > 0)
        {
            ans += pStack.Pop();

        }



        Console.WriteLine(ans);
    }
}