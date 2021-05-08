using System;
using System.Collections.Generic;
using System.Text;

namespace ds
{
    
    public static class NumbersDivisibleBy60
    {

        public static int NumPairsDivisibleBy60(int[] time)
        {

            // maintain map of possibleLoop through all elements 

            int[] map = new int[60];
            int n = time.Length;
            if (n == 0) return 0;
            int count = 0;
            for (int i = 0; i < n; i++)
            {

                var remain = time[i] % 60;

                if (remain == 0)
                {
                    count += map[0];
                    map[0]++;
                }
                else
                {
                    count += map[60 - remain];
                    map[remain]++;
                }
            }
            return count;

        }


    }
}
