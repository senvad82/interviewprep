using System;
using System.Collections.Generic;
using System.Text;

namespace ds
{
    
    public static class MaximumSquaresMatrix
    {


        public static int MaximalSquare(char[][] matrix)
        {

            if (matrix == null) return 0;

            int r = matrix.Length;
            int c = matrix[0].Length;

            int mpl = Math.Min(r, c);
            int count = 0;
            return GetSquares(matrix, mpl, r, c, count);

        }

        public static int GetSquares(char[][] matrix, int l, int r, int c, int count)
        {
            bool found = true;
            if (l == 0) return 0;
            if (count > 0 && l == 1) return 1;

            for (int i = 0; i < l && i < r; i++)
            {

                for (int j = 0; j < l && j < c; j++)
                {
                    Console.WriteLine($"{i}:{j}:{matrix[i][j]}");
                    if (matrix[i][j] == '0')
                    {
                        found = false;
                        break;
                    }
                    else
                    {
                        count++;
                    }
                }


            }
            if (found)
                return l;
            else
                return GetSquares(matrix, l - 1, r, c, count);


        }

        //DP
        public static int MaximalSquare2(char[][] matrix)
        {

            if (matrix == null) return 0;
            int maSquare = 0;
            int r = matrix.Length;
            int c = matrix[0].Length;
            int count = 0;

            int[][] dp = new int[r][];

            for (int i = 0; i < r; i++)
            {
                dp[i] = new int[c];
            }

            for (int i = 0; i < c; i++)
            {
                if (matrix[0][i] == '1')
                {
                    dp[0][i] = 1;
                    count++;
                }
                else
                {
                    dp[0][i] = 0;
                }

            }

            for (int j = 0; j < r; j++)
            {
                if (matrix[j][0] == '1')
                {
                    dp[j][0] = 1;
                    count++;
                }
                else
                {
                    dp[j][0] = 0;
                }
            }

            for (int i = 1; i < r; i++)
            {
                for (int j = 1; j < c; j++)
                {
                    Console.WriteLine($"{i}:{j}:{matrix[i][j]}");
                    if (matrix[i][j] == '1')
                    {
                        count++;
                        dp[i][j] = 1 + Math.Min(dp[i - 1][j], Math.Min(dp[i][j - 1], dp[i - 1][j - 1]));
                        maSquare = Math.Max(maSquare, dp[i][j]);
                    }
                    else
                    {
                        dp[i][j] = 0;
                    }

                    Console.WriteLine($"dpij:{dp[i][j]}:msq {maSquare}:");

                }
            }
            return (count > 0) && (maSquare == 0) ? 1 : maSquare * maSquare;

        }



    }
}
