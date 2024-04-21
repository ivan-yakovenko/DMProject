namespace Project.Graphs;

public class GraphGenerator
{
    public static void GenerateGraph(UnweightedGraph<int> graph, double probability)
    {
        Random random = new Random();

        for (int i = 0; i < graph.Size; i++)
        {
            for (int j = i+1; j < graph.Size; j++)
            {
                if (random.NextDouble() < probability)
                {
                    graph.AddEdge(i,j);
                }
            }
        }
    }
}