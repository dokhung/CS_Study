using System;
using System.Collections.Generic;

    public class Graph
    {
        int[,] mat; //정점들간의 관계
        List<string> vertexList = new List<string>();  //정점내용
        int size;
        bool digraph = false;

        public Graph(string[] vertexContents, bool digraph = false)
        {
            this.vertexList = new List<string>(vertexContents);
            this.size = vertexList.Count; //vertexContents.Length
            this.mat = new int[size, size];
            this.digraph = digraph;
        }

        public void AddEdge(string from, string to, int weight = 1) //정점내용으로 하는것
        {
            int iFrom = vertexList.FindIndex(s => s == from);
            int iTo = vertexList.FindIndex(s => s == to);
            AddEdge(iFrom, iTo, weight);
        }

        public void AddEdge(int from, int to, int weight = 1) //해당 행렬의 위치를 정확히 알 때
        {
            mat[from, to] = weight;
            if (!digraph) //방향성이 없다면 반대의 경우도 넣어줌
            {
                mat[to, from] = weight;
            }
        }

        public void RemoveEdge(string from, string to)
        {
            int iFrom = vertexList.FindIndex(s => s == from);
            int iTo = vertexList.FindIndex(s => s == to);
            RemoveEdge(iFrom, iTo);
        }
        public void RemoveEdge(int from, int to)
        {
            mat[from, to] = 0;
            if (!digraph)
            {
                mat[to, from] = 0;
            }
        }

        public void Print()
        {
            Console.Write("  ");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{vertexList[i]} ");
            }
            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{vertexList[i]} ");
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"{mat[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] contents = { "A", "B", "C", "D" };
            var graph = new Graph(contents);
            graph.AddEdge("A", "B");
            graph.AddEdge("A", "C");
            graph.AddEdge("A", "D");
            graph.AddEdge("B", "D");

            graph.Print();
        }
    }