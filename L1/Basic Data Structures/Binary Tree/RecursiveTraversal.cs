using System;
using System.Collections.Generic;
using System.Text;


public class Node
{
    public int data;
    public Node left;
    public Node right;
}

public class Pair
{
    public int state;
    public Node node;
}


public static class RecursiveTraversal
{
    public static void Main()
    {
        int[] arr = new int[] { 50, 25, 12, -1, -1, 37, 30, -1, -1, -1, 75, 62, -1, 70, -1, -1, 87, -1, -1 };
        var tree = ConstrunctTree(arr);
        Console.WriteLine("-------------Pre---------------------");
        PrintPreOrder(tree);
        Console.WriteLine("-------------In---------------------");
        PrintInorder(tree);
        Console.WriteLine("-------------Post---------------------");
        PrintPostOrder(tree);

        Console.WriteLine("-------------Iterative---------------------");
        Iterative(tree);

    }


    public static void PrintInorder(Node node)
    {
        if (node == null) return;

        PrintInorder(node.left);
        Console.Write(node.data + " ");
        PrintInorder(node.right);
    }
    public static void PrintPreOrder(Node node)
    {
        if (node == null) return;
        Console.Write(node.data + " ");
        PrintPreOrder(node.left);
        PrintPreOrder(node.right);
    }
    public static void PrintPostOrder(Node node)
    {
        if (node == null) return;

        PrintPostOrder(node.left);
        PrintPostOrder(node.right);
        Console.Write(node.data + " ");
    }
    public static void Iterative(Node root)
    {
        Stack<Pair> stk = new Stack<Pair>();

        Pair p = new Pair();
        p.node = root;
        p.state = 1;

        stk.Push(p);

        StringBuilder pre = new StringBuilder();
        StringBuilder inorder = new StringBuilder();
        StringBuilder postorder = new StringBuilder();

        while (stk.Count > 0)
        {
            var peek = stk.Peek();
            if (peek.state == 1)
            {
                pre.Append(peek.node.data.ToString() + " ");
                peek.state++;
                if (peek.node.left != null)
                {
                    Pair leftp = new Pair();
                    leftp.node = peek.node.left;
                    leftp.state = 1;
                    stk.Push(leftp);
                }


            }
            else if (peek.state == 2)
            {
                inorder.Append(peek.node.data.ToString() + " ");
                peek.state++;
                if (peek.node.right != null)
                {
                    Pair rightp = new Pair();
                    rightp.node = peek.node.right;
                    rightp.state = 1;
                    stk.Push(rightp);
                }
            }
            else
            {
                postorder.Append(peek.node.data.ToString() + " ");
                stk.Pop();
            }
        }

        Console.WriteLine(pre.ToString());
        Console.WriteLine(inorder.ToString());
        Console.WriteLine(postorder.ToString());
    }





    public static Node ConstrunctTree(int[] arr)
    {
        // create stack which will store pair of node with state
        // state 1 = add child to left, 
        // state 2= add child to right, 
        // state 3 = remove pair from stack means go back to parent
        Stack<Pair> stack = new Stack<Pair>();

        // create root node with 1st value of array
        Node root = new Node();
        root.data = arr[0];

        // create pair from root  with default state 1 and push that to stack
        Pair pair = new Pair();
        pair.state = 1;
        pair.node = root;

        stack.Push(pair);
        // for looping over array maintain index
        int idx = 1;

        // loop until stack is empty
        while (stack.Count > 0)
        {
            Pair peekPair = stack.Peek(); // get peek item from stack to which left or right child will be linked based on state value

            if (peekPair.state == 1) // if state is 1 and current array value is not null then add new node to left child off peek node
            {

                if (arr[idx] != -1)
                {
                    Node leftNode = new Node();
                    leftNode.data = arr[idx];
                    peekPair.node.left = leftNode;

                    Pair leftPair = new Pair();
                    leftPair.node = leftNode;
                    leftPair.state = 1;
                    stack.Push(leftPair);
                }
                idx++; // move pointer to next element
                peekPair.state++; // increase state of node by 1 which will indicate that next element should be added to right child
            }
            else if (peekPair.state == 2) // repeat all process for right  element
            {

                if (arr[idx] != -1)
                {
                    Node rightNode = new Node();
                    rightNode.data = arr[idx];
                    peekPair.node.right = rightNode;

                    Pair rightPair = new Pair();
                    rightPair.node = rightNode;
                    rightPair.state = 1;
                    stack.Push(rightPair);
                }
                idx++;
                peekPair.state++;
            }
            else
            {
                stack.Pop(); // if state is 3 means there is no right or left child or those are alredy attached to parent node so remove pair from stack
            }
        }
        return root;
    }
}

