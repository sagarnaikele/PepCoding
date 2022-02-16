using System;
using System.Linq;
using System.Collections.Generic;



public class PostfixConversion
{

    public static void Main()
    {
        string str = "264*8/+3-";
        ConvertPostfix(str);

    }

    public static void ConvertPostfix(string str)
    {
        Stack<String> preStk = new Stack<string>();
        Stack<String> infixStk = new Stack<string>();
        Stack<int> valStk = new Stack<int>();

        for (int i = 0; i < str.Length; i++)
        {

            if (str[i] >= '0' && str[i] <= '9')
            {
                valStk.Push(str[i] - '0');
                preStk.Push(str[i] + "");
                infixStk.Push(str[i] + "");
            }
            else
            {
                int val2 = valStk.Pop();
                int val1 = valStk.Pop();
                valStk.Push(Calculate(val1, val2, str[i]));

                string preval2 = preStk.Pop();
                string preval1 = preStk.Pop();
                preStk.Push(str[i] + preval1 + preval2);

                string inval2 = infixStk.Pop();
                string inval1 = infixStk.Pop();
                infixStk.Push('(' + inval1 + str[i] + inval2 + ')');
            }
        }

        Console.WriteLine(valStk.Peek());
        Console.WriteLine(preStk.Peek());
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