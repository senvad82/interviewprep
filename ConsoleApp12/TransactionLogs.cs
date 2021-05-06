using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ds
{
    
    public static class TransactionLogs
    {       
        
        public static List<int> GetUserOverLimit(int[][] logs, int thresold)
        {
            int r = logs.Length;
            Dictionary<int, int> userCount = new Dictionary<int, int>();
            for (int i = 0; i < r; i++)
            {
                int user1 = logs[i][0];
                int user2 = logs[i][1];
                if(userCount.ContainsKey(user1))
                {
                    userCount[user1] = userCount[user1] + 1;
                    
                }
                else
                {
                    userCount.Add(user1, 1);
                }
                if (user1 != user2 && userCount.ContainsKey(user1))
                {
                    userCount[user2] = userCount[user2] + 1;
                }
                else if (!userCount.ContainsKey(user2))
                {
                    userCount.Add(user2, 1);
                }

            }
            return userCount.Where(y=> y.Value>3).OrderByDescending(x => x.Value).Select(x => x.Key).ToList();
           

        }


       
    }
}
