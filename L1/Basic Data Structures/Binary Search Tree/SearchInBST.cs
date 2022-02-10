using BinarySearchTreeRequiredModule;


public class SearchInBST : BinarySearchTreeBase
{
    public static void Main()
    {
        var tree = Construct();
        Display(SearchBST(tree, 62));

    }
    public static Node SearchBST(Node root, int data)
    {
        // loop until root is null
        while (root != null)
        {
            //idea is all left element are smaller than root and right are greater
            if (root.data < data || root.data > data)
            {
                root = root.data < data ? root.right : root.left;
            }
            // if above condition fails means element is found
            else return root;
        }
        return root;
    }
}