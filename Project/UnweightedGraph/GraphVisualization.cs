namespace Project.Graphs
{
    public static class GraphVisualization
    {
        public static void PrintUnweightedMatrix<T>(UnweightedGraph<T> graph)
        {
            Console.WriteLine("Adjacency Matrix (Unweighted):");
            PrintMatrix(graph.AdjacencyMatrix);
            Console.WriteLine();
        }
        
        private static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void PrintUnweightedList<T>(List<List<T>> adjacencyList)
        {
            Console.WriteLine("Adjacency List (Unweighted):");
            for (int i = 0; i < adjacencyList.Count; i++)
            {
                Console.Write($"{i}: ");
                foreach (var item in adjacencyList[i])
                {
                    Console.Write($"{item}, ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}