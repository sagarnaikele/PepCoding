
namespace BinarySearchTreeRequiredModule
{


    public class Node
    {
        public int data;
        public Node Left;
        public Node Right;
    }

    public class BinarySearchTreeBase
    {
        int[] arr = new int[] { 50, 25, 12, -1, -1, 37, 30, -1, -1, -1, 75, 62, -1, 70, -1, -1, 87, -1, -1 };
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
        public static Node Construct(int start = 0, int end = arr.Length)
        {
            if (start > end) return null;

            int mid = start + ((end - start) / 2);

            Node root = new Node();
            root.data = arr[mid];
            root.left = Construct(arr, start, mid);
            root.right = Construct(arr, mid + 1, end);

            return root;
        }
    }
}