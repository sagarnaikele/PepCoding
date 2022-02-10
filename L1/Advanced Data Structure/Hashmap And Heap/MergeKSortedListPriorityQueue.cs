using System;
using System.Collections.Generic;
using System.Linq;

namespace PriorityQueueRequired
{

  

    public class MergeKSortedListPriorityQueue
  {
        public static void Main()
        {

        }

        public static void PrintKLarge(int[] arr, int k)
        {
            PriorityQueue<int, int> pq = new PriorityQueue<int, int>();

            for (int i = 0; i < k; i++)
            {
                pq.Enqueue(arr[i]);

            }

            while (pq.Count() > 0)
            {

            }


        }
    }
}