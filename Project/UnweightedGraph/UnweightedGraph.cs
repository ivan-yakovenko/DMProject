namespace Project.Graphs
{
    public class UnweightedGraph<T>
    {
        protected internal int[,] AdjacencyMatrix;
        protected internal List<List<int>> AdjacencyList;

        public int Size => AdjacencyMatrix.GetLength(0);

        public UnweightedGraph(int vertices)
        {
            AdjacencyMatrix = new int[vertices, vertices];
            AdjacencyList = new List<List<int>>();
            for (int i = 0; i < vertices; i++)
            {
                AdjacencyList.Add(new List<int>());
            }
        }

        public void AddVertex()
        {
            int vertices = Size + 1;
            int[,] newMatrix = new int[vertices, vertices];

            Array.Copy(AdjacencyMatrix, newMatrix, AdjacencyMatrix.Length);
            AdjacencyMatrix = newMatrix;

            AdjacencyList.Add(new List<int>());
        }

        public void AddEdge(int startVertex, int endVertex, int weight = 1)
        {
            AdjacencyList[startVertex].Add(endVertex);
            AdjacencyList[endVertex].Add(startVertex);

            AdjacencyMatrix[startVertex, endVertex] = 1;
            AdjacencyMatrix[endVertex, startVertex] = 1;
        }

        public void RemoveEdge(int startVertex, int endVertex)
        {
            AdjacencyList[startVertex].Remove(endVertex);
            AdjacencyList[endVertex].Remove(startVertex);

            AdjacencyMatrix[startVertex, endVertex] = 0;
            AdjacencyMatrix[endVertex, startVertex] = 0;
        }
    }
}