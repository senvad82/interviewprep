using System;
using System.Collections.Generic;
using System.Text;

namespace ds
{
    
    public static class TwoSumClosest
    {


        //Prime Air Route
        public static int[][] GetTwoSumClosest(int[][] arr1, int[][] arr2, int target)
        {
            // find length of array and assign it to 
            // naive solution would putting in 2 loops.
            // check each combination and maintain min distance
            // Time Complexity O(n)
            int n = arr1.Length;
            int m = arr2.Length;
            int minDistance = Int32.MaxValue;
            int[][] minDistValue = new int[1][] { new int[] { -1, -1 } };

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    //Console.WriteLine(arr1[i][1]);
                    //Console.WriteLine(arr1[j][1]);
                    int temp = arr1[i][1] + arr2[j][1];
                    //Console.WriteLine(temp);
                    if (temp <= target)
                    {
                        if (target - temp < minDistance)
                        {
                            minDistance = target - temp;
                            minDistValue = new int[1][] { new int[] { arr1[i][0], arr2[j][0] } };
                        }

                    }
                }
            }

            // Two Pointer Approach
            // Two pointers one pointer each Arry

            return minDistValue;

        }



    }
}
