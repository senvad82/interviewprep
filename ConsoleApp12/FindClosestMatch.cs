using System;
using System.Collections.Generic;
using System.Text;

namespace ds
{
    
    public static class ClosestMatch
    {


        //Prime Air Route
        public static int FindClosestMatch(int[] availableBoxes, int productSize)
        {
            //Since Array is sorted binary search would provide best efficient solution

            int left = 0;
            int right = availableBoxes.Length - 1;
            while (left < right)
            {
                int mid = (left + right) / 2;
                if (availableBoxes[mid] == productSize)
                {
                    return availableBoxes[mid];
                }
                //Console.WriteLine(left);
                //Console.WriteLine(right);
                //Console.WriteLine(mid);
                if (availableBoxes[mid] > productSize)
                {

                    right = mid - 1;
                }
                else if (availableBoxes[mid] < productSize)
                {
                    left = mid + 1;
                }

            }
            if (availableBoxes[left] > productSize)
                return availableBoxes[left];
            else if (left < availableBoxes.Length - 1)
                return availableBoxes[left + 1];
            else return -1;

            //return 0;
        }           // Two Pointer Approach
        


    }
}
