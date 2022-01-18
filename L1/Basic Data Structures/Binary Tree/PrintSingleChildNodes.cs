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


public static class PrintSingleChildNodes
{
    public static void Main()
    {
        int[] arr = new int[] { 50, 25, 12, -1, -1, 37, 30, -1, -1, -1, 75, 62, -1, 70, -1, -1, 87, -1, -1 };
        var tree = ConstrunctTree(arr);
        PrintSingleChild(tree);

    }


    public static void PrintSingleChild(Node node)
    {
        if (node == null)
            return;

        PrintSingleChild(node.left);
        PrintSingleChild(node.right);

        if (node.left != null && node.right == null)
        {
            Console.WriteLine(node.data);
        }
        else if (node.left == null && node.right != null)
        {
            Console.WriteLine(node.data);
        }
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

