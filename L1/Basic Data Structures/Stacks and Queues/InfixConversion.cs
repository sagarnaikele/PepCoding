using System;
using System.Linq;
using System.Collections.Generic;



public class InfixConversion
{
    public static int SolveInfix(string expression)
    {

        return 0;
    }

    public int Calculate(int val1, int val2, char ope)
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

    public static bool ShouldProcessStack(char stkOp, char op)
    {
        if ((stkOp == '+' || stkOp == '-') && (op == '*' || op == '/'))
        {
            // stack has less priority
            return false;

        }
        else if ((stkOp == '*' || stkOp == '/') && (op == '+' || op == '-'))
        {
            // stack has higher priority
            return true;
        }
        else
        {
            return true;
        }
    }

    public static int InfixEvaluation(Stack<int> valStack, Stack<char> operatorStack)
    {
        var val2 = valStack.Pop();
        var val1 = valStack.Pop();
        var oper = operatorStack.Pop();
        int ans = Calculate(val1, val2, oper);
        valStack.Push(ans);
    }
}