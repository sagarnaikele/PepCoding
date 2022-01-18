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

public class MultiSolverDto
{
    public int Sum { get; set; }
    public int Max { get; set; }
    public int Min { get; set; }
    public int height { get; set; }
    public int SecondMax { get; set; }

    public MultiSolverDto()
    {
        Sum = 0;
        Max = Int32.MinValue;
        Min = Int32.MaxValue;
        SecondMax = Int32.MinValue;
        height = -1;
    }
}


public class MultiSolver
{

    public static void Main()
    {
        var node = ConstructTree();
        LevelOrderByLevel(node);

        MultiSolverDto dto = new MultiSolverDto();
        Solve(node, 0, dto);

        Console.WriteLine("Sum " + dto.Sum);
        Console.WriteLine("Max " + dto.Max);
        Console.WriteLine("Second Max " + dto.SecondMax);
        Console.WriteLine("Min " + dto.Min);
        Console.WriteLine("Height " + dto.height);
    }

    public static void Solve(Node node, int depth, MultiSolverDto mulisolverDto)
    {

        mulisolverDto.Sum += node.data;
        if (mulisolverDto.Max < node.data)
            mulisolverDto.Max = node.data;

        else if (mulisolverDto.SecondMax <= node.data)
            mulisolverDto.SecondMax = node.data;

        if (mulisolverDto.Min > node.data)
            mulisolverDto.Min = node.data;

        if (mulisolverDto.height < depth)
            mulisolverDto.height = depth;

        foreach (var child in node.Childrens)
        {
            Solve(child, depth + 1, mulisolverDto);
        }
    }


    /// Node to root path

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