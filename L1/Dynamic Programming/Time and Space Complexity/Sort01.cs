using System;

public class SortZeroOne
{

    public static void Main()
    {
        int[] arr = new int[] { 1, 0, 1, 1, 0, 1, 0 };
        Sort01(arr);
        foreach (var num in arr)
        {
            Console.Write(num);
        }
    }

    private static void Sort01(int[] arr)
    {
        int i = 0, j = 0;

        while (i < arr.Length)
        {
            if (arr[i] == 1) i++;
            else
            {
                Swap(arr, i, j);
                i++;
                j++;
            }

        }


    }

    private static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }




}