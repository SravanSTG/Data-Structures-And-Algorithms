using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Graph
    {
        public int numberOfNodes;
        public Dictionary<int, List<int>> adjacentList;

        public Graph()
        {
            numberOfNodes = 0;
            adjacentList = new Dictionary<int, List<int>>();
        }

        public void AddVertex(int value)
        {
            adjacentList.Add(value, new List<int>());
            numberOfNodes++;
        }

        public void AddEdge(int value1, int value2)
        {
            adjacentList[value1].Add(value2);
            adjacentList[value2].Add(value1);
        }

        public void ShowConnections()
        {
            List<int> nodes = new List<int>();
            foreach(var item in adjacentList)
            {
                nodes = adjacentList[item.Key];
                StringBuilder connections = new StringBuilder();
                foreach(var edge in nodes)
                {
                    connections.Append(edge).Append(" ");
                }
                Console.WriteLine(item.Key + "--> " + connections);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Graph graph = new Graph();
            graph.AddVertex(0);
            graph.AddVertex(1);
            graph.AddVertex(2);
            graph.AddVertex(3);
            graph.AddVertex(4);
            graph.AddVertex(5);
            graph.AddVertex(6);
            graph.AddEdge(3, 1);
            graph.AddEdge(3, 4);
            graph.AddEdge(4, 2);
            graph.AddEdge(4, 5);
            graph.AddEdge(1, 2);
            graph.AddEdge(1, 0);
            graph.AddEdge(0, 2);
            graph.AddEdge(6, 5);
            graph.ShowConnections();

            Console.Read();
        }
    }
}
