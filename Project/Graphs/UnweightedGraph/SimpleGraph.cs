using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Graphs
{
    public abstract class SimpleGraph <T>
    {
        protected internal int[,] AdjacencyMatrix;
        protected  List<List<T>> AdjacencyList;

        public int Size => AdjacencyMatrix.GetLength(0);

        protected SimpleGraph(int vertices)
        {
            AdjacencyMatrix = new int[vertices, vertices];
            AdjacencyList = new List<List<T>>();
            for (int i = 0; i < vertices; i++)
            {
                AdjacencyList.Add(new List<T>());
            }
        }
        
        public abstract void AddVertex();
        public abstract void AddEdge(int startVertex, int endVertex, int weight = 1);
        public abstract void RemoveEdge(int startVertex, int endVertex);
        
    }
}

