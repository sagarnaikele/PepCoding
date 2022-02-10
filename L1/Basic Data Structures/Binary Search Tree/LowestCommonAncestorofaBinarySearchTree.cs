using System;
using System.Linq;
using System.Collections.Generic;


public class LowestCommonAncestorofaBinarySearchTree : BinarySearchTreeBase
{
    int sum = 0;
    public static void Rwithsum(Node node)
    {
        if (node == null) return;


        Rwithsum(node.right);
        int oSum = sum;

        sum += node.data;
        node.data = oSum;
        Rwithsum(node.left);

    }

    public static void Main()
    {
        Rwithsum(node);

        Console.WriteLine(sum);

    }
}