using System;
using System.Collections.Generic;
using System.Linq;


// 0123456
// 012346
// 03456
// 0346

namespace GraphDependency_PrintAllPath
{
    public class PrintAllPath
    {
        public static void Main()
        {
            var graph = Construct();
            Print(graph, new bool[graph.Count()], 0, 6, 0+"");
        }


        public static void Print(List<Edge>[] graph, bool[] visted, int src, int dest, string psf)
        {
            if (src == dest)
            {
                Console.WriteLine(psf);
                return;
            }
            visted[src] = true;

            for (int i = 0; i < graph[src].Count(); i++)
            {
                Edge edge = graph[src].ElementAt(i);
                int nbr = edge.Neighbour;

                if (!visted[nbr])
                    Print(graph, visted, nbr, dest, psf + nbr.ToString());
            }
            visted[src]=false;
        }



    public static List<Edge>[] Construct()
        {
            int noOfvertices = 7;
            List<Edge>[] graph = new List<Edge>[noOfvertices];
            for (int vertices = 0; vertices < graph.Length; vertices++)
            {
                graph[vertices] = new List<Edge>();
            }

            graph[0].Add(new Edge(0, 1, 10));
            graph[0].Add(new Edge(0, 3, 40));

            graph[1].Add(new Edge(1, 0, 10));
            graph[1].Add(new Edge(1, 2, 10));

            graph[2].Add(new Edge(2, 1, 10));
            graph[2].Add(new Edge(2, 3, 10));

            graph[3].Add(new Edge(3, 2, 10));
            graph[3].Add(new Edge(3, 0, 40));
            graph[3].Add(new Edge(3, 4, 2));

            graph[4].Add(new Edge(4, 3, 2));
            graph[4].Add(new Edge(4, 5, 3));
            graph[4].Add(new Edge(4, 6, 8));

            graph[5].Add(new Edge(5, 4, 3));
            graph[5].Add(new Edge(5, 6, 3));

            graph[6].Add(new Edge(6, 5, 3));
            graph[6].Add(new Edge(6, 4, 8));

            return graph;

        }

    public class Edge
    {
        public int Source { get; set; }
        public int Neighbour { get; set; }
        public int Weight { get; set; }
        public Edge(int source, int neighbour, int weight)
        {
            Source = source;
            Neighbour = neighbour;
            Weight = weight;
        }
    }
    }
}