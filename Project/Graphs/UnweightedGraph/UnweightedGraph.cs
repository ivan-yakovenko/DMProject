using System;
using System.Collections.Generic;

namespace Project.Graphs
{
    internal class UnweightedGraph : SimpleGraph<int>
    {
        public UnweightedGraph(int vertices) : base(vertices)
        {
        }

        public override void AddVertex()
        {
            int vertices = Size + 1;
            int[,] newMatrix = new int[vertices, vertices];
            
            Array.Copy(AdjacencyMatrix, newMatrix, AdjacencyMatrix.Length);
            AdjacencyMatrix = newMatrix;
            
            AdjacencyList.Add(new List<int>());
        }

        public override void AddEdge(int startVertex, int endVertex, int weight = 1)
        {
            AdjacencyList[startVertex].Add(endVertex);
            AdjacencyList[endVertex].Add(startVertex);

            AdjacencyMatrix[startVertex, endVertex] = 1;
            AdjacencyMatrix[endVertex, startVertex] = 1;

        }

        public override void RemoveEdge(int startVertex, int endVertex)
        {
            AdjacencyList[startVertex].Remove(endVertex);
            AdjacencyList[endVertex].Remove(startVertex);

            AdjacencyMatrix[startVertex, endVertex] = 0;
            AdjacencyMatrix[endVertex, startVertex] = 0;
            
        }
        
        public void PrintList()
        {
            Console.WriteLine("Adjacency List:");
            for (int i = 0; i < AdjacencyList.Count; i++)
            {
                Console.Write($"{i}: ");
                foreach (var item in AdjacencyList[i])
                {
                    Console.Write($"{item}, ");
                }
                Console.WriteLine();
            }
        }
    }
}