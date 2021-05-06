using System;
using System.Collections.Generic;
using System.Text;

namespace ds
{
    
    public static class OptimalUtilization
    {
        
        
        public static int[][] GetOptimalUtilization(int[][] a, int[][] b, int target)
        {
            
            int n = a.Length;
            int m = b.Length;
            List<int[]> result = new List<int[]>();
            int minDiff = int.MaxValue;
            int[] minDiffList = new int[2];
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    Console.WriteLine($"{a[i][1]}:{b[j][1]}");
                    if (a[i][1]+b[j][1] == target)
                    {
                        result.Add(new int[2] { a[i][0], a[j][0] });                        
                    }
                    else if(a[i][1] + b[j][1] > target)
                    {
                        continue;
                    }
                    else if((target - (a[i][1] + b[j][1])) < minDiff)
                    {
                        minDiff = (target - (a[i][1] + b[j][1]));
                        minDiffList = new int[2] { a[i][0], a[j][0] };
                    }
                    Console.WriteLine($"mindiff {minDiffList[0]}:{minDiffList[1]}");
                }
            }
            if (result.Count > 0)
            {
                return result.ToArray();
            }                
            else
            {
                result.Clear();
                Console.WriteLine($"mindiff2 {minDiffList[0]}:{minDiffList[1]}");
                result.Add(minDiffList);
                return result.ToArray();
            }
                
        }


       
    }
}
