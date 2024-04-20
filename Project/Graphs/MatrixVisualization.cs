using System;
using Project.Graphs;

namespace Project.Graphs
{
    public static class MatrixVisualization
    {
        public static void PrintMatrix<T>(SimpleGraph<T> graph)
        {
            Console.WriteLine("Adjacency Matrix:");
            for (int i = 0; i < graph.Size; i++)
            {
                for (int j = 0; j < graph.Size; j++)
                {
                    Console.Write(graph.AdjacencyMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}