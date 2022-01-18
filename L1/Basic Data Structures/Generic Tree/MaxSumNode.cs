using System;
using System.Linq;
using System.Collections.Generic;


public class Node
{
    public int data { get; set; }
    public List<Node> Childrens = new List<Node>();

    public Node(int data)
    {
        this.data = data;
    }
}

public class Mover
{
    public int maxSum = int.MinValue;
    public Node maxSumNode;
}


public class MaxSumNode
{

    public static void Main()
    {
        var node = ConstructTree();
        LevelOrderByLevel(node);
        Mover mover = new Mover();
        FindMaxSumNode(node, mover);

        Console.WriteLine("maxSum " + mover.maxSum);
        Console.WriteLine("node " + mover.maxSumNode.data);

    }
    public static int FindMaxSumNode(Node node, Mover mover)
    {
        int sumtillNow = 0;

        foreach (var child in node.Childrens)
        {
            sumtillNow += FindMaxSumNode(child, mover);
        }
        sumtillNow += node.data;
        if (mover.maxSum < temp)
        {
            mover.maxSum = temp;
            mover.maxSumNode = node;
        }
        return sumtillNow;


    }







    // 10 20 30 40 50 60 70 80 90 100 110 120

    public static Node ConstructTree()
    {
        var arr = new int[] { 10, 20, -50, -1, 60, -1, -1, 30, -70, -1, 80, -1, 90, -1, -1,
         40, -100, -1, -1, -1 };


        Stack<Node> myStk = new Stack<Node>();
        Node root = null;
        for (int i = 0; i < arr.Length; i++)
        {

            if (arr[i] != -1)
            {
                myStk.Push(new Node(arr[i]));
            }
            else
            {
                var childNode = myStk.Pop();

                if (myStk.Count() > 0)
                {
                    var parentNode = myStk.Peek();
                    parentNode.Childrens.Add(childNode);
                }
                else
                {
                    root = childNode;
                }


            }
        }
        return root;

    }

    public static void LevelOrderByLevel(Node root)
    {

        Queue<Node> pq = new Queue<Node>();
        Queue<Node> cq = new Queue<Node>();
        pq.Enqueue(root);
        while (pq.Count() > 0)
        {
            var temp = pq.Dequeue();
            Console.Write(temp.data + " ");
            foreach (Node item in temp.Childrens)
            {
                cq.Enqueue(item);
            }
            if (pq.Count() == 0)
            {
                pq = cq;
                cq = new Queue<Node>();
                Console.WriteLine();
            }
        }
    }
}