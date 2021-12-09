using System;


// This is main link list which has start node of list called Head
// and end of list called Tail
// Size is the total elements in the list
public class LinkedList
{

    public static void Main()
    {

    }


    public Node Head { get; set; }
    public Node Tail { get; set; }
    public int Size { get; set; }


    public void AddFirst(Node node)
    {

    }

    public void AddLast(Node node)
    {
        Node temp = Tail;

    }

    public void AddAt(Node node, int index)
    {

    }

    public void PrintAll()
    {
        for (Node node = this.Head; node != null; node = node.Next)
        {
            Console.Write(node.Data + ", ");
        }
    }
    public void PrintAt(int index)
    {
        if (!isValidPosition(index))
            Console.Write("Invalid Index");

        else
        {
            Node node = this.Head;
            for (int i = 1; i < index; i++)
            {
                node = node.Next;
            }
        }


    }
    public bool isValidPosition(int index)
    {
        return index >= 0 || index <= Size;
    }


}


// Node is one element of linked list which has 2 things
// data is actual data prsent at the node
// Next is the pointer to next element in the linked list from current node
public class Node
{

    public int Data { get; set; }
    public Node Next { get; set; }


}