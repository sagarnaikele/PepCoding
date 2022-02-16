using System;
using System.Linq;
using System.Collections.Generic;



public class Infix
{
    public static int SolveInfix(string expression)
    {

        Stack<int> valStack = new Stack<int>();
        Stack<char> operatorStack = new Stack<char>();

        string operators = new Char { '+', '-', '*', '/', '(', ')' };

        for (int i = 0; i < expression.Length; i++)
        {
            if (operators.Contains(expression[i]))  // check is it operator?
            {
                operatorStack.Push(expression[i]);
                if (expression[i] == ')')  // if closing bracket then evaluate stack until reach to 1st opening bracket
                {
                    while (operatorStack.Peek() != '(')
                    {
                        InfixEvaluation(valStack, operatorStack);
                    }
                }
                else if (operatorStack.Count() > 0) // if not closing bracket then check for precedence
                {
                    while (ShouldProcessStack(operatorStack.Peek(), expression[i]))
                    {
                        InfixEvaluation(valStack, operatorStack);

                    }
                    operatorStack.Push(expression[i]);  // finally push current operator
                }
                else
                {
                    operatorStack.Push(expression[i]); // if stack is empty push operator directly
                }
            }
            else
            {
                valStack.Push(expression[i]);  // push digit
            }
        }

        while (operatorStack.Count() > 0)
        {
            InfixEvaluation(valStack, operatorStack);
        }
        return valStack.Peek();
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