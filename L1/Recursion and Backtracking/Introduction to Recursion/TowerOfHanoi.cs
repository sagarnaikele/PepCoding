//tower 1 is source, tower 2 is target and 3rd is auxilary tower, disks are number of disks to move

public class TowerOfHanoi
{
    public static void Main()
    {
        TOH(disks=3, 'A', 'B', 'C');

    }
        TOH(int disks, char A, char B, char C)
        {
            if (disks==0)
            {
                return;
            }
            TOH(disks-1,A,C,B);
            Console.WriteLine(A+"->"+B);
            TOH(disks-1,C,B,A);
        }
}

