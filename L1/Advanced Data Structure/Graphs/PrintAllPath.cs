using System;
using System.Collections.Generic;
using System.Linq;
using GraphDependency;

namespace GraphDependency_PrintAllPath
{
    public class PrintAllPath
    {
        public static void Main()
        {
            var graph = Graph.Construct();
            Print(graph, new bool[graph.Count()], 0, 6);
        }


        public static void Print(List<Edge>[] graph, bool[] visted, int src, int dest, string psf)
        {
            if (graph.Count() == 0) return;

            if (src == dest)
            {
                Console.WriteLine(psf + src.ToString());
                return;
            }
            visted[src] = true;

            for (int i = 0; i < graph[src].Count(); i++)
            {
                GraphDependency.GraphEdge edge = graph[src].ElementAt(i);
                int nbr = edge.Neighbour;

                if (!visted[nbr])
                    Print(graph, visted, nbr, dest, psf + src.ToString());
            }
        }
    }
}