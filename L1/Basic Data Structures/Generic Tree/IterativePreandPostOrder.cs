using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

public class Node
{
    public int data { get; set; }
    public List<Node> Childrens = new List<Node>();

    public Node(int data)
    {
        this.data = data;
    }
}

public class Pair
{
    public int state { get; set; }
    public Node node;
}


public class IterativePreandPostOrder
{

    public static void Main()
    {
        var node = ConstructTree();
        LevelOrderByLevel(node);

        PrintIterativePreandPostOrder(node);
        PrintIterativePreAndPostOrder_SelfTry(node);

    }

    public static void PrintIterativePreandPostOrder(Node root)
    {

        String preorder = "";
        String postorder = "";
        Stack<Pair> stack = new Stack<Pair>();

        Pair rootp = new Pair();
        rootp.state = -1;
        rootp.node = root;

        stack.Push(rootp);
        while (stack.Count() > 0)
        {

            Pair peekp = stack.Peek();
            if (peekp.state == -1)
            {
                preorder += peekp.node.data + ", ";
                peekp.state++;
            }

            else if (peekp.state >= 0 && peekp.state < peekp.node.Childrens.Count())
            {
                Pair childp = new Pair();
                childp.state = -1;
                childp.node = peekp.node.Childrens.ElementAt(peekp.state);
                stack.Push(childp);
                peekp.state++;
            }
            else if (peekp.state == peekp.node.Childrens.Count())
            {
                postorder += peekp.node.data + ", ";
                peekp.state++;
            }
            else
            {
                stack.Pop();
            }
        }
        Console.WriteLine(preorder);
        Console.WriteLine(postorder);
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

    private static void PrintIterativePreAndPostOrder_SelfTry(Node root)
    {
        // To solve this we need to maintain state to identify the number of child at each node
        // Create class which will have node and state as properties
        // use stack to visit nodes in generic tree and maintaining states
        // run while loop until there are nodes in stack
        // whole idea is to create recursion using stack in while loop
        // add default entry in the stack for the root with state -1
        // -1 means did not visited any child yet
        // check if there is any child present for the node is yes then get peek element 
        // of stack and increase its state by 1
        // also create stack entry for child and insert into stack
        // -1 means node is visited in preorder and state == child count means its post order
        // if peek node state is greater than number of child po the element from stack 
        // if state is between -1 to child count it means there are more child to visit hence add entry in stack for same

        Pair stateHolder = new Pair();
        stateHolder.node = root;
        stateHolder.state = -1;

        Stack<Pair> stateStack = new Stack<Pair>();
        stateStack.Push(stateHolder);

        StringBuilder preOrder = new StringBuilder();
        StringBuilder postOrder = new StringBuilder();

        while (stateStack.Count > 0)
        {
            var peek = stateStack.Peek();
            if (peek.state == -1)
            {
                //-1 means did not visited any child yet and it will be preorder
                preOrder.Append(peek.node.data.ToString() + ", ");
                peek.state++;
            }
            else if (peek.state >= 0 && peek.state < peek.node.Childrens.Count())
            {
                // add child entry to stack
                var pair = new Pair();
                pair.node = peek.node.Childrens.ElementAt(peek.state);
                pair.state = -1;
                peek.state++;
                stateStack.Push(pair);

            }
            else if (peek.state == peek.node.Childrens.Count())
            {
                // state == child count means its post order way back to root
                postOrder.Append(peek.node.data.ToString() + ", ");
                peek.state++;

                // delete here as peek.state++ in this block make state greater than size of childs
                stateStack.Pop();
            }
            //else
            //  {
            // all childs are visited so delete stack peek
            // this logic can be written in above peek.state == peek.node.Childrens.Count() is block as 
            // all child are visited above only
            //stateStack.Pop();
            //  }
        }
        // Print output
        Console.WriteLine(preOrder.ToString());
        Console.WriteLine(postOrder.ToString());
    }
}