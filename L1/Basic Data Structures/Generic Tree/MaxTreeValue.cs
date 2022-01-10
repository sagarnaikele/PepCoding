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


public class TreeDemo
{

    public static void MaxTreeValue()
    {

        // Node root = new Node(10);

        // Node twenty = new Node(20);
        // Node thirty = new Node(30);
        // Node fourty = new Node(40);
        // root.Childrens.AddRange(new List<Node> { twenty, thirty, fourty });


        // Node fifty = new Node(50);
        // Node sixty = new Node(60);
        // twenty.Childrens.AddRange(new List<Node> { fifty, sixty });

        // Node seventy = new Node(70);
        // Node eighty = new Node(80);
        // Node ninety = new Node(90);
        // thirty.Childrens.AddRange(new List<Node> { seventy, eighty, ninety });

        // Node hunred = new Node(100);
        // fourty.Childrens.AddRange(new List<Node> { hunred });

        // Node hunredten = new Node(110);
        // Node hunredtenty = new Node(120);
        // eighty.Childrens.AddRange(new List<Node> { hunredten, hunredtenty });

        // LevelOrder(root);
        // Console.WriteLine("---------------------------------");
        // LevelOrderByLevel(root);
        // Console.WriteLine("---------------------------------");
        //LevelOrderByLevelZigZag(root);  //Home work

        LevelOrderByLevel(ConstructTree());

    }


    // 10 20 30 40 50 60 70 80 90 100 110 120
    public static void LevelOrder(Node root)
    {

        Queue<Node> q = new Queue<Node>();
        q.Enqueue(root);
        while (q.Count() > 0)
        {
            var temp = q.Dequeue();
            Console.Write(temp.data + " ");
            foreach (Node item in temp.Childrens)
            {
                q.Enqueue(item);
            }
        }
    }


    // 10
    // 20 30 40
    // 50 60 70 80 90 100
    // 110 120
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


    public static int MaxOfTree(Node node)
    {

        int currMax = node.data;
        foreach (var item in node.Childrens)
        {
            int recMax = MaxOfTree(item);
            currMax = Math.Max(currMax, recMax);

        }
        return currMax;
    }

    public static int MinOfTree(Node node)
    {
        int minChild = node.data;
        foreach (var child in node.Childrens)
        {
            int recMin = MinOfTree(child);
            minChild = Math.Min(recMin, minChild);
        }
        return minChild;
    }

    public static Node ConstructTree()
    {
        var arr = new int[] { 10, 20, 50, -1, 60, -1, -1, 30, 70, -1, 80, 110, -1, 120, -1, -1, 90, -1, -1, 40, 100, -1, -1, -1 };


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
}