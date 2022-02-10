using System;
using System.Collections.Generic;
using System.Linq;

namespace PriorityQueueRequired
{
    public class GetKLargeElementPriorityQueue
    {
        static void Main(string[] args)
        {
            PriorityQueue<string, int> vehicleRepairQueue = new PriorityQueue<string, int>();
            vehicleRepairQueue.Enqueue("Mirror Damaged Car", 3);
            vehicleRepairQueue.Enqueue("Wash Car", 10);
            vehicleRepairQueue.Enqueue("Severe Damaged Car", 1);
            System.Console.WriteLine("\nVehicle Repair Queue:\n");
            while (vehicleRepairQueue.Count > 0)
            {
                System.Console.WriteLine(vehicleRepairQueue.Dequeue());
            }
        }
    }
}