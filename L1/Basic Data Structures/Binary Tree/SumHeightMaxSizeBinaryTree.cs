using System;
using System.Collections.Generic;


public class Node
{
    public int data;
    public Node left;
    public Node right;
}

public class Mover
{
    public int Sum;
    public int Max = int.MinValue;
    public int Height;
    public int Size;
}


public static class SumHeightMaxSizeBinaryTree
{
    public static void Main()
    {
        int[] arr = new int[] { 50, 25, 12, -1, -1, 37, 30, -1, -1, -1, 75, 62, -1, 70, -1, -1, 87, -1, -1 };
        var tree = ConstrunctTree(arr);
        Display(tree);

    }

    public static int Height(Node node)
    {
        if (node == null) return -1; // in terms of edges in terms of node this return should be zero

        int leftDepth = Height(node.left);
        int rightDepth = Height(node.right);
        return (Math.Max(leftDepth, rightDepth) + 1);

    }
    public static int Sum(Node node)
    {
        return (node == null ? 0 : (Sum(node.left) + Sum(node.right) + node.data));
    }
    public static int Max(Node node)
    {
        if (node == null) return int.MinValue;
        int leftMax = Max(node.left);
        int rightMax = Max(node.right);
        return Math.Max(node.data, Math.Max(leftMax, rightMax));

    }
    public static int Size(Node node)
    {
        return (node == null ? 0 : Size(node.left) + Size(node.right) + 1);

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


    public static void Display(Node node)
    {

        if (node == null) return;
        string str = "<-- " + node.data + " -->";
        string left = node.left != null ? node.left.data.ToString() : ".";
        string right = node.right != null ? node.right.data.ToString() : ".";
        Console.WriteLine(left + str + right);
        Display(node.left);
        Display(node.right);
    }
}