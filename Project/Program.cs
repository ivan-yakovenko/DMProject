using System.Diagnostics;
using System.Drawing;
using Project.Algorithms;

namespace Project.Graphs
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] probabilities = [ 0.4, 0.6, 0.7, 0.8, 0.9 ];
            int[] vertices = [ 20, 35, 40, 50, 60, 70, 100, 105, 120, 140 ];

            foreach (var vertice in vertices)
            {
                foreach (var probability in probabilities)
                {

                    double dfsTime = 0;
                    for (int i = 0; i < 100; i++)
                    {
                        UnweightedGraph<int> graph = new UnweightedGraph<int>(vertice);
                        GraphGenerator.GenerateGraph(graph, probability);
                        var stopwatch = new Stopwatch();
                        stopwatch.Start();
                        DFS.DFSUse(graph, 0);
                        stopwatch.Stop();
                        dfsTime += stopwatch.Elapsed.TotalMilliseconds;
                    }

                    double avgDFSTime = dfsTime / 100;
                    
                    Console.WriteLine($"Vertices: {vertice}, Probability: {probability}, DFS avg time: {avgDFSTime} ms");
                    
                    double bfsTime = 0;
                    for (int i = 0; i < 100; i++)
                    {
                        UnweightedGraph<int> graph = new UnweightedGraph<int>(vertice);
                        GraphGenerator.GenerateGraph(graph, probability);
                        var stopwatch = new Stopwatch();
                        stopwatch.Start();
                        BFS.BFSUse(graph, 0);
                        stopwatch.Stop();
                        bfsTime += stopwatch.Elapsed.TotalMilliseconds;
                    }

                    double avgBFSTime = bfsTime / 100;
                    
                    Console.WriteLine($"Vertices: {vertice}, Probability: {probability}, BFS avg time: {avgBFSTime} ms");
                    
                    
                    
                }
            }
            
        }
    }
}