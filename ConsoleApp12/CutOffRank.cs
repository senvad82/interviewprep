using System;
using System.Collections.Generic;
using System.Text;

namespace ds
{
    
    public static class CutOffRank
    {
        
        
        public static int GetCutOffRank(int[] scores, int cutoffRank)
        {
            Array.Sort(scores);

            //var scores = new int[] { 20, 40, 40, 40, 40, 100 }; 
            //var cutoffRank = 3;
            int curRank = 1;
            int prevRank = 1;            
            int count = 1;
            int globalRank = 1;
            int[] rank = new int[scores.Length];
            for(int i= scores.Length-2; i > 0; i--)
            {
                globalRank++;
                if (scores[i] == scores[i + 1])
                {
                    curRank = prevRank;
                }
                else
                {
                    curRank = globalRank;
                }
                if(curRank <= cutoffRank)
                {
                    count++;
                    prevRank = curRank;
                }
                else
                {
                    break;
                }
                
            }

            return count;    
        }


       
    }
}
