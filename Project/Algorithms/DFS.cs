using Project.Graphs;

namespace Project.Algorithms;

public static class DFS
{
    public static void DFSUse(UnweightedGraph<int> graph, int startVertex)
    {
        bool[] visited = new bool[graph.Size];
        Stack<int> vertices = new Stack<int>();

        visited[startVertex] = true;
        vertices.Push(startVertex);

        while (vertices.Count != 0)
        {
            int vertex = vertices.Pop();

            foreach (int neighbour in graph.AdjacencyList[vertex])
            {
                if (!visited[neighbour])
                {
                    vertices.Push(neighbour);
                    visited[neighbour] = true;
                }
            }
            
        }
    }

}