using System;
using System.Linq;


public static class MergeTwoSortedArray
{


    public static void Main()
    {
        var arr1 = Console.ReadLine().Split(new[] { ' ' }).Select(e => Convert.ToInt32(e));
        var arr2 = Console.ReadLine().Split(new[] { ' ' }).Select(e => Convert.ToInt32(e));
        foreach (var item in MergeArray(arr1.ToArray(), arr2.ToArray()))
        {
            Console.Write(item + " ");
        }
    }
    private static int[] MergeArray(int[] leftArray, int[] rightArray)
    {

        int[] result = new int[leftArray.Length + rightArray.Length];

        int leftIdx = 0;
        int rightIdx = 0;
        int resultIndex = 0;

        while (leftIdx != leftArray.Length && rightIdx != rightArray.Length)
        {
            if (leftArray[leftIdx] < rightArray[rightIdx])
            {
                result[resultIndex] = leftArray[leftIdx];
                leftIdx++;
            }
            else
            {
                result[resultIndex] = rightArray[rightIdx];
                rightIdx++;
            }
            resultIndex++;
        }

        while (leftIdx != leftArray.Length)
        {
            result[resultIndex] = leftArray[leftIdx];
            leftIdx++;
            resultIndex++;
        }
        while (rightIdx != rightArray.Length)
        {
            result[resultIndex] = rightArray[rightIdx];
            rightIdx++;
            resultIndex++;
        }
        return result;
    }

}