using System;
using System.Collections.Generic;
using System.Text;
using PriorityQueues;

namespace ds
{
    
    public static class TurnStile
    {
        public class visitor
        {
            int id;
            int time;
            public visitor(int id, int time)
            {
                this.id = id;
                this.time = time;

            }
        }
       
        public static int[] GetTurnStile(int[] times, int[] direction)
        {
            // times[] = [0,0,1,5]
            // directions[] = [0,1,1,0]

            Queue<visitor> entry = new Queue<visitor>();
            Queue<visitor> exit = new Queue<visitor>();

            for(int i = 0; i < times.Length; i++)
            {
                if (direction[i] == 1)
                    exit.Enqueue(new visitor(i, times[i]));
                else
                    entry.Enqueue(new visitor(i, times[i]));
            }



            return new int[2];
                
        }


       
    }
}
