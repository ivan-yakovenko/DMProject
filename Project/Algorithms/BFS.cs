using Project.Graphs;

namespace Project.Algorithms;

public class BFS
{
    public static void BFSUse(UnweightedGraph<int> graph, int startVertex)
    {
        bool[] visited = new bool[graph.Size];
        Queue<int> vertices = new Queue<int>();

        visited[startVertex] = true;
        vertices.Enqueue(startVertex);

        while (vertices.Count != 0)
        {
            int vertex = vertices.Dequeue();
            Console.WriteLine(vertex + " ");

            foreach (int neighbour in graph.AdjacencyList[vertex])
            {
                if (!visited[neighbour])
                {
                    vertices.Enqueue(neighbour);
                    visited[neighbour] = true;
                }
            }
            
        }
    }
}