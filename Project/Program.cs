using Project.Algorithms;

namespace Project.Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            UnweightedGraph<int> unweightedGraph = new UnweightedGraph<int>(5);

            unweightedGraph.AddEdge(0, 1);
            unweightedGraph.AddEdge(0, 2);
            unweightedGraph.AddEdge(1, 3);
            unweightedGraph.AddEdge(2, 4);
            unweightedGraph.AddEdge(1, 4);
            
            GraphVisualization.PrintUnweightedMatrix(unweightedGraph);

            GraphVisualization.PrintUnweightedList(unweightedGraph.AdjacencyList);
            
            DFS.DFSUse(unweightedGraph, 0); 
            BFS.BFSUse(unweightedGraph, 0); 
            
        }
    }
}