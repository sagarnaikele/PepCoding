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


public class IsGenericTreeSymetric
{

    public static void Main()
    {
        var node1 = ConstructTree();
        var node2 = ConstructTree();
        LevelOrderByLevel(node);
        Console.WriteLine(AreTreeSame(node1, node2));

        foreach (var item in FindReturnPath(node, 90))
        {
            Console.Write(item + "==>");
        }

    }

    public static bool IsSymetricBetter(Node node)
    {
        return AreTreeSame(node, node);
    }


    public static bool AreTreeSame(Node node1, Node node2)
    {
        if (node1.Childrens.Count() != node2.Childrens.Count())
        {
            return false;
        }
        for (int i = 0; i < node1.Childrens.Count(); i++)
        {
            var c1 = node1.Childrens.IndexOf(i);
            var c2 = node2.Childrens.IndexOf(i);
            if (!AreTreeSame(c1, c2))
            {
                return false;
            }

        }
        return true;

    }

    public static bool IsSymetric(Node node)
    {
        if (node.Childrens.Count() <= 1)
        {
            return true;
        }
        int start = 0, end = node.Childrens.Count() - 1;

        while (start <= end)
        {
            var leftChild = node.Childrens.IndexOf(start);
            var rightChild = node.Childrens.IndexOf(end);

            if (leftChild.Childrens.Count() != rightChild.Childrens.Count())
            {
                return false;
            }
            start++;
            end--;
        }
        foreach (var child in node.Childrens)
        {
            if (!IsSymetric(child))
            {
                return false;
            }
        }
        return true;

    }


    /// Node to root path
    public static List<int> FindReturnPath(Node node, int val)
    {

        List<int> foundlist = new List<int>();
        if (node.data == val)
        {

            foundlist.Add(node.data);
            return foundlist;
        }
        foreach (var child in node.Childrens)
        {
            var found = FindReturnPath(child, val);
            if (found.Count() > 0)
            {
                foundlist = found;
                foundlist.Add(node.data);
                return foundlist;
            }
        }
        return foundlist;

    }





    // 10 20 30 40 50 60 70 80 90 100 110 120

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