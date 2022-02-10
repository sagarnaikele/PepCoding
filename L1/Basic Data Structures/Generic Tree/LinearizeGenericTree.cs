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


public class LinearizeGenericTree
{

    public static void Main()
    {
        var node = ConstructTree();
        Console.WriteLine("-------------------Input-------------");
        LevelOrderByLevel(node);
        LinearizeSelf(node);
        Console.WriteLine("-------------------Self--------------");
        LevelOrderByLevel(node);


        Linearize(node);
        Console.WriteLine("---------Efficient Way O(n)----------");
        LevelOrderByLevel(node);

    }

    public static Node Linearize(Node node)
    {
        if (node.Childrens.Count() == 0)
            return node;

        Node lastChild = node.Childrens.ElementAt(node.Childrens.Count - 1);
        Node lastTail = Linearize(lastChild);

        while (node.Childrens.Count() > 1)
        {
            Node secondLastChild = node.Childrens.ElementAt(node.Childrens.Count - 2);
            Node slastTail = Linearize(secondLastChild);
            slastTail.Childrens.Add(lastChild);
            node.Childrens.RemoveAt(node.Childrens.Count - 1);
            lastChild = secondLastChild;
        }
        return lastTail;

    }



    public static void LinearizeSelf(Node node)
    {

        //loop through number of child
        for (int i = 1; i <= node.Childrens.Count() - 1; i++)
        {
            node.Childrens[0].Childrens.Add(node.Childrens[i]);
        }

        for (int i = node.Childrens.Count() - 1; i > 0; i--)
        {
            node.Childrens.RemoveAt(i);
        }

        foreach (var child in node.Childrens)
        {
            LinearizeSelf(child);
        }

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