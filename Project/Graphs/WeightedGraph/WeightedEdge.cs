namespace Project.Graphs
{
    internal class WeightedEdge
    {
        public int Vertex { get; }
        public int Weight { get; }

        public WeightedEdge(int vertex, int weight)
        {
            Vertex = vertex;
            Weight = weight;
        }
    }
}