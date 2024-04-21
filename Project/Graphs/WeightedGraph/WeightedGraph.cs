namespace Project.Graphs
{
    internal class WeightedGraph : SimpleGraph<WeightedEdge>
    {
        public WeightedGraph(int vertices) : base(vertices)
        {
        }

        public override void AddVertex()
        {
            int vertices = Size + 1;
            int[,] newMatrix = new int[vertices, vertices];
            
            Array.Copy(AdjacencyMatrix, newMatrix, AdjacencyMatrix.Length);

            AdjacencyMatrix = newMatrix;
            AdjacencyList.Add(new List<WeightedEdge>());
        }

        public override void AddEdge(int startVertex, int endVertex, int weight = 1)
        {
            AdjacencyList[startVertex].Add(new WeightedEdge(endVertex, weight));
            AdjacencyList[endVertex].Add(new WeightedEdge(startVertex, weight));

            AdjacencyMatrix[startVertex, endVertex] = weight;
            AdjacencyMatrix[endVertex, startVertex] = weight;
        }

        public override void RemoveEdge(int startVertex, int endVertex)
        {
            AdjacencyList[startVertex].Remove(AdjacencyList[startVertex].Find(edge => edge.Vertex == endVertex));
            AdjacencyList[endVertex].Remove(AdjacencyList[endVertex].Find(edge => edge.Vertex == startVertex));

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
                    Console.Write($"{item.Vertex}|({item.Weight}), ");
                }
                Console.WriteLine();
            }
        }
    }
}

