using System;

namespace Project.Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            UnweightedGraph unweightedGraph = new UnweightedGraph(5);

            unweightedGraph.AddEdge(0, 1);
            unweightedGraph.AddEdge(0, 2);
            unweightedGraph.AddEdge(1, 3);
            unweightedGraph.AddEdge(2, 4);

            MatrixVisualization.PrintMatrix(unweightedGraph);

            unweightedGraph.PrintList();

            Console.WriteLine();

            WeightedGraph weightedGraph = new WeightedGraph(4);

            weightedGraph.AddEdge(0, 1, 5);
            weightedGraph.AddEdge(0, 2, 3);
            weightedGraph.AddEdge(1, 3, 7);
            weightedGraph.AddEdge(2, 3, 2);

            MatrixVisualization.PrintMatrix(weightedGraph);

            weightedGraph.PrintList();

            Console.ReadLine();
        }
    }
}