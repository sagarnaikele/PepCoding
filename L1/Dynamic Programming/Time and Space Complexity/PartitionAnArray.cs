using System;


public class PartitionAnArray
{


    public static void Main()
    {
        int[] arr = new int[] { 7, -2, 4, 1, 3, 2 };
        int pivot = 3;

        Partition(arr, pivot);
        Print(arr);

    }

    public static void Partition(int[] arr, int pivot)
    {
        // partition array in 2 parts
        // left side will be less than or equal to pivot
        // right side will be greater than pivot
        // input   7 -2 4 1 3 2
        // output  left side [-2 1 3 2] [4 7] <----- right side
        int i = 0, j = 0;
        while (i < arr.Length)
        {
            if (arr[i] <= pivot)
            {
                Swap(arr, i, j);
                j++;
            }
            i++;
        }

    }

    public static void Swap(int[] arr, int i, int j)
    {
        Console.WriteLine("Swapping " + arr[i] + " and " + arr[j]);
        int holdRelease = arr[i];
        arr[i] = arr[j];
        arr[j] = holdRelease;
    }

    public static void Print(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}
