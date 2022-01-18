using System;
using System.Collections.Generic;


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


public static class LevelOrderTraversalBinaryTree
{
    public static void Main()
    {
        int[] arr = new int[] { 50, 25, 12, -1, -1, 37, 30, -1, -1, -1, 75, 62, -1, 70, -1, -1, 87, -1, -1 };
        var tree = ConstrunctTree(arr);
        Console.WriteLine("-------------Approach1---------------------");
        Approach1(tree);
        Console.WriteLine("---------------Approach2-------------------");
        Approach2(tree);
        Console.WriteLine("---------------Approach3-------------------");
        Approach3(tree);

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


    public static void Approach1(Node root)
    {
        Queue<Node> pc = new Queue<Node>();
        Queue<Node> cq = new Queue<Node>();

        pc.Enqueue(root);
        while (pc.Count > 0)
        {
            Node printThis = pc.Dequeue();

            Console.Write(printThis.data + " ");

            if (printThis.left != null) cq.Enqueue(printThis.left);
            if (printThis.right != null) cq.Enqueue(printThis.right);


            if (pc.Count == 0)
            {
                pc = cq;
                cq = new Queue<Node>();
                Console.WriteLine();
            }
        }
    }

    //https://nados.io/feed/6df62f17-b011-4deb-896b-a23d8ef268d1
    public static void Approach2(Node root)
    {
        Queue<Node> pq = new Queue<Node>();

        pq.Enqueue(root);
        while (pq.Count > 0)
        {

            int count = pq.Count;
            for (int i = 0; i < count; i++)
            {
                Node printThis = pq.Dequeue();
                Console.Write(printThis.data + " ");
                if (printThis.left != null) pq.Enqueue(printThis.left);
                if (printThis.right != null) pq.Enqueue(printThis.right);
            }
            Console.WriteLine();
        }
    }

    public static void Approach3(Node root)
    {
        Queue<Node> pq = new Queue<Node>();

        pq.Enqueue(root);

        Node delm = new Node(); // this is the marker in queue to identify level
        delm.data = -1;

        pq.Enqueue(delm);
        while (pq.Count > 0)
        {
            Node printThis = pq.Dequeue();


            if (printThis.data == -1)
            {
                if (pq.Count > 0)
                {
                    Console.WriteLine();
                    pq.Enqueue(printThis);
                }
                continue;

            }
            Console.Write(printThis.data + " ");
            if (printThis.left != null) pq.Enqueue(printThis.left);
            if (printThis.right != null) pq.Enqueue(printThis.right);
        }
        Console.WriteLine();
    }
}