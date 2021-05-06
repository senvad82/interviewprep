using System;
using System.Collections.Generic;
using System.Text;

namespace ds
{
    
    public static class UtilizationChecks
    {
        
        
        public static double GetUtilizationChecks(int[] a, int instances)
        {
            int n = a.Length;
            double desiredInstances = (double)instances;
            for (int i= 0;i < n; i++)
            {
                if (a[i] < 25 && desiredInstances > 1)
                {
                    desiredInstances = Math.Ceiling(desiredInstances / 2);
                    i = i + 10;
                }
                if (a[i] > 60 && desiredInstances *2 > 100000000)
                {
                    desiredInstances = desiredInstances * 2;
                    i = i + 10;
                }
            }

            return desiredInstances;
                
        }


       
    }
}
