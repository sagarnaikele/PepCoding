using System;
using System.Linq;
using System.Collections.Generic;



public class PrefixConversion
{

    public static void Main()
    {
        string str = "-+2/*6483";
        ConvertPrefix(str);

    }

    public static void ConvertPrefix(string str)
    {
        Stack<String> postStk = new Stack<string>();
        Stack<String> infixStk = new Stack<string>();
        Stack<int> valStk = new Stack<int>();

        for (int i = str.Length - 1; i >= 0; i--)
        {

            if (str[i] >= '0' && str[i] <= '9')
            {
                valStk.Push(str[i] - '0');
                postStk.Push(str[i] + "");
                infixStk.Push(str[i] + "");
            }
            else
            {
                int val1 = valStk.Pop();
                int val2 = valStk.Pop();
                valStk.Push(Calculate(val1, val2, str[i]));

                string postval1 = postStk.Pop();
                string postval2 = postStk.Pop();
                postStk.Push(postval1 + postval2 + str[i]);

                string inval1 = infixStk.Pop();
                string inval2 = infixStk.Pop();
                infixStk.Push('(' + inval1 + str[i] + inval2 + ')');
            }
        }

        Console.WriteLine(valStk.Peek());
        Console.WriteLine(postStk.Peek());
        Console.WriteLine(infixStk.Peek());
    }

    public static int Calculate(int val1, int val2, char ope)
    {
        int ans = 0;
        switch (ope)
        {
            case '+':
                ans = val1 + val2;
                break;
            case '-':
                ans = val1 - val2;
                break;
            case '*':
                ans = val1 * val2;
                break;
            case '/':
                ans = val1 / val2;
                break;
            default:
                break;
        }
        return ans;
    }
}