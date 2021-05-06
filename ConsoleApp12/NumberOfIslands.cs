using System;
using System.Collections.Generic;
using System.Text;

namespace ds
{

    public class NumberOfIslands
    {
        public int NumIslands1(char[][] grid) {
          if (grid == null) return 0;
          var m = grid.Length;
          var n = grid[0].Length;        
          var numberOfIslands = 0;
          for(int i=0;i<m;i++){
              for(int j=0;j<n;j++){
                if(grid[i][j]=='1') numberOfIslands++;
                 DFS(grid, i, j, m, n);                
              }            
          }
          return numberOfIslands;



      }
      public void DFS(char[][] grid, int r, int c, int rl, int cl){
          if(r<0 || c<0 || r>=rl || c>=cl || grid[r][c]=='0') return;
          grid[r][c]='0';
          Console.WriteLine("------------");
          Console.WriteLine(r);
          Console.WriteLine(c);
          DFS(grid, r-1, c,rl,cl);
          DFS(grid, r+1, c,rl,cl);
          DFS(grid, r, c+1,rl,cl);
          DFS(grid, r, c-1,rl,cl);
      }

        public int NumIslands2(char[][] grid)
        {
            var m = grid.Length;
            var n = grid[0].Length;

            SetupUnion(grid, m, n);
            Console.WriteLine(numberOfConnectedComponents);
            for (int r = 0; r < m; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    if (grid[r][c] == '1')
                    {
                        if (c + 1 < n && grid[r][c + 1] == '1')
                        {
                            UnionJoin(n * r + c, n * r + c + 1);
                        }
                        if (r + 1 < m && grid[r + 1][c] == '1')
                        {
                            UnionJoin(n * r + c, n * (r + 1) + c);
                        }
                        if (c - 1 >= 0 && grid[r][c - 1] == '1')
                        {
                            UnionJoin(n * r + c, n * r + (c - 1));
                        }
                        if (r - 1 >= 0 && grid[r - 1][c] == '1')
                        {
                            UnionJoin(n * r + c, n * (r - 1) + c);
                        }
                    }
                }
            }
            return numberOfConnectedComponents;


        }
        int[] parent;
        int[] rank;
        int numberOfConnectedComponents = 0;
        public void SetupUnion(char[][] grid, int m, int n)
        {
            if (grid == null) return;
            parent = new int[m * n];
            rank = new int[m * n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        parent[i * n + j] = i * n + j;
                        numberOfConnectedComponents++;
                    }

                }
            }

        }
        public int UnionFind(int x)
        {
            if (parent[x] == x) return x;
            parent[x] = UnionFind(parent[x]);
            return parent[x];
        }

        public void UnionJoin(int x, int y)
        {
            Console.WriteLine($"Union: {x}:{y}");
            int rep_x = UnionFind(x);
            int rep_y = UnionFind(y);

            if (rep_x == rep_y) return;
            numberOfConnectedComponents--;
            if (rank[rep_x] > rank[rep_y])
            {
                parent[y] = rep_x;
                //numberOfConnectedComponents--;
            }
            else if (rank[rep_y] > rank[rep_x])
            {
                parent[x] = rep_y;
                //numberOfConnectedComponents--;
            }
            else
                parent[y] = rep_x; rank[rep_x]++;

            Console.WriteLine($"numberOfConnectedComponents: {numberOfConnectedComponents}");
        }




    }
}
