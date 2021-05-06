using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ds
{
    
    public static class ConnectedComponets
    {


        public static int FindCircleNum(int[][] isConnected)
        {
            int r = isConnected.Length;
            int c = isConnected[0].Length;
            int connectedComponents = 0;
            int[] visited = new int[r];
            for (int i = 0; i < r; i++)
            {
                if (visited[i] == 0)
                {
                    DFS(isConnected, visited, i);
                    connectedComponents++;
                }


            }

            return connectedComponents;
        }

        public static void DFS(int[][] isConnected, int[] visited, int i)
        {

            for (int j = 0; j < isConnected.Length; j++)
            {

                if (isConnected[i][j] == 1 && visited[j] == 0)
                {
                    visited[j] = 1;
                    Console.WriteLine(j);
                    DFS(isConnected, visited, j);
                }

            }

            return;

        }

        public static int BFS(int[][] isConnected)
        {
            Queue<int> q = new Queue<int>(isConnected.Length);
            int[] visited = new int[isConnected.Length];
            int connectedComponents = 0;
            for (int i = 0; i < isConnected.Length; i++)
            {
                if (visited[i] == 0)
                {
                    q.Enqueue(i);
                    connectedComponents++;
                }

                while (q.Count() > 0)
                {
                    int t = q.Dequeue();
                    visited[t] = 1;
                    for (int j = 0; j < isConnected.Length; j++)
                    {
                        if (isConnected[t][j] == 1 && visited[j] == 0)
                        {
                            q.Enqueue(j);
                        }

                    }
                }

            }
            return connectedComponents;


        }



    }
}
