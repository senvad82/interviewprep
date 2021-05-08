using System;
using System.Collections.Generic;
using System.Text;

namespace ds
{
    
    public static class SlowestKeys
    {


        public static char SlowestKey(int[] releaseTimes, string keysPressed)
        {

            int longerKeyDuration = releaseTimes[0];
            char longerKey = keysPressed[0];
            for (int i = 1; i < releaseTimes.Length; i++)
            {
                if ((releaseTimes[i] - releaseTimes[i - 1]) > longerKeyDuration)
                {
                    longerKeyDuration = (releaseTimes[i] - releaseTimes[i - 1]);
                    longerKey = (keysPressed[i]);
                }
                else if ((releaseTimes[i] - releaseTimes[i - 1]) == longerKeyDuration)
                {
                    longerKey = (keysPressed[i] > 'a') ? keysPressed[i] : longerKey;
                }

            }

            return longerKey;
        }


    }
}
