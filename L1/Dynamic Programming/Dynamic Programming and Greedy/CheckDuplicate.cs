using System;
using System.Linq;

public class CheckDuplicate
{
    public static void Main()
    {
        var arr = Console.ReadLine().Split(new[] { ' ' }).Select(e => Convert.ToInt32(e)).ToArray();
        Console.WriteLine(FindDuplicate(arr));
    }

    public static int FindDuplicate(int[] arr)
    {
        Array.Sort(arr); //nlogn

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] == arr[i + 1])
            {
                return arr[i];
            }

        }
        return -1;
    }

}