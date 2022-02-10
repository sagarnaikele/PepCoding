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

// creating mover class for approach 2
public class DiameterMover
{
    public int Diameter;
}

// creating mover class for approach 4
public class BSTPair
{
    public int Min = Int32.MaxValue;
    public int Max = Int32.MinValue;
    public bool IsBST = true;
}


public static class IsBinarySearchTree
{
    public static void Main()
    {
        int[] arr = new int[] { 50, 25, 12, -1, -1, 37, 30, -1, -1, -1, 75, 62, -1, 70, -1, -1, 87, -1, -1 };
        var tree = ConstrunctTree(arr);


        Console.WriteLine("-------------Approach 1-----------------");
        Diameter1(tree);
        Console.WriteLine(diameter);
        Console.WriteLine("-------------Approach 2-----------------");
        DiameterMover dm = new DiameterMover();
        Diameter2(tree, dm);
        Console.WriteLine(dm.Diameter);
        Console.WriteLine("-------------Approach 3-----------------");
        Console.WriteLine(Diameter1(tree));
        Console.WriteLine("-------------Approach 4-----------------");
        var res = Diameter4(tree);
        Console.WriteLine(res.Diameter);
    }


    #region Diameter Approach 1 and 2


    // create varaible in stack for approach 1
    public static int diameter;

    public static bool IsBalanced(Node node)
    {
        if (node == null || (node.left == null && node.right = null)) return true;
        else if (node.left == null || node.right = null) return false;
        return node.left.data < node.data && node.right.data < node.data && IsBalanced(node.left) && IsBalanced(node.right);
    }
    public static int Diameter2(Node node, DiameterMover dm)
    {
        if (node == null) return -1;

        int lHeight = Diameter2(node.left, dm);
        int rHeight = Diameter2(node.right, dm);

        int rootHeight = Math.Max(lHeight, rHeight) + 1;

        int currDiameter = lHeight + rHeight + 2;
        dm.Diameter = currDiameter > dm.Diameter ? currDiameter : dm.Diameter;
        return rootHeight;
    }

    #endregion


    public static DiaPair Diameter4(Node node)
    {
        if (node == null)
        {
            DiaPair d = new DiaPair();
            return d;

        }


        DiaPair leftPair = Diameter4(node.left);
        DiaPair rightPair = Diameter4(node.right);


        DiaPair dpRoot = new DiaPair();
        dpRoot.Height = Math.Max(leftPair.Height, rightPair.Height) + 1;
        dpRoot.Diameter = Math.Max(leftPair.Height + rightPair.Height + 2, Math.Max(rightPair.Diameter, leftPair.Diameter));
        return dpRoot;
    }

    public static Node ToNormal(Node node)
    {
        if (node == null)
            return node;

        Node left = ToNormal(node.left.left);
        Node right = ToNormal(node.right);

        node.left = left;
        return node;
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

