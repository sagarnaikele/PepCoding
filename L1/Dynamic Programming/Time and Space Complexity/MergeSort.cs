using System;
using System.Linq;

public static class MergeSort
{

    public static void Main()
    {
        var arr1 = Console.ReadLine().Split(new char[] { ' ' }).Select(e => Convert.ToInt32(e)).ToArray();
        foreach (var item in arr1)
        {
            Console.Write(item + " ");
        }
        foreach (var item in DivideArrayUntilSort(arr1, 0, arr1.Length - 1))
        {
            Console.Write(item + " ");
        }

    }


    public static int[] DivideArrayUntilSort(int[] arr, int start, int end)
    {
        if (start == end)
        {
            return new int[] { arr[start] };
        }
        int mid = start + (end - start) / 2;
        int[] left = DivideArrayUntilSort(arr, start, mid);
        int[] right = DivideArrayUntilSort(arr, mid + 1, end);
        return MergeTwoSortedArray(left, right);
    }

    private static int[] MergeTwoSortedArray(int[] leftArr, int[] rightArr)
    {

        int[] reuslt = new int[leftArr.Length + rightArr.Length];
        int l = 0, r = 0, res = 0;
        while (l != leftArr.Length && r != rightArr.Length)
        {
            if (leftArr[l] < rightArr[r])
            {
                reuslt[res] = leftArr[l];
                l++;
            }
            else
            {
                reuslt[res] = rightArr[r];
                r++;
            }
            res++;
        }
        while (l != leftArr.Length)
        {
            reuslt[res] = leftArr[l];
            l++; res++;
        }
        while (r != rightArr.Length)
        {
            reuslt[res] = rightArr[r];
            r++;
            res++;
        }
        return reuslt;
    }

}