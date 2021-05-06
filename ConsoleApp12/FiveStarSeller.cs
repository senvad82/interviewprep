using System;
using System.Collections.Generic;
using System.Text;

namespace ds
{
    public static class FiveStarSeller
    {
        //var ratings = new int[][] { new int[] { 4, 4 }, new int[] { 1, 2 }, new int[] { 3, 6 } };
        //int threshold = 77;
        //int result = FiveStarSeller.fiveStar(ratings, threshold)
        // (4/4) + (1/2) + (3/6) = 100 + 50 + 50/3 = 200/3 =  66 = 
        // (5/5) + 2/3
        public static int GetMinimumReviewsNeeded(int[][] ratings, int target)
        {
            int ratingsLength = ratings.Length;            
            double tempRating = 0;
            double currentRatingPct = 0;
            int res=0;
            for (int i = 0; i < ratingsLength; i++)
            {
                double rate = (double)ratings[i][0] / (double)ratings[i][1];
                tempRating += (rate * 100);
            }
            currentRatingPct = tempRating / ratingsLength;

            while (currentRatingPct < target)
            {
                double maxdiff = int.MinValue;
                int maxIndex = 0;
                for (int i=0; i< ratingsLength; i++)
                {
                    double rate = (double)ratings[i][0] / (double)ratings[i][1];
                    tempRating = (rate * 100);

                    if (tempRating == 100)
                        continue;
                    double increasedCalc = (((double)ratings[i][0] + 1) / ((double)ratings[i][1] + 1)) * 100;
                    double currentDiff = increasedCalc - tempRating;

                    if (currentDiff > maxdiff)
                    {
                        maxdiff = currentDiff;
                        maxIndex = i;
                    }                    
                    
                }
                currentRatingPct = currentRatingPct + maxdiff;
                res++;
                ratings[maxIndex][0]++;
                ratings[maxIndex][1]++;
            }

            return res;

        }
    }
}
